
namespace AddressBook
{
    partial class AddressBookForm
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
            this.AddressBookLabel = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.homeAddressLabel = new System.Windows.Forms.Label();
            this.homeAddressTxtBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addressGridView = new System.Windows.Forms.DataGridView();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addressGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressBookLabel
            // 
            this.AddressBookLabel.AutoSize = true;
            this.AddressBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBookLabel.Location = new System.Drawing.Point(21, 22);
            this.AddressBookLabel.Name = "AddressBookLabel";
            this.AddressBookLabel.Size = new System.Drawing.Size(291, 51);
            this.AddressBookLabel.TabIndex = 0;
            this.AddressBookLabel.Text = "Address Book";
            this.AddressBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(228, 126);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(289, 31);
            this.firstNameTxtBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(53, 193);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(589, 116);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 25);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City";
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.Location = new System.Drawing.Point(697, 110);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(252, 31);
            this.cityTxtBox.TabIndex = 8;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(228, 187);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(289, 31);
            this.lastNameTxtBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(53, 126);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // homeAddressLabel
            // 
            this.homeAddressLabel.AutoSize = true;
            this.homeAddressLabel.Location = new System.Drawing.Point(53, 257);
            this.homeAddressLabel.Name = "homeAddressLabel";
            this.homeAddressLabel.Size = new System.Drawing.Size(153, 25);
            this.homeAddressLabel.TabIndex = 5;
            this.homeAddressLabel.Text = "Home Address";
            // 
            // homeAddressTxtBox
            // 
            this.homeAddressTxtBox.Location = new System.Drawing.Point(228, 257);
            this.homeAddressTxtBox.Name = "homeAddressTxtBox";
            this.homeAddressTxtBox.Size = new System.Drawing.Size(721, 31);
            this.homeAddressTxtBox.TabIndex = 6;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(574, 205);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(93, 25);
            this.zipCodeLabel.TabIndex = 11;
            this.zipCodeLabel.Text = "ZipCode";
            // 
            // zipCodeTxtBox
            // 
            this.zipCodeTxtBox.Location = new System.Drawing.Point(697, 202);
            this.zipCodeTxtBox.Name = "zipCodeTxtBox";
            this.zipCodeTxtBox.Size = new System.Drawing.Size(252, 31);
            this.zipCodeTxtBox.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1053, 94);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(152, 62);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(1053, 171);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(152, 62);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1053, 250);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(152, 62);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addressGridView
            // 
            this.addressGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.addressGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameCol,
            this.LastNameCol,
            this.AddressCol,
            this.CityCol,
            this.StateCol,
            this.ZipCodeCol});
            this.addressGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addressGridView.Location = new System.Drawing.Point(21, 337);
            this.addressGridView.Name = "addressGridView";
            this.addressGridView.RowHeadersWidth = 82;
            this.addressGridView.RowTemplate.Height = 33;
            this.addressGridView.Size = new System.Drawing.Size(1184, 535);
            this.addressGridView.TabIndex = 16;
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.HeaderText = "First Name";
            this.FirstNameCol.MinimumWidth = 10;
            this.FirstNameCol.Name = "FirstNameCol";
            this.FirstNameCol.Width = 80;
            // 
            // LastNameCol
            // 
            this.LastNameCol.HeaderText = "Last Name";
            this.LastNameCol.MinimumWidth = 10;
            this.LastNameCol.Name = "LastNameCol";
            this.LastNameCol.Width = 80;
            // 
            // AddressCol
            // 
            this.AddressCol.HeaderText = "Address";
            this.AddressCol.MinimumWidth = 10;
            this.AddressCol.Name = "AddressCol";
            this.AddressCol.Width = 150;
            // 
            // CityCol
            // 
            this.CityCol.HeaderText = "City";
            this.CityCol.MinimumWidth = 10;
            this.CityCol.Name = "CityCol";
            this.CityCol.Width = 90;
            // 
            // StateCol
            // 
            this.StateCol.HeaderText = "State";
            this.StateCol.MinimumWidth = 10;
            this.StateCol.Name = "StateCol";
            this.StateCol.Width = 60;
            // 
            // ZipCodeCol
            // 
            this.ZipCodeCol.HeaderText = "Zip Code";
            this.ZipCodeCol.MinimumWidth = 10;
            this.ZipCodeCol.Name = "ZipCodeCol";
            this.ZipCodeCol.Width = 60;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(589, 162);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(62, 25);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "State";
            // 
            // stateTxtBox
            // 
            this.stateTxtBox.Location = new System.Drawing.Point(697, 156);
            this.stateTxtBox.Name = "stateTxtBox";
            this.stateTxtBox.Size = new System.Drawing.Size(252, 31);
            this.stateTxtBox.TabIndex = 10;
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 903);
            this.Controls.Add(this.stateTxtBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.addressGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.zipCodeTxtBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.homeAddressTxtBox);
            this.Controls.Add(this.homeAddressLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.cityTxtBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.AddressBookLabel);
            this.Name = "AddressBookForm";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.AddressBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddressBookLabel;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label homeAddressLabel;
        private System.Windows.Forms.TextBox homeAddressTxtBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCodeCol;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTxtBox;
    }
}

