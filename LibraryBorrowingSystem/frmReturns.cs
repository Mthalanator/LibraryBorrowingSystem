using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryBorrowingSystem
{
    public partial class frmReturns : Form
    {
        public frmReturns()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgvMembers.AutoGenerateColumns = true;
            dgvBorrowRecords.AutoGenerateColumns = true;

            // Direct execution inside constructor ensures data loads reliably
            LoadMembers();
        }

        private void frmReturns_Load(object sender, EventArgs e)
        {
            this.Text = "Sduduzo Mtalane - 23/09/2026";
        }

        private void LoadMembers(string search_query = "")
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string sql_query = "SELECT member_id, name, email FROM members";
                    if (!string.IsNullOrWhiteSpace(search_query))
                    {
                        sql_query += " WHERE name LIKE @search OR email LIKE @search";
                    }

                    SqlCommand cmd = new SqlCommand(sql_query, conn);
                    if (!string.IsNullOrWhiteSpace(search_query))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search_query + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt_members = new DataTable();
                    adapter.Fill(dt_members);
                    dgvMembers.DataSource = dt_members;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchMembers_TextChanged(object sender, EventArgs e)
        {
            LoadMembers(txtSearchMembers.Text.Trim());
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMemberSelection();
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateMemberSelection();
        }

        private void UpdateMemberSelection()
        {
            if (dgvMembers.CurrentRow != null && dgvMembers.CurrentRow.Index >= 0)
            {
                string member_id = dgvMembers.CurrentRow.Cells["member_id"].Value?.ToString();
                string member_name = dgvMembers.CurrentRow.Cells["name"].Value?.ToString();

                txtMemberID.Text = member_id;
                txtMemberName.Text = member_name;

                if (int.TryParse(member_id, out int parsed_member_id))
                {
                    LoadMemberBorrowRecords(parsed_member_id);
                }
            }
        }

        private void LoadMemberBorrowRecords(int member_id)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string sql_query = @"SELECT br.transaction_id AS id, br.book_id, b.title, br.borrow_date, br.due_date, br.return_date 
                                         FROM borrow_records br
                                         JOIN books b ON br.book_id = b.book_id
                                         WHERE br.member_id = @member_id";

                    SqlCommand cmd = new SqlCommand(sql_query, conn);
                    cmd.Parameters.AddWithValue("@member_id", member_id);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt_borrows = new DataTable();
                    adapter.Fill(dt_borrows);
                    dgvBorrowRecords.DataSource = dt_borrows;

                    CalculateTotalFines(dt_borrows);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrow records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotalFines(DataTable dt_borrows)
        {
            int total_fine_amount = 0;
            DateTime return_selected_date = dtpReturnDate.Value.Date;

            foreach (DataRow row in dt_borrows.Rows)
            {
                if (row["return_date"] == DBNull.Value)
                {
                    DateTime due_date = Convert.ToDateTime(row["due_date"]).Date;
                    if (due_date < return_selected_date)
                    {
                        int days_overdue = (return_selected_date - due_date).Days;
                        if (days_overdue > 0)
                        {
                            total_fine_amount += days_overdue * 5;
                        }
                    }
                }
            }

            lblTotalFines.Text = $"Total fines owed: R{total_fine_amount}";
        }

        private void dgvBorrowRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBorrowRecordSelection();
        }

        private void dgvBorrowRecords_SelectionChanged(object sender, EventArgs e)
        {
            UpdateBorrowRecordSelection();
        }

        private void UpdateBorrowRecordSelection()
        {
            if (dgvBorrowRecords.CurrentRow != null && dgvBorrowRecords.CurrentRow.Index >= 0)
            {
                txtRecordID.Text = dgvBorrowRecords.CurrentRow.Cells["id"].Value?.ToString();
                txtBookID.Text = dgvBorrowRecords.CurrentRow.Cells["book_id"].Value?.ToString();
                txtBookTitle.Text = dgvBorrowRecords.CurrentRow.Cells["title"].Value?.ToString();
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMemberID.Text, out int member_id))
            {
                if (dgvBorrowRecords.DataSource is DataTable dt_borrows)
                {
                    CalculateTotalFines(dt_borrows);
                }
            }
        }

        private void btnLogReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecordID.Text) || string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please select a borrow record to return.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvBorrowRecords.CurrentRow != null && dgvBorrowRecords.CurrentRow.Cells["return_date"].Value != DBNull.Value)
            {
                MessageBox.Show("This book has already been returned.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int record_id = Convert.ToInt32(txtRecordID.Text);
            int book_id = Convert.ToInt32(txtBookID.Text);
            DateTime return_date = dtpReturnDate.Value.Date;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction db_transaction = conn.BeginTransaction();

                try
                {
                    string update_record_query = "UPDATE borrow_records SET return_date = @return_date WHERE transaction_id = @record_id";
                    SqlCommand cmd_record = new SqlCommand(update_record_query, conn, db_transaction);
                    cmd_record.Parameters.AddWithValue("@return_date", return_date);
                    cmd_record.Parameters.AddWithValue("@record_id", record_id);
                    cmd_record.ExecuteNonQuery();

                    string update_book_query = "UPDATE books SET available = 1 WHERE book_id = @book_id";
                    SqlCommand cmd_book = new SqlCommand(update_book_query, conn, db_transaction);
                    cmd_book.Parameters.AddWithValue("@book_id", book_id);
                    cmd_book.ExecuteNonQuery();

                    db_transaction.Commit();

                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (int.TryParse(txtMemberID.Text, out int member_id))
                    {
                        LoadMemberBorrowRecords(member_id);
                    }
                }
                catch (Exception ex)
                {
                    db_transaction.Rollback();
                    MessageBox.Show("Error processing return: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}