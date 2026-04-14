namespace ExpenseTrackerApp
{
    partial class Form1
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
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(30, 20);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(103, 16);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "Expense Name:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 60);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 16);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 140);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(150, 17);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(150, 22);
            this.txtExpenseName.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(150, 57);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(150, 97);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 24);
            this.cmbCategory.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(150, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(300, 180);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 25);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(30, 220);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowHeadersWidth = 51;
            this.dgvExpenses.RowTemplate.Height = 24;
            this.dgvExpenses.Size = new System.Drawing.Size(500, 200);
            this.dgvExpenses.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblExpenseName);
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dgvExpenses;
    }
}
