using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class InstructorHome : Form
    {

        public static string Reoprt1URL = "http://desktop-8m43878/ReportsC8/report/Report%20Project7/Report1";
        public static string Reoprt2URL = "http://desktop-8m43878/ReportsC8/report/Report%20Project7/Report2";
        public static string Reoprt3URL = "http://desktop-8m43878/ReportsC8/report/Report%20Project7/Report3";
        public static string Reoprt4URL = "http://desktop-8m43878/ReportsC8/report/Report%20Project7/Report4";
        public static string Reoprt5URL = "http://desktop-8m43878/ReportsC8/report/Report%20Project7/Report5";
        public static string Reoprt6URL = "http://desktop-8m43878/ReportsC8/report/Report%20Project7/Report6";




        public void Report (string url)
        {
            // 
            // webBrowser
            // 
            this.webBrowser.Dispose();
            this.webBrowser = new WebBrowser();
            this.webBrowser.Dock = DockStyle.Fill;
            this.webBrowser.Width = PnlReport.Width;
            this.webBrowser.Height = PnlReport.Height;
            this.webBrowser.Url = new Uri(url);
            this.webBrowser.ScrollBarsEnabled = true;
            this.webBrowser.Visible = true;
            this.webBrowser.ScriptErrorsSuppressed = true;
            PnlReport.Controls.Add(webBrowser);
            PBxMainLogin.Hide();
        }

        public InstructorHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInstructorname.Text = Instructor.Name;

        }

        private void BtnSignout_Click(object sender, EventArgs e)
        {
            Program.Signout = 1;
            this.Dispose();
        }

   
        private void BtnR1_Click(object sender, EventArgs e)
        {
            Report(Reoprt1URL);
        }

        private void BtnR2_Click(object sender, EventArgs e)
        {
            Report(Reoprt2URL);
        }

        private void BtnR3_Click(object sender, EventArgs e)
        {
            Report(Reoprt3URL);
        }

        private void BtnR4_Click(object sender, EventArgs e)
        {
            Report(Reoprt4URL);
        }

        private void BtnR5_Click(object sender, EventArgs e)
        {
            Report(Reoprt5URL);
        }

        private void BtnR6_Click(object sender, EventArgs e)
        {
            Report(Reoprt6URL);
        }

       }
}
