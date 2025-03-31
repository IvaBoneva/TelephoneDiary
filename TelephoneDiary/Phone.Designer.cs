namespace TelephoneDiary
{
    partial class Phone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNew = new Button();
            txtBoxLName = new TextBox();
            txtBoxMobile = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxFName = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblFName = new Label();
            lblMobile = new Label();
            lblEmail = new Label();
            lblCategory = new Label();
            lblLName = new Label();
            comboBoxCategory = new ComboBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F);
            btnNew.Location = new Point(507, 47);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(151, 51);
            btnNew.TabIndex = 5;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtBoxLName
            // 
            txtBoxLName.Font = new Font("Segoe UI", 13.8F);
            txtBoxLName.Location = new Point(193, 93);
            txtBoxLName.Name = "txtBoxLName";
            txtBoxLName.Size = new Size(289, 38);
            txtBoxLName.TabIndex = 1;
            // 
            // txtBoxMobile
            // 
            txtBoxMobile.Font = new Font("Segoe UI", 13.8F);
            txtBoxMobile.Location = new Point(193, 140);
            txtBoxMobile.Name = "txtBoxMobile";
            txtBoxMobile.Size = new Size(289, 38);
            txtBoxMobile.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Font = new Font("Segoe UI", 13.8F);
            txtBoxEmail.Location = new Point(193, 187);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(289, 38);
            txtBoxEmail.TabIndex = 3;
            // 
            // txtBoxFName
            // 
            txtBoxFName.Font = new Font("Segoe UI", 13.8F);
            txtBoxFName.Location = new Point(193, 46);
            txtBoxFName.Name = "txtBoxFName";
            txtBoxFName.Size = new Size(289, 38);
            txtBoxFName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(767, 256);
            dataGridView1.TabIndex = 12;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mobile";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.FillWeight = 150F;
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Category";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 13.8F);
            lblFName.Location = new Point(58, 46);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(129, 31);
            lblFName.TabIndex = 7;
            lblFName.Text = "First Name:";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Font = new Font("Segoe UI", 13.8F);
            lblMobile.Location = new Point(94, 140);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(91, 31);
            lblMobile.TabIndex = 9;
            lblMobile.Text = "Mobile:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F);
            lblEmail.Location = new Point(110, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 31);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F);
            lblCategory.Location = new Point(74, 234);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 13.8F);
            lblLName.Location = new Point(60, 93);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(127, 31);
            lblLName.TabIndex = 8;
            lblLName.Text = "Last Name:";
            lblLName.Click += label5_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "HOME", "OFFICE", "BUSSINESS", "FRIENDS", "FAMILY" });
            comboBoxCategory.Location = new Point(193, 234);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(289, 39);
            comboBoxCategory.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 12F);
            btnInsert.Location = new Point(507, 104);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(151, 51);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(507, 218);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 51);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(507, 161);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 51);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Font = new Font("Segoe UI", 13.8F);
            txtBoxSearch.Location = new Point(507, 275);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(272, 38);
            txtBoxSearch.TabIndex = 16;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // Phone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 602);
            Controls.Add(txtBoxSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(comboBoxCategory);
            Controls.Add(lblLName);
            Controls.Add(lblCategory);
            Controls.Add(lblEmail);
            Controls.Add(lblMobile);
            Controls.Add(lblFName);
            Controls.Add(dataGridView1);
            Controls.Add(txtBoxFName);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxMobile);
            Controls.Add(txtBoxLName);
            Controls.Add(btnNew);
            Name = "Phone";
            Text = "Phone";
            Load += Phone_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private TextBox txtBoxLName;
        private TextBox txtBoxMobile;
        private TextBox txtBoxEmail;
        private TextBox txtBoxFName;
        private DataGridView dataGridView1;
        private Label lblFName;
        private Label lblMobile;
        private Label lblEmail;
        private Label lblCategory;
        private Label lblLName;
        private ComboBox comboBoxCategory;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtBoxSearch;
    }
}