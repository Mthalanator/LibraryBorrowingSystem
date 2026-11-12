using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryBorrowingSystem
{
    public partial class frmBorrows : Form
    {
        public frmBorrows()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgvBooks.AutoGenerateColumns = true;
            dgvMembers.AutoGenerateColumns = true;

            // Direct execution inside constructor ensures data loads reliably
            LoadBooks();
            LoadMembers();
        }

        private void frmBorrows_Load(object sender, EventArgs e)
        {
            this.Text = "Library Borrowing System";
        }

        private void LoadBooks(string search_query = "")
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string sql_query = "SELECT book_id, title, author, genre, available FROM books";
                    if (!string.IsNullOrWhiteSpace(search_query))
                    {
                        sql_query += " WHERE title LIKE @search OR author LIKE @search OR genre LIKE @search";
                    }

                    SqlCommand cmd = new SqlCommand(sql_query, conn);
                    if (!string.IsNullOrWhiteSpace(search_query))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search_query + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt_books = new DataTable();
                    adapter.Fill(dt_books);
                    dgvBooks.DataSource = dt_books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtSearchBooks.Text.Trim());
        }

        private void txtSearchMembers_TextChanged(object sender, EventArgs e)
        {
            LoadMembers(txtSearchMembers.Text.Trim());
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBookSelection();
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            UpdateBookSelection();
        }

        private void UpdateBookSelection()
        {
            if (dgvBooks.CurrentRow != null && dgvBooks.CurrentRow.Index >= 0)
            {
                txtBookID.Text = dgvBooks.CurrentRow.Cells["book_id"].Value?.ToString();
                txtBookTitle.Text = dgvBooks.CurrentRow.Cells["title"].Value?.ToString();
            }
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
                txtMemberID.Text = dgvMembers.CurrentRow.Cells["member_id"].Value?.ToString();
                txtMemberName.Text = dgvMembers.CurrentRow.Cells["name"].Value?.ToString();
            }
        }

        private void btnLogBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) || string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                MessageBox.Show("Please select both a book and a member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvBooks.CurrentRow != null)
            {
                bool is_available = Convert.ToBoolean(dgvBooks.CurrentRow.Cells["available"].Value);
                if (!is_available)
                {
                    MessageBox.Show("This book is currently unavailable for borrowing.", "Unavailable Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int selected_book_id = Convert.ToInt32(txtBookID.Text);
            int selected_member_id = Convert.ToInt32(txtMemberID.Text);
            DateTime borrow_date = dtpBorrowDate.Value.Date;
            DateTime due_date = dtpDueDate.Value.Date;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction db_transaction = conn.BeginTransaction();

                try
                {
                    string insert_borrow_query = @"INSERT INTO borrow_records (book_id, member_id, borrow_date, due_date, return_date)
                                                   VALUES (@book_id, @member_id, @borrow_date, @due_date, NULL)";
                    SqlCommand cmd_insert = new SqlCommand(insert_borrow_query, conn, db_transaction);
                    cmd_insert.Parameters.AddWithValue("@book_id", selected_book_id);
                    cmd_insert.Parameters.AddWithValue("@member_id", selected_member_id);
                    cmd_insert.Parameters.AddWithValue("@borrow_date", borrow_date);
                    cmd_insert.Parameters.AddWithValue("@due_date", due_date);
                    cmd_insert.ExecuteNonQuery();

                    string update_book_query = "UPDATE books SET available = 0 WHERE book_id = @book_id";
                    SqlCommand cmd_update = new SqlCommand(update_book_query, conn, db_transaction);
                    cmd_update.Parameters.AddWithValue("@book_id", selected_book_id);
                    cmd_update.ExecuteNonQuery();

                    db_transaction.Commit();

                    MessageBox.Show("Borrow record logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    db_transaction.Rollback();
                    MessageBox.Show("Transaction failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmReturns returns_form = new frmReturns();
            returns_form.ShowDialog();
            LoadBooks();
        }
    }
}