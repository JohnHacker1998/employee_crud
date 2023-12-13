namespace EmployeeManagement
{
    partial class Form1
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
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.labelSubCity = new System.Windows.Forms.Label();
            this.txtSubCity = new System.Windows.Forms.TextBox();
            this.labelLocationSpecialName = new System.Windows.Forms.Label();
            this.txtLocationSpecialName = new System.Windows.Forms.TextBox();
            this.labelActiveInd = new System.Windows.Forms.Label();
            this.cmbActiveInd = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelOriginalEmployoeeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(59, 90);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 2;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Enabled = false;
            this.txtCountryCode.Location = new System.Drawing.Point(203, 83);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(44, 20);
            this.txtCountryCode.TabIndex = 3;
            this.txtCountryCode.Text = "+251";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(253, 82);
            this.txtPhoneNumber.MaxLength = 9;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(59, 124);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(41, 13);
            this.labelRegion.TabIndex = 5;
            this.labelRegion.Text = "Region";
            this.labelRegion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(203, 117);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(250, 20);
            this.txtRegion.TabIndex = 6;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(59, 154);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(203, 146);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 20);
            this.txtCity.TabIndex = 8;
            // 
            // labelSubCity
            // 
            this.labelSubCity.AutoSize = true;
            this.labelSubCity.Location = new System.Drawing.Point(59, 186);
            this.labelSubCity.Name = "labelSubCity";
            this.labelSubCity.Size = new System.Drawing.Size(46, 13);
            this.labelSubCity.TabIndex = 9;
            this.labelSubCity.Text = "Sub City";
            // 
            // txtSubCity
            // 
            this.txtSubCity.Location = new System.Drawing.Point(203, 179);
            this.txtSubCity.Name = "txtSubCity";
            this.txtSubCity.Size = new System.Drawing.Size(250, 20);
            this.txtSubCity.TabIndex = 10;
            // 
            // labelLocationSpecialName
            // 
            this.labelLocationSpecialName.AutoSize = true;
            this.labelLocationSpecialName.Location = new System.Drawing.Point(59, 223);
            this.labelLocationSpecialName.Name = "labelLocationSpecialName";
            this.labelLocationSpecialName.Size = new System.Drawing.Size(117, 13);
            this.labelLocationSpecialName.TabIndex = 11;
            this.labelLocationSpecialName.Text = "Location Special Name";
            // 
            // txtLocationSpecialName
            // 
            this.txtLocationSpecialName.Location = new System.Drawing.Point(203, 216);
            this.txtLocationSpecialName.Name = "txtLocationSpecialName";
            this.txtLocationSpecialName.Size = new System.Drawing.Size(250, 20);
            this.txtLocationSpecialName.TabIndex = 12;
            // 
            // labelActiveInd
            // 
            this.labelActiveInd.AutoSize = true;
            this.labelActiveInd.Location = new System.Drawing.Point(62, 256);
            this.labelActiveInd.Name = "labelActiveInd";
            this.labelActiveInd.Size = new System.Drawing.Size(55, 13);
            this.labelActiveInd.TabIndex = 13;
            this.labelActiveInd.Text = "Active Ind";
            // 
            // cmbActiveInd
            // 
            this.cmbActiveInd.FormattingEnabled = true;
            this.cmbActiveInd.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbActiveInd.Location = new System.Drawing.Point(203, 247);
            this.cmbActiveInd.Name = "cmbActiveInd";
            this.cmbActiveInd.Size = new System.Drawing.Size(250, 21);
            this.cmbActiveInd.TabIndex = 14;
            this.cmbActiveInd.Text = "TRUE";
            this.cmbActiveInd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(59, 24);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 16;
            this.lblEmployeeID.Text = "Employee ID";
            this.lblEmployeeID.Click += new System.EventHandler(this.lblEmployeeID_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(203, 24);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(250, 20);
            this.txtEmployeeID.TabIndex = 17;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(501, 56);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(618, 264);
            this.dgvEmployee.TabIndex = 18;
            this.dgvEmployee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(263, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(496, 22);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(87, 13);
            this.labelSearchName.TabIndex = 20;
            this.labelSearchName.Text = "Search By Name";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(629, 21);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(166, 20);
            this.txtSearchByName.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(823, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelOriginalEmployoeeID
            // 
            this.labelOriginalEmployoeeID.AutoSize = true;
            this.labelOriginalEmployoeeID.Location = new System.Drawing.Point(69, 357);
            this.labelOriginalEmployoeeID.Name = "labelOriginalEmployoeeID";
            this.labelOriginalEmployoeeID.Size = new System.Drawing.Size(31, 13);
            this.labelOriginalEmployoeeID.TabIndex = 23;
            this.labelOriginalEmployoeeID.Text = "none";
            this.labelOriginalEmployoeeID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 660);
            this.Controls.Add(this.labelOriginalEmployoeeID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbActiveInd);
            this.Controls.Add(this.labelActiveInd);
            this.Controls.Add(this.txtLocationSpecialName);
            this.Controls.Add(this.labelLocationSpecialName);
            this.Controls.Add(this.txtSubCity);
            this.Controls.Add(this.labelSubCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Employee CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labelSubCity;
        private System.Windows.Forms.TextBox txtSubCity;
        private System.Windows.Forms.Label labelLocationSpecialName;
        private System.Windows.Forms.TextBox txtLocationSpecialName;
        private System.Windows.Forms.Label labelActiveInd;
        private System.Windows.Forms.ComboBox cmbActiveInd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelOriginalEmployoeeID;
    }
}

