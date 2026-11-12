namespace LibraryBorrowingSystem
{
    partial class frmReturns
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMembersHeader = new System.Windows.Forms.Label();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.dgvBorrowRecords = new System.Windows.Forms.DataGridView();
            this.lblRecordID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalFines = new System.Windows.Forms.Label();
            this.btnLogReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembersHeader
            // 
            this.lblMembersHeader.Location = new System.Drawing.Point(15, 12);
            this.lblMembersHeader.Name = "lblMembersHeader";
            this.lblMembersHeader.Size = new System.Drawing.Size(85, 20);
            this.lblMembersHeader.Text = "Members List";
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.Location = new System.Drawing.Point(105, 9);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.Size = new System.Drawing.Size(460, 23);
            this.txtSearchMembers.TextChanged += new System.EventHandler(this.txtSearchMembers_TextChanged);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(15, 36);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(550, 120);
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // lblMemberID
            // 
            this.lblMemberID.Location = new System.Drawing.Point(15, 163);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(70, 18);
            this.lblMemberID.Text = "Member ID";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(95, 163);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 18);
            this.lblName.Text = "Name";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(15, 182);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(70, 23);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(95, 182);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(200, 23);
            // 
            // dgvBorrowRecords
            // 
            this.dgvBorrowRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowRecords.Location = new System.Drawing.Point(15, 215);
            this.dgvBorrowRecords.Name = "dgvBorrowRecords";
            this.dgvBorrowRecords.ReadOnly = true;
            this.dgvBorrowRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowRecords.Size = new System.Drawing.Size(550, 130);
            this.dgvBorrowRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowRecords_CellClick);
            // 
            // lblRecordID
            // 
            this.lblRecordID.Location = new System.Drawing.Point(15, 355);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(60, 18);
            this.lblRecordID.Text = "Record ID";
            // 
            // lblBookID
            // 
            this.lblBookID.Location = new System.Drawing.Point(85, 355);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(50, 18);
            this.lblBookID.Text = "Book ID";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(145, 355);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(70, 18);
            this.lblBookTitle.Text = "Book Title";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Location = new System.Drawing.Point(315, 355);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(80, 18);
            this.lblReturnDate.Text = "Return Date";
            // 
            // txtRecordID
            // 
            this.txtRecordID.Location = new System.Drawing.Point(15, 374);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.ReadOnly = true;
            this.txtRecordID.Size = new System.Drawing.Size(60, 23);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(85, 374);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(50, 23);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(145, 374);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(160, 23);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(315, 374);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(250, 23);
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblTotalFines
            // 
            this.lblTotalFines.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalFines.Location = new System.Drawing.Point(15, 410);
            this.lblTotalFines.Name = "lblTotalFines";
            this.lblTotalFines.Size = new System.Drawing.Size(250, 25);
            this.lblTotalFines.Text = "Total fines owed: R0";
            // 
            // btnLogReturn
            // 
            this.btnLogReturn.Location = new System.Drawing.Point(15, 445);
            this.btnLogReturn.Name = "btnLogReturn";
            this.btnLogReturn.Size = new System.Drawing.Size(550, 30);
            this.btnLogReturn.Text = "Log Return";
            this.btnLogReturn.Click += new System.EventHandler(this.btnLogReturn_Click);
            // 
            // frmReturns
            // 
            this.ClientSize = new System.Drawing.Size(580, 490);
            this.Controls.Add(this.btnLogReturn);
            this.Controls.Add(this.lblTotalFines);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtRecordID);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblRecordID);
            this.Controls.Add(this.dgvBorrowRecords);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.txtSearchMembers);
            this.Controls.Add(this.lblMembersHeader);
            this.Name = "frmReturns";
            this.Text = "Sduduzo Mtalane - 22/09/2026";
            this.Load += new System.EventHandler(this.frmReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMembersHeader;
        private System.Windows.Forms.TextBox txtSearchMembers;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DataGridView dgvBorrowRecords;
        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblTotalFines;
        private System.Windows.Forms.Button btnLogReturn;
    }
}