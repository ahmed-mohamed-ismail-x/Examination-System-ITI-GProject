using System;
using System.Windows.Forms;


namespace Final_Project
{
    public partial class MainLogin : Form
    {
        public static char login = 'f';
        public MainLogin()
        {
            InitializeComponent();
            
        }


        private void BtnClearUsername_Click(object sender, EventArgs e)
        {
            TxtUserName.Text = "";
        }

        private void BtnClearPassword_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = "";
        }

        private void BtnStuLogin_Click(object sender, EventArgs e)
        {

            if (TxtUserName.Text == "1")
            {
                Student.Firstname = "Admin";
                Student.FullName = "Admin";
                Student.Id = "1";
                login = 's';
                Dispose();
            }
            else
            {
                try
                {
                    //username ---> student first name
                    //password ---> student id

                    if (Login.StudentLogin(TxtUserName.Text, int.Parse(TxtPassword.Text)) == 1)
                    {
                        login = 's';
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void MainLogin_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = "1";
            
        }


        private void BtnInsLogin_Click(object sender, EventArgs e)
        {

            if (TxtUserName.Text == "1")
            {
                Instructor.Name = "Admin";
                Instructor.Id = "1";
                login = 'i';
                Dispose();
            }
            else
            {



                try
                {

                    //username --->  instructor name
                    //password ---> instructor id

                    if (Login.InstructorLogin(TxtUserName.Text, int.Parse(TxtPassword.Text)) == 1)
                    {
                        login = 'i';
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {

            
            Add_new_student addstd = new Add_new_student();
            addstd.Show();
          
            
        }
    }
}