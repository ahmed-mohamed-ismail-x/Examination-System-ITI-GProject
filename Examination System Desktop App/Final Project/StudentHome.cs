using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace Final_Project
{
    public partial class StudentHome : Form
    {
        string connectionstring = @"Data Source=.;Initial Catalog=Project;Integrated Security=True";
        public StudentHome()
        {
            propfirstname = Student.Firstname;
            proplastname = Student.Lastname;
            props_id = Student.Id;
            propstudentName = Student.FullName;

            InitializeComponent();
            
        }
        public string propfirstname { set; get; } 
        public string proplastname { set; get; } 
        public string props_id { set; get; } 
        public string propstudentName { set; get; } 


        private void labelexambtn_Click(object sender, EventArgs e)
        {

            string Fname = propfirstname;
            string lname = proplastname;
            string fullname = propstudentName;
            string s_id = props_id;

            Exam f2 = new Exam(s_id, Fname, lname);
            f2.propFname = Fname;
            f2.propLname = lname;
            f2.props_id = s_id;
            f2.ShowDialog();
            
        }

        private void studentReport1_Load(object sender, EventArgs e)
        {
            lblstudentfullname.Text = Student.FullName;
            dgv_courses_results_of_student.Hide();
            // instead of deleting the resultbtn i will hide it with its image 
            lblresultbtn.Hide();
            pictureBox4.Hide();
        }


        private void BtnSignout_Click(object sender, EventArgs e)
        {
            Program.Signout = 1;
            this.Dispose();
            
        }

        private void lblcoursesbtn_Click(object sender, EventArgs e)
        {
            PBxMainLogin.Hide();
            dgv_courses_results_of_student.Show();
            
            // this comming 7 line are used to autosize the data grid view
            dgv_courses_results_of_student.DataBindingComplete += (s, e) =>
            {
                var dg = (DataGridView)s;
                var width = dg.Columns.GetColumnsWidth(DataGridViewElementStates.None);
                var height = dg.Rows.GetRowsHeight(DataGridViewElementStates.None);
                dg.ClientSize = new Size(width + 60, height + 5);
            };


            // this connection is used to come with student's course results for a certain student

            using (SqlConnection getstudentcoursesandresults = new SqlConnection(connectionstring))
            {
                // opening the connection
                getstudentcoursesandresults.Open();
                // defining the sql command
                SqlCommand getcrs_rslt_cmd = new SqlCommand("getcourse_results", getstudentcoursesandresults);
                // definig command type
                getcrs_rslt_cmd.CommandType = CommandType.StoredProcedure;
                // adding parameters of the stored procedure
                getcrs_rslt_cmd.Parameters.AddWithValue("@s_id", props_id);

                // definig an adapter to get the data
                SqlDataAdapter course_results_adap = new SqlDataAdapter();
                // defining the needed command to be stored in the adapter
                course_results_adap.SelectCommand = getcrs_rslt_cmd;
                // defining a table 
                DataTable crs_rslt_tab = new DataTable();
                // filling the adapter from table
                course_results_adap.Fill(crs_rslt_tab);
                // executing the query
                getcrs_rslt_cmd.ExecuteNonQuery();
                // defing the datasource for the dgv
                dgv_courses_results_of_student.DataSource = crs_rslt_tab;
                // closing connection
                getstudentcoursesandresults.Close();


            }


            }

        private void lblresultbtn_Click(object sender, EventArgs e)
        {
            PBxMainLogin.Hide();
            
        }

        private void dgv_courses_results_of_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
