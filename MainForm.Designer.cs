
namespace EFCoreExamApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAccountInfo = new System.Windows.Forms.GroupBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbxUserID = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lvAccountLst = new System.Windows.Forms.ListView();
            this.chUserID = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chPassword = new System.Windows.Forms.ColumnHeader();
            this.chPhone = new System.Windows.Forms.ColumnHeader();
            this.chRoleDesc = new System.Windows.Forms.ColumnHeader();
            this.chRegDTM = new System.Windows.Forms.ColumnHeader();
            this.gbxAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAccountInfo
            // 
            this.gbxAccountInfo.Controls.Add(this.cbxRole);
            this.gbxAccountInfo.Controls.Add(this.lbRole);
            this.gbxAccountInfo.Controls.Add(this.tbxPhone);
            this.gbxAccountInfo.Controls.Add(this.lbPhone);
            this.gbxAccountInfo.Controls.Add(this.tbxPassword);
            this.gbxAccountInfo.Controls.Add(this.lbPassword);
            this.gbxAccountInfo.Controls.Add(this.tbxUserName);
            this.gbxAccountInfo.Controls.Add(this.lbUserName);
            this.gbxAccountInfo.Controls.Add(this.tbxUserID);
            this.gbxAccountInfo.Controls.Add(this.lbUserID);
            this.gbxAccountInfo.Location = new System.Drawing.Point(34, 27);
            this.gbxAccountInfo.Name = "gbxAccountInfo";
            this.gbxAccountInfo.Size = new System.Drawing.Size(280, 211);
            this.gbxAccountInfo.TabIndex = 0;
            this.gbxAccountInfo.TabStop = false;
            this.gbxAccountInfo.Text = "Acount Information";
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "admin",
            "manager",
            "user",
            "guest"});
            this.cbxRole.Location = new System.Drawing.Point(104, 158);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(137, 23);
            this.cbxRole.TabIndex = 9;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(31, 162);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(30, 15);
            this.lbRole.TabIndex = 8;
            this.lbRole.Text = "Role";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(104, 129);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(137, 23);
            this.tbxPhone.TabIndex = 7;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(29, 132);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(44, 15);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "Mobile";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(104, 100);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(137, 23);
            this.tbxPassword.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(29, 103);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(104, 71);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(137, 23);
            this.tbxUserName.TabIndex = 3;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(29, 74);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(66, 15);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name";
            // 
            // tbxUserID
            // 
            this.tbxUserID.Location = new System.Drawing.Point(104, 42);
            this.tbxUserID.Name = "tbxUserID";
            this.tbxUserID.Size = new System.Drawing.Size(137, 23);
            this.tbxUserID.TabIndex = 1;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(29, 45);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(46, 15);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(34, 244);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(280, 35);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.OnSignUp_Click);
            // 
            // lvAccountLst
            // 
            this.lvAccountLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUserID,
            this.chName,
            this.chPassword,
            this.chPhone,
            this.chRoleDesc,
            this.chRegDTM});
            this.lvAccountLst.HideSelection = false;
            this.lvAccountLst.Location = new System.Drawing.Point(332, 34);
            this.lvAccountLst.Name = "lvAccountLst";
            this.lvAccountLst.Size = new System.Drawing.Size(552, 245);
            this.lvAccountLst.TabIndex = 11;
            this.lvAccountLst.UseCompatibleStateImageBehavior = false;
            this.lvAccountLst.View = System.Windows.Forms.View.Details;
            // 
            // chUserID
            // 
            this.chUserID.Text = "UserID";
            this.chUserID.Width = 90;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 80;
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            this.chPassword.Width = 80;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Phone";
            this.chPhone.Width = 100;
            // 
            // chRoleDesc
            // 
            this.chRoleDesc.Text = "Role";
            // 
            // chRegDTM
            // 
            this.chRegDTM.Text = "RegDate";
            this.chRegDTM.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 445);
            this.Controls.Add(this.lvAccountLst);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.gbxAccountInfo);
            this.Name = "MainForm";
            this.Text = ".NETCore EntityFramework Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxAccountInfo.ResumeLayout(false);
            this.gbxAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAccountInfo;
        private System.Windows.Forms.TextBox tbxUserID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ListView lvAccountLst;
        private System.Windows.Forms.ColumnHeader chUserID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chRoleDesc;
        private System.Windows.Forms.ColumnHeader chRegDTM;
    }
}

