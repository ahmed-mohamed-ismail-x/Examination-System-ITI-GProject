
namespace Final_Project
{
    partial class Exam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.dgv_all_answers = new System.Windows.Forms.DataGridView();
            this.splt1 = new System.Windows.Forms.Splitter();
            this.cmbbx1 = new System.Windows.Forms.ComboBox();
            this.lblselectcourse = new System.Windows.Forms.Label();
            this.lblcurrentexam = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.lblcourseid = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblnumberofchoosen = new System.Windows.Forms.Label();
            this.lblqstnumber = new System.Windows.Forms.Label();
            this.lblstudfullname = new System.Windows.Forms.Label();
            this.rbchoice1 = new System.Windows.Forms.RadioButton();
            this.rbchoice2 = new System.Windows.Forms.RadioButton();
            this.rbchoice3 = new System.Windows.Forms.RadioButton();
            this.rbchoice4 = new System.Windows.Forms.RadioButton();
            this.lblchoosendummy = new System.Windows.Forms.Label();
            this.dgvmodelans = new System.Windows.Forms.DataGridView();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.LblITI = new System.Windows.Forms.Label();
            this.PBxMainLoginITI = new System.Windows.Forms.PictureBox();
            this.PBxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnEndExam = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblline = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblChosenAns = new System.Windows.Forms.Label();
            this.LblCrsId = new System.Windows.Forms.Label();
            this.LblTotalQs = new System.Windows.Forms.Label();
            this.PBxStart = new System.Windows.Forms.PictureBox();
            this.PBxSubmit = new System.Windows.Forms.PictureBox();
            this.PBxNext = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PBxMainLogin = new System.Windows.Forms.PictureBox();
            this.BtnStuAnsDGV = new System.Windows.Forms.Button();
            this.BtnModelAnsDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodelans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLoginITI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_all_answers
            // 
            this.dgv_all_answers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_all_answers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_answers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_all_answers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_all_answers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "No Answer Choosen";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_answers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_all_answers.ColumnHeadersVisible = false;
            this.dgv_all_answers.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgv_all_answers.Location = new System.Drawing.Point(391, 125);
            this.dgv_all_answers.Name = "dgv_all_answers";
            this.dgv_all_answers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_all_answers.RowHeadersVisible = false;
            this.dgv_all_answers.RowHeadersWidth = 4;
            this.dgv_all_answers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_all_answers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_all_answers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgv_all_answers.RowTemplate.DefaultCellStyle.NullValue = "No Answer Choosen";
            this.dgv_all_answers.RowTemplate.Height = 25;
            this.dgv_all_answers.ShowCellErrors = false;
            this.dgv_all_answers.ShowCellToolTips = false;
            this.dgv_all_answers.ShowEditingIcon = false;
            this.dgv_all_answers.ShowRowErrors = false;
            this.dgv_all_answers.Size = new System.Drawing.Size(442, 267);
            this.dgv_all_answers.TabIndex = 30;
            // 
            // splt1
            // 
            this.splt1.BackColor = System.Drawing.Color.Gold;
            this.splt1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splt1.Location = new System.Drawing.Point(0, 0);
            this.splt1.Name = "splt1";
            this.splt1.Size = new System.Drawing.Size(281, 696);
            this.splt1.TabIndex = 0;
            this.splt1.TabStop = false;
            // 
            // cmbbx1
            // 
            this.cmbbx1.BackColor = System.Drawing.Color.White;
            this.cmbbx1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbbx1.FormattingEnabled = true;
            this.cmbbx1.Location = new System.Drawing.Point(85, 249);
            this.cmbbx1.Name = "cmbbx1";
            this.cmbbx1.Size = new System.Drawing.Size(168, 29);
            this.cmbbx1.TabIndex = 1;
            this.cmbbx1.SelectedValueChanged += new System.EventHandler(this.cmbbx1_SelectedValueChanged);
            // 
            // lblselectcourse
            // 
            this.lblselectcourse.AutoSize = true;
            this.lblselectcourse.BackColor = System.Drawing.Color.Gold;
            this.lblselectcourse.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblselectcourse.Location = new System.Drawing.Point(91, 221);
            this.lblselectcourse.Name = "lblselectcourse";
            this.lblselectcourse.Size = new System.Drawing.Size(155, 25);
            this.lblselectcourse.TabIndex = 2;
            this.lblselectcourse.Text = "Select Course";
            // 
            // lblcurrentexam
            // 
            this.lblcurrentexam.AutoSize = true;
            this.lblcurrentexam.BackColor = System.Drawing.Color.Black;
            this.lblcurrentexam.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcurrentexam.ForeColor = System.Drawing.Color.Gold;
            this.lblcurrentexam.Location = new System.Drawing.Point(472, 6);
            this.lblcurrentexam.MaximumSize = new System.Drawing.Size(0, 50);
            this.lblcurrentexam.Name = "lblcurrentexam";
            this.lblcurrentexam.Size = new System.Drawing.Size(309, 50);
            this.lblcurrentexam.TabIndex = 3;
            this.lblcurrentexam.Text = "Select Course Exam";
            this.lblcurrentexam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblquestion.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblquestion.ForeColor = System.Drawing.Color.Gold;
            this.lblquestion.Location = new System.Drawing.Point(337, 112);
            this.lblquestion.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(132, 28);
            this.lblquestion.TabIndex = 4;
            this.lblquestion.Text = "Question :";
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.BackColor = System.Drawing.Color.Gold;
            this.lblcourseid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcourseid.Location = new System.Drawing.Point(198, 244);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(45, 25);
            this.lblcourseid.TabIndex = 5;
            this.lblcourseid.Text = "000";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Black;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstart.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnstart.ForeColor = System.Drawing.Color.Gold;
            this.btnstart.Location = new System.Drawing.Point(622, 620);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(131, 45);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Start Exam";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Black;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnext.ForeColor = System.Drawing.Color.Gold;
            this.btnnext.Location = new System.Drawing.Point(432, 620);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(90, 45);
            this.btnnext.TabIndex = 9;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Black;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsubmit.ForeColor = System.Drawing.Color.Gold;
            this.btnsubmit.Location = new System.Drawing.Point(760, 620);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(142, 45);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "Submit Exam";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblnumberofchoosen
            // 
            this.lblnumberofchoosen.AutoSize = true;
            this.lblnumberofchoosen.BackColor = System.Drawing.Color.Gold;
            this.lblnumberofchoosen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnumberofchoosen.Location = new System.Drawing.Point(203, 305);
            this.lblnumberofchoosen.Name = "lblnumberofchoosen";
            this.lblnumberofchoosen.Size = new System.Drawing.Size(36, 28);
            this.lblnumberofchoosen.TabIndex = 21;
            this.lblnumberofchoosen.Text = "10";
            // 
            // lblqstnumber
            // 
            this.lblqstnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblqstnumber.BackColor = System.Drawing.Color.Gold;
            this.lblqstnumber.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblqstnumber.Location = new System.Drawing.Point(291, 112);
            this.lblqstnumber.Name = "lblqstnumber";
            this.lblqstnumber.Size = new System.Drawing.Size(46, 35);
            this.lblqstnumber.TabIndex = 22;
            this.lblqstnumber.Text = "1";
            this.lblqstnumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblstudfullname
            // 
            this.lblstudfullname.AutoSize = true;
            this.lblstudfullname.BackColor = System.Drawing.Color.Gold;
            this.lblstudfullname.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstudfullname.Location = new System.Drawing.Point(72, 131);
            this.lblstudfullname.Name = "lblstudfullname";
            this.lblstudfullname.Size = new System.Drawing.Size(156, 27);
            this.lblstudfullname.TabIndex = 23;
            this.lblstudfullname.Text = "Student Name";
            // 
            // rbchoice1
            // 
            this.rbchoice1.AutoSize = true;
            this.rbchoice1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbchoice1.Location = new System.Drawing.Point(353, 273);
            this.rbchoice1.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbchoice1.Name = "rbchoice1";
            this.rbchoice1.Size = new System.Drawing.Size(107, 29);
            this.rbchoice1.TabIndex = 24;
            this.rbchoice1.TabStop = true;
            this.rbchoice1.Text = "Choice1";
            this.rbchoice1.UseVisualStyleBackColor = true;
            this.rbchoice1.CheckedChanged += new System.EventHandler(this.rbchoice1_CheckedChanged);
            // 
            // rbchoice2
            // 
            this.rbchoice2.AutoSize = true;
            this.rbchoice2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbchoice2.Location = new System.Drawing.Point(353, 342);
            this.rbchoice2.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbchoice2.Name = "rbchoice2";
            this.rbchoice2.Size = new System.Drawing.Size(107, 29);
            this.rbchoice2.TabIndex = 25;
            this.rbchoice2.TabStop = true;
            this.rbchoice2.Text = "Choice2";
            this.rbchoice2.UseVisualStyleBackColor = true;
            this.rbchoice2.CheckedChanged += new System.EventHandler(this.rbchoice2_CheckedChanged);
            // 
            // rbchoice3
            // 
            this.rbchoice3.AutoSize = true;
            this.rbchoice3.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbchoice3.Location = new System.Drawing.Point(353, 409);
            this.rbchoice3.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbchoice3.Name = "rbchoice3";
            this.rbchoice3.Size = new System.Drawing.Size(107, 29);
            this.rbchoice3.TabIndex = 26;
            this.rbchoice3.TabStop = true;
            this.rbchoice3.Text = "Choice3";
            this.rbchoice3.UseVisualStyleBackColor = true;
            this.rbchoice3.CheckedChanged += new System.EventHandler(this.rbchoice3_CheckedChanged);
            // 
            // rbchoice4
            // 
            this.rbchoice4.AutoSize = true;
            this.rbchoice4.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbchoice4.Location = new System.Drawing.Point(353, 485);
            this.rbchoice4.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbchoice4.Name = "rbchoice4";
            this.rbchoice4.Size = new System.Drawing.Size(107, 29);
            this.rbchoice4.TabIndex = 27;
            this.rbchoice4.TabStop = true;
            this.rbchoice4.Text = "Choice4";
            this.rbchoice4.UseVisualStyleBackColor = true;
            this.rbchoice4.CheckedChanged += new System.EventHandler(this.rbchoice4_CheckedChanged);
            // 
            // lblchoosendummy
            // 
            this.lblchoosendummy.AutoSize = true;
            this.lblchoosendummy.BackColor = System.Drawing.Color.Gold;
            this.lblchoosendummy.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblchoosendummy.Location = new System.Drawing.Point(25, 394);
            this.lblchoosendummy.MaximumSize = new System.Drawing.Size(190, 0);
            this.lblchoosendummy.Name = "lblchoosendummy";
            this.lblchoosendummy.Size = new System.Drawing.Size(78, 25);
            this.lblchoosendummy.TabIndex = 28;
            this.lblchoosendummy.Text = "Answer";
            // 
            // dgvmodelans
            // 
            this.dgvmodelans.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvmodelans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmodelans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvmodelans.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvmodelans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmodelans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmodelans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmodelans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmodelans.ColumnHeadersVisible = false;
            this.dgvmodelans.EnableHeadersVisualStyles = false;
            this.dgvmodelans.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvmodelans.Location = new System.Drawing.Point(391, 414);
            this.dgvmodelans.Name = "dgvmodelans";
            this.dgvmodelans.RowHeadersVisible = false;
            this.dgvmodelans.RowHeadersWidth = 4;
            this.dgvmodelans.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvmodelans.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvmodelans.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvmodelans.RowTemplate.DefaultCellStyle.NullValue = "No Answer Choosen";
            this.dgvmodelans.RowTemplate.Height = 25;
            this.dgvmodelans.ShowCellErrors = false;
            this.dgvmodelans.ShowCellToolTips = false;
            this.dgvmodelans.ShowEditingIcon = false;
            this.dgvmodelans.ShowRowErrors = false;
            this.dgvmodelans.Size = new System.Drawing.Size(442, 282);
            this.dgvmodelans.TabIndex = 31;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Gold;
            this.lbldate.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldate.Location = new System.Drawing.Point(80, 576);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(100, 25);
            this.lbldate.TabIndex = 32;
            this.lbldate.Text = "date now";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.BackColor = System.Drawing.Color.Gold;
            this.lblstudentid.Font = new System.Drawing.Font("Cascadia Code", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstudentid.Location = new System.Drawing.Point(124, 162);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(110, 22);
            this.lblstudentid.TabIndex = 33;
            this.lblstudentid.Text = "student_id";
            // 
            // LblITI
            // 
            this.LblITI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblITI.AutoSize = true;
            this.LblITI.BackColor = System.Drawing.Color.Gold;
            this.LblITI.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblITI.Location = new System.Drawing.Point(110, 16);
            this.LblITI.MaximumSize = new System.Drawing.Size(120, 150);
            this.LblITI.Name = "LblITI";
            this.LblITI.Size = new System.Drawing.Size(111, 75);
            this.LblITI.TabIndex = 46;
            this.LblITI.Text = "Information Technology Institute";
            this.LblITI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBxMainLoginITI
            // 
            this.PBxMainLoginITI.BackColor = System.Drawing.Color.Gold;
            this.PBxMainLoginITI.Image = global::Final_Project.Properties.Resources.iti_logo;
            this.PBxMainLoginITI.ImageLocation = "";
            this.PBxMainLoginITI.Location = new System.Drawing.Point(39, -1);
            this.PBxMainLoginITI.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxMainLoginITI.Name = "PBxMainLoginITI";
            this.PBxMainLoginITI.Size = new System.Drawing.Size(95, 89);
            this.PBxMainLoginITI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMainLoginITI.TabIndex = 45;
            this.PBxMainLoginITI.TabStop = false;
            // 
            // PBxStudent
            // 
            this.PBxStudent.BackColor = System.Drawing.Color.Gold;
            this.PBxStudent.Image = global::Final_Project.Properties.Resources.Student;
            this.PBxStudent.ImageLocation = "";
            this.PBxStudent.Location = new System.Drawing.Point(23, 114);
            this.PBxStudent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxStudent.Name = "PBxStudent";
            this.PBxStudent.Size = new System.Drawing.Size(48, 89);
            this.PBxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxStudent.TabIndex = 47;
            this.PBxStudent.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gold;
            this.pictureBox6.Image = global::Final_Project.Properties.Resources.signout;
            this.pictureBox6.ImageLocation = "";
            this.pictureBox6.Location = new System.Drawing.Point(42, 619);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 67;
            this.pictureBox6.TabStop = false;
            // 
            // BtnEndExam
            // 
            this.BtnEndExam.BackColor = System.Drawing.Color.Black;
            this.BtnEndExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEndExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEndExam.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEndExam.ForeColor = System.Drawing.Color.Gold;
            this.BtnEndExam.Location = new System.Drawing.Point(99, 619);
            this.BtnEndExam.Name = "BtnEndExam";
            this.BtnEndExam.Size = new System.Drawing.Size(111, 45);
            this.BtnEndExam.TabIndex = 66;
            this.BtnEndExam.Text = "End Exam";
            this.BtnEndExam.UseVisualStyleBackColor = false;
            this.BtnEndExam.Click += new System.EventHandler(this.BtnEndExam_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // lblline
            // 
            this.lblline.BackColor = System.Drawing.Color.Black;
            this.lblline.Location = new System.Drawing.Point(30, 187);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(220, 1);
            this.lblline.TabIndex = 69;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Gold;
            this.LblID.Font = new System.Drawing.Font("Cascadia Code", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblID.Location = new System.Drawing.Point(77, 162);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(40, 22);
            this.LblID.TabIndex = 70;
            this.LblID.Text = "ID:";
            // 
            // LblChosenAns
            // 
            this.LblChosenAns.AutoSize = true;
            this.LblChosenAns.BackColor = System.Drawing.Color.Gold;
            this.LblChosenAns.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblChosenAns.Location = new System.Drawing.Point(22, 354);
            this.LblChosenAns.Name = "LblChosenAns";
            this.LblChosenAns.Size = new System.Drawing.Size(177, 25);
            this.LblChosenAns.TabIndex = 72;
            this.LblChosenAns.Text = "Current Answer:";
            // 
            // LblCrsId
            // 
            this.LblCrsId.AutoSize = true;
            this.LblCrsId.BackColor = System.Drawing.Color.Gold;
            this.LblCrsId.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCrsId.Location = new System.Drawing.Point(81, 243);
            this.LblCrsId.Name = "LblCrsId";
            this.LblCrsId.Size = new System.Drawing.Size(122, 25);
            this.LblCrsId.TabIndex = 73;
            this.LblCrsId.Text = "Course ID:";
            // 
            // LblTotalQs
            // 
            this.LblTotalQs.AutoSize = true;
            this.LblTotalQs.BackColor = System.Drawing.Color.Gold;
            this.LblTotalQs.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalQs.Location = new System.Drawing.Point(22, 306);
            this.LblTotalQs.Name = "LblTotalQs";
            this.LblTotalQs.Size = new System.Drawing.Size(188, 25);
            this.LblTotalQs.TabIndex = 74;
            this.LblTotalQs.Text = "Total Questions:";
            // 
            // PBxStart
            // 
            this.PBxStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PBxStart.Image = global::Final_Project.Properties.Resources.startexam;
            this.PBxStart.ImageLocation = "";
            this.PBxStart.Location = new System.Drawing.Point(571, 623);
            this.PBxStart.Name = "PBxStart";
            this.PBxStart.Size = new System.Drawing.Size(49, 42);
            this.PBxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBxStart.TabIndex = 75;
            this.PBxStart.TabStop = false;
            // 
            // PBxSubmit
            // 
            this.PBxSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PBxSubmit.Image = global::Final_Project.Properties.Resources.finishexam;
            this.PBxSubmit.ImageLocation = "";
            this.PBxSubmit.Location = new System.Drawing.Point(906, 619);
            this.PBxSubmit.Name = "PBxSubmit";
            this.PBxSubmit.Size = new System.Drawing.Size(49, 45);
            this.PBxSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBxSubmit.TabIndex = 76;
            this.PBxSubmit.TabStop = false;
            // 
            // PBxNext
            // 
            this.PBxNext.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PBxNext.Image = global::Final_Project.Properties.Resources.next;
            this.PBxNext.ImageLocation = "";
            this.PBxNext.Location = new System.Drawing.Point(523, 620);
            this.PBxNext.Name = "PBxNext";
            this.PBxNext.Size = new System.Drawing.Size(46, 45);
            this.PBxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBxNext.TabIndex = 77;
            this.PBxNext.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(410, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // PBxMainLogin
            // 
            this.PBxMainLogin.Image = global::Final_Project.Properties.Resources.MainFrmblue;
            this.PBxMainLogin.ImageLocation = "";
            this.PBxMainLogin.Location = new System.Drawing.Point(287, 77);
            this.PBxMainLogin.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PBxMainLogin.Name = "PBxMainLogin";
            this.PBxMainLogin.Size = new System.Drawing.Size(668, 537);
            this.PBxMainLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMainLogin.TabIndex = 79;
            this.PBxMainLogin.TabStop = false;
            // 
            // BtnStuAnsDGV
            // 
            this.BtnStuAnsDGV.BackColor = System.Drawing.Color.Black;
            this.BtnStuAnsDGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnStuAnsDGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStuAnsDGV.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStuAnsDGV.ForeColor = System.Drawing.Color.Gold;
            this.BtnStuAnsDGV.Location = new System.Drawing.Point(391, 85);
            this.BtnStuAnsDGV.Name = "BtnStuAnsDGV";
            this.BtnStuAnsDGV.Size = new System.Drawing.Size(442, 40);
            this.BtnStuAnsDGV.TabIndex = 80;
            this.BtnStuAnsDGV.Text = "Your Answers";
            this.BtnStuAnsDGV.UseVisualStyleBackColor = false;
            // 
            // BtnModelAnsDGV
            // 
            this.BtnModelAnsDGV.BackColor = System.Drawing.Color.Black;
            this.BtnModelAnsDGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnModelAnsDGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModelAnsDGV.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModelAnsDGV.ForeColor = System.Drawing.Color.Gold;
            this.BtnModelAnsDGV.Location = new System.Drawing.Point(391, 374);
            this.BtnModelAnsDGV.Name = "BtnModelAnsDGV";
            this.BtnModelAnsDGV.Size = new System.Drawing.Size(442, 40);
            this.BtnModelAnsDGV.TabIndex = 81;
            this.BtnModelAnsDGV.Text = "Model Answers";
            this.BtnModelAnsDGV.UseVisualStyleBackColor = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 696);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PBxNext);
            this.Controls.Add(this.PBxSubmit);
            this.Controls.Add(this.PBxStart);
            this.Controls.Add(this.LblTotalQs);
            this.Controls.Add(this.LblChosenAns);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.lblline);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.BtnEndExam);
            this.Controls.Add(this.PBxStudent);
            this.Controls.Add(this.LblITI);
            this.Controls.Add(this.PBxMainLoginITI);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblchoosendummy);
            this.Controls.Add(this.lblstudfullname);
            this.Controls.Add(this.lblnumberofchoosen);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblcurrentexam);
            this.Controls.Add(this.lblselectcourse);
            this.Controls.Add(this.cmbbx1);
            this.Controls.Add(this.LblCrsId);
            this.Controls.Add(this.lblcourseid);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblqstnumber);
            this.Controls.Add(this.rbchoice4);
            this.Controls.Add(this.rbchoice3);
            this.Controls.Add(this.rbchoice2);
            this.Controls.Add(this.rbchoice1);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.BtnModelAnsDGV);
            this.Controls.Add(this.BtnStuAnsDGV);
            this.Controls.Add(this.dgvmodelans);
            this.Controls.Add(this.dgv_all_answers);
            this.Controls.Add(this.splt1);
            this.Controls.Add(this.PBxMainLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodelans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLoginITI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMainLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splt1;
        private System.Windows.Forms.ComboBox cmbbx1;
        private System.Windows.Forms.Label lblselectcourse;
        private System.Windows.Forms.Label lblcurrentexam;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Label lblcourseid;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblnumberofchoosen;
        private System.Windows.Forms.Label lblqstnumber;
        private System.Windows.Forms.Label lblstudfullname;
        private System.Windows.Forms.RadioButton rbchoice1;
        private System.Windows.Forms.RadioButton rbchoice2;
        private System.Windows.Forms.RadioButton rbchoice3;
        private System.Windows.Forms.RadioButton rbchoice4;
        private System.Windows.Forms.Label lblchoosendummy;
        private System.Windows.Forms.DataGridView dgv_all_answers;
        private System.Windows.Forms.DataGridView dgvmodelans;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label LblITI;
        private System.Windows.Forms.PictureBox PBxMainLoginITI;
        private System.Windows.Forms.PictureBox PBxStudent;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BtnEndExam;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblChosenAns;
        private System.Windows.Forms.Label LblCrsId;
        private System.Windows.Forms.Label LblTotalQs;
        private System.Windows.Forms.PictureBox PBxStart;
        private System.Windows.Forms.PictureBox PBxSubmit;
        private System.Windows.Forms.PictureBox PBxNext;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PBxMainLogin;
        private System.Windows.Forms.Button BtnStuAnsDGV;
        private System.Windows.Forms.Button BtnModelAnsDGV;
    }
}