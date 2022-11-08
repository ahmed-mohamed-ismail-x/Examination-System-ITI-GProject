using System.Windows.Forms;

namespace Final_Project
{
    partial class MainLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogin));
            this.PBxMainLogin = new System.Windows.Forms.PictureBox();
            this.BtnStuLogin = new System.Windows.Forms.Button();
            this.BtnTxtUserName = new System.Windows.Forms.Button();
            this.BtnTxtPassword = new System.Windows.Forms.Button();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnClearUsername = new System.Windows.Forms.Button();
            this.BtnClearPassword = new System.Windows.Forms.Button();
            this.BtnSignup = new System.Windows.Forms.Button();
            this.PBxMainLoginITI = new System.Windows.Forms.PictureBox();
            this.PBxUserName = new System.Windows.Forms.PictureBox();
            this.PBxPassword = new System.Windows.Forms.PictureBox();
            this.BtnTitle = new System.Windows.Forms.Button();
            this.BtnUserNameBar = new System.Windows.Forms.Button();
            this.BtnPasswordBar = new System.Windows.Forms.Button();
            this.PBxStudent = new System.Windows.Forms.PictureBox();
            this.PBxInstructor = new System.Windows.Forms.PictureBox();
            this.LblITI = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnInsLogin = new System.Windows.Forms.Button();
            this.picboxhome = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLoginITI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxhome)).BeginInit();
            this.SuspendLayout();
            // 
            // PBxMainLogin
            // 
            this.PBxMainLogin.BackColor = System.Drawing.Color.Gold;
            this.PBxMainLogin.Image = global::Final_Project.Properties.Resources.MainFrmblue;
            this.PBxMainLogin.ImageLocation = "";
            this.PBxMainLogin.Location = new System.Drawing.Point(0, 0);
            this.PBxMainLogin.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxMainLogin.Name = "PBxMainLogin";
            this.PBxMainLogin.Size = new System.Drawing.Size(227, 510);
            this.PBxMainLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMainLogin.TabIndex = 1;
            this.PBxMainLogin.TabStop = false;
            // 
            // BtnStuLogin
            // 
            this.BtnStuLogin.BackColor = System.Drawing.Color.Black;
            this.BtnStuLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStuLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStuLogin.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStuLogin.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnStuLogin.Location = new System.Drawing.Point(310, 500);
            this.BtnStuLogin.Name = "BtnStuLogin";
            this.BtnStuLogin.Size = new System.Drawing.Size(130, 53);
            this.BtnStuLogin.TabIndex = 3;
            this.BtnStuLogin.Text = "Login as Student";
            this.BtnStuLogin.UseVisualStyleBackColor = false;
            this.BtnStuLogin.Click += new System.EventHandler(this.BtnStuLogin_Click);
            // 
            // BtnTxtUserName
            // 
            this.BtnTxtUserName.BackColor = System.Drawing.Color.Black;
            this.BtnTxtUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTxtUserName.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTxtUserName.ForeColor = System.Drawing.Color.Gold;
            this.BtnTxtUserName.Location = new System.Drawing.Point(236, 181);
            this.BtnTxtUserName.Name = "BtnTxtUserName";
            this.BtnTxtUserName.Size = new System.Drawing.Size(130, 38);
            this.BtnTxtUserName.TabIndex = 5;
            this.BtnTxtUserName.Text = "User Name:";
            this.BtnTxtUserName.UseVisualStyleBackColor = false;
            // 
            // BtnTxtPassword
            // 
            this.BtnTxtPassword.BackColor = System.Drawing.Color.Black;
            this.BtnTxtPassword.FlatAppearance.BorderSize = 0;
            this.BtnTxtPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTxtPassword.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTxtPassword.ForeColor = System.Drawing.Color.Gold;
            this.BtnTxtPassword.Location = new System.Drawing.Point(236, 294);
            this.BtnTxtPassword.Name = "BtnTxtPassword";
            this.BtnTxtPassword.Size = new System.Drawing.Size(130, 38);
            this.BtnTxtPassword.TabIndex = 6;
            this.BtnTxtPassword.Text = "Password:";
            this.BtnTxtPassword.UseVisualStyleBackColor = false;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUserName.Location = new System.Drawing.Point(423, 181);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(238, 33);
            this.TxtUserName.TabIndex = 7;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(423, 294);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(238, 33);
            this.TxtPassword.TabIndex = 8;
            // 
            // BtnClearUsername
            // 
            this.BtnClearUsername.BackColor = System.Drawing.Color.Firebrick;
            this.BtnClearUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClearUsername.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClearUsername.Location = new System.Drawing.Point(658, 181);
            this.BtnClearUsername.Name = "BtnClearUsername";
            this.BtnClearUsername.Size = new System.Drawing.Size(29, 33);
            this.BtnClearUsername.TabIndex = 10;
            this.BtnClearUsername.Text = "X";
            this.BtnClearUsername.UseVisualStyleBackColor = false;
            this.BtnClearUsername.Click += new System.EventHandler(this.BtnClearUsername_Click);
            // 
            // BtnClearPassword
            // 
            this.BtnClearPassword.BackColor = System.Drawing.Color.Firebrick;
            this.BtnClearPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClearPassword.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClearPassword.Location = new System.Drawing.Point(658, 294);
            this.BtnClearPassword.Name = "BtnClearPassword";
            this.BtnClearPassword.Size = new System.Drawing.Size(29, 33);
            this.BtnClearPassword.TabIndex = 11;
            this.BtnClearPassword.Text = "X";
            this.BtnClearPassword.UseVisualStyleBackColor = false;
            this.BtnClearPassword.Click += new System.EventHandler(this.BtnClearPassword_Click);
            // 
            // BtnSignup
            // 
            this.BtnSignup.BackColor = System.Drawing.Color.Black;
            this.BtnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSignup.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSignup.ForeColor = System.Drawing.Color.Gold;
            this.BtnSignup.Location = new System.Drawing.Point(57, 508);
            this.BtnSignup.Name = "BtnSignup";
            this.BtnSignup.Size = new System.Drawing.Size(111, 42);
            this.BtnSignup.TabIndex = 12;
            this.BtnSignup.Text = "SignUp";
            this.BtnSignup.UseVisualStyleBackColor = false;
            this.BtnSignup.Click += new System.EventHandler(this.BtnSignup_Click);
            // 
            // PBxMainLoginITI
            // 
            this.PBxMainLoginITI.BackColor = System.Drawing.Color.Gold;
            this.PBxMainLoginITI.Image = global::Final_Project.Properties.Resources.iti_logo;
            this.PBxMainLoginITI.ImageLocation = "";
            this.PBxMainLoginITI.Location = new System.Drawing.Point(12, -7);
            this.PBxMainLoginITI.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxMainLoginITI.Name = "PBxMainLoginITI";
            this.PBxMainLoginITI.Size = new System.Drawing.Size(98, 89);
            this.PBxMainLoginITI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMainLoginITI.TabIndex = 13;
            this.PBxMainLoginITI.TabStop = false;
            // 
            // PBxUserName
            // 
            this.PBxUserName.Image = global::Final_Project.Properties.Resources.username;
            this.PBxUserName.ImageLocation = "";
            this.PBxUserName.Location = new System.Drawing.Point(368, 179);
            this.PBxUserName.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxUserName.Name = "PBxUserName";
            this.PBxUserName.Size = new System.Drawing.Size(54, 33);
            this.PBxUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxUserName.TabIndex = 16;
            this.PBxUserName.TabStop = false;
            // 
            // PBxPassword
            // 
            this.PBxPassword.Image = global::Final_Project.Properties.Resources.password;
            this.PBxPassword.ImageLocation = "";
            this.PBxPassword.Location = new System.Drawing.Point(368, 293);
            this.PBxPassword.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxPassword.Name = "PBxPassword";
            this.PBxPassword.Size = new System.Drawing.Size(54, 33);
            this.PBxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxPassword.TabIndex = 17;
            this.PBxPassword.TabStop = false;
            // 
            // BtnTitle
            // 
            this.BtnTitle.BackColor = System.Drawing.Color.Black;
            this.BtnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTitle.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTitle.ForeColor = System.Drawing.Color.Gold;
            this.BtnTitle.Location = new System.Drawing.Point(63, 0);
            this.BtnTitle.Name = "BtnTitle";
            this.BtnTitle.Size = new System.Drawing.Size(354, 47);
            this.BtnTitle.TabIndex = 18;
            this.BtnTitle.Text = "Examination System";
            this.BtnTitle.UseVisualStyleBackColor = false;
            // 
            // BtnUserNameBar
            // 
            this.BtnUserNameBar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUserNameBar.Enabled = false;
            this.BtnUserNameBar.FlatAppearance.BorderSize = 0;
            this.BtnUserNameBar.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUserNameBar.Location = new System.Drawing.Point(376, 210);
            this.BtnUserNameBar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUserNameBar.Name = "BtnUserNameBar";
            this.BtnUserNameBar.Size = new System.Drawing.Size(284, 10);
            this.BtnUserNameBar.TabIndex = 19;
            this.BtnUserNameBar.UseVisualStyleBackColor = false;
            // 
            // BtnPasswordBar
            // 
            this.BtnPasswordBar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnPasswordBar.Enabled = false;
            this.BtnPasswordBar.FlatAppearance.BorderSize = 0;
            this.BtnPasswordBar.Location = new System.Drawing.Point(376, 323);
            this.BtnPasswordBar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPasswordBar.Name = "BtnPasswordBar";
            this.BtnPasswordBar.Size = new System.Drawing.Size(285, 10);
            this.BtnPasswordBar.TabIndex = 20;
            this.BtnPasswordBar.UseVisualStyleBackColor = false;
            // 
            // PBxStudent
            // 
            this.PBxStudent.Image = global::Final_Project.Properties.Resources.Student;
            this.PBxStudent.ImageLocation = "";
            this.PBxStudent.Location = new System.Drawing.Point(263, 500);
            this.PBxStudent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxStudent.Name = "PBxStudent";
            this.PBxStudent.Size = new System.Drawing.Size(48, 53);
            this.PBxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxStudent.TabIndex = 21;
            this.PBxStudent.TabStop = false;
            // 
            // PBxInstructor
            // 
            this.PBxInstructor.Image = global::Final_Project.Properties.Resources.instructor;
            this.PBxInstructor.ImageLocation = "";
            this.PBxInstructor.Location = new System.Drawing.Point(489, 500);
            this.PBxInstructor.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxInstructor.Name = "PBxInstructor";
            this.PBxInstructor.Size = new System.Drawing.Size(48, 53);
            this.PBxInstructor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxInstructor.TabIndex = 22;
            this.PBxInstructor.TabStop = false;
            // 
            // LblITI
            // 
            this.LblITI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblITI.AutoSize = true;
            this.LblITI.BackColor = System.Drawing.Color.Gold;
            this.LblITI.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblITI.Location = new System.Drawing.Point(86, 7);
            this.LblITI.MaximumSize = new System.Drawing.Size(120, 150);
            this.LblITI.Name = "LblITI";
            this.LblITI.Size = new System.Drawing.Size(111, 75);
            this.LblITI.TabIndex = 24;
            this.LblITI.Text = "Information Technology Institute";
            this.LblITI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnInsLogin);
            this.splitContainer1.Panel2.Controls.Add(this.picboxhome);
            this.splitContainer1.Panel2.Controls.Add(this.BtnTitle);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(699, 569);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 25;
            // 
            // BtnInsLogin
            // 
            this.BtnInsLogin.BackColor = System.Drawing.Color.Black;
            this.BtnInsLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInsLogin.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsLogin.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnInsLogin.Location = new System.Drawing.Point(305, 500);
            this.BtnInsLogin.Name = "BtnInsLogin";
            this.BtnInsLogin.Size = new System.Drawing.Size(130, 53);
            this.BtnInsLogin.TabIndex = 27;
            this.BtnInsLogin.Text = "Login as Instructor";
            this.BtnInsLogin.UseVisualStyleBackColor = false;
            this.BtnInsLogin.Click += new System.EventHandler(this.BtnInsLogin_Click);
            // 
            // picboxhome
            // 
            this.picboxhome.Image = global::Final_Project.Properties.Resources.Login;
            this.picboxhome.ImageLocation = "";
            this.picboxhome.Location = new System.Drawing.Point(8, 0);
            this.picboxhome.Name = "picboxhome";
            this.picboxhome.Size = new System.Drawing.Size(45, 46);
            this.picboxhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxhome.TabIndex = 22;
            this.picboxhome.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(226, -7);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 576);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 566);
            this.Controls.Add(this.BtnTxtPassword);
            this.Controls.Add(this.BtnTxtUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblITI);
            this.Controls.Add(this.PBxMainLoginITI);
            this.Controls.Add(this.PBxInstructor);
            this.Controls.Add(this.PBxStudent);
            this.Controls.Add(this.PBxPassword);
            this.Controls.Add(this.PBxUserName);
            this.Controls.Add(this.BtnSignup);
            this.Controls.Add(this.BtnClearPassword);
            this.Controls.Add(this.BtnClearUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.BtnStuLogin);
            this.Controls.Add(this.PBxMainLogin);
            this.Controls.Add(this.BtnPasswordBar);
            this.Controls.Add(this.BtnUserNameBar);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination System Login";
            this.Load += new System.EventHandler(this.MainLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLoginITI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxInstructor)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion
        private PictureBox PBxMainLogin;
        private Button BtnStuLogin;
        private Button BtnTxtUserName;
        private Button BtnTxtPassword;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private Button BtnClearUsername;
        private Button BtnClearPassword;
        private Button BtnSignup;
        private PictureBox PBxMainLoginITI;
        private PictureBox PBxUserName;
        private PictureBox PBxPassword;
        private Button BtnTitle;
        private Button BtnUserNameBar;
        private Button BtnPasswordBar;
        private PictureBox PBxStudent;
        private PictureBox PBxInstructor;
        private Label LblITI;
        private SplitContainer splitContainer1;
        private Button button1;
        private PictureBox picboxhome;
        private Button BtnInsLogin;
    }
}