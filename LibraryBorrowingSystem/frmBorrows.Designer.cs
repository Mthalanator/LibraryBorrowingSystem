namespace LibraryBorrowingSystem
{
    partial class frmBorrows
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
            this.lblBooksHeader = new System.Windows.Forms.Label();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblMembersHeader = new System.Windows.Forms.Label();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.btnManage = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnLogBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooksHeader
            // 
            this.lblBooksHeader.Location = new System.Drawing.Point(15, 12);
            this.lblBooksHeader.Name = "lblBooksHeader";
            this.lblBooksHeader.Size = new System.Drawing.Size(75, 20);
            this.lblBooksHeader.Text = "Books List";
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Location = new System.Drawing.Point(95, 9);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(470, 23);
            this.txtSearchBooks.TextChanged += new System.EventHandler(this.txtSearchBooks_TextChanged);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(15, 36);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(550, 140);
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // lblMembersHeader
            // 
            this.lblMembersHeader.Location = new System.Drawing.Point(15, 188);
            this.lblMembersHeader.Name = "lblMembersHeader";
            this.lblMembersHeader.Size = new System.Drawing.Size(85, 20);
            this.lblMembersHeader.Text = "Members List";
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.Location = new System.Drawing.Point(105, 185);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.Size = new System.Drawing.Size(360, 23);
            this.txtSearchMembers.TextChanged += new System.EventHandler(this.txtSearchMembers_TextChanged);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(475, 184);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(90, 25);
            this.btnManage.Text = "Manage";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(15, 213);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(550, 140);
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // lblBook
            // 
            this.lblBook.Location = new System.Drawing.Point(15, 363);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(50, 18);
            this.lblBook.Text = "Book";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(80, 363);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 18);
            this.lblTitle.Text = "Title";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Location = new System.Drawing.Point(270, 363);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(100, 18);
            this.lblBorrowDate.Text = "Borrow Date";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(15, 382);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(55, 23);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(80, 382);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(180, 23);
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(270, 382);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(295, 23);
            // 
            // lblMember
            // 
            this.lblMember.Location = new System.Drawing.Point(15, 415);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(50, 18);
            this.lblMember.Text = "Member";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(80, 415);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 18);
            this.lblName.Text = "Name";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(270, 415);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(100, 18);
            this.lblDueDate.Text = "Due Date";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(15, 434);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(55, 23);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(80, 434);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(180, 23);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(270, 434);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(295, 23);
            // 
            // btnLogBorrow
            // 
            this.btnLogBorrow.Location = new System.Drawing.Point(15, 475);
            this.btnLogBorrow.Name = "btnLogBorrow";
            this.btnLogBorrow.Size = new System.Drawing.Size(550, 30);
            this.btnLogBorrow.Text = "Log Borrow";
            this.btnLogBorrow.Click += new System.EventHandler(this.btnLogBorrow_Click);
            // 
            // frmBorrows
            // 
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.btnLogBorrow);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.txtSearchMembers);
            this.Controls.Add(this.lblMembersHeader);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.lblBooksHeader);
            this.Name = "frmBorrows";
            this.Text = "Library Borrowing System";
            this.Load += new System.EventHandler(this.frmBorrows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBooksHeader;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblMembersHeader;
        private System.Windows.Forms.TextBox txtSearchMembers;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnLogBorrow;
    }
}