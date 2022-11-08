using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Final_Project
{
    public partial class Add_new_student : Form
    {
        public Add_new_student()
        {
            InitializeComponent();
        }

        private void Add_new_student_Load(object sender, EventArgs e)
        {
            // defining connection to get course list
            SqlConnection getdepartmets = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            getdepartmets.Open();
            SqlCommand getdep_cmd = new SqlCommand("SELECT D_Name FROM Department", getdepartmets);
            SqlDataAdapter dep_adap = new SqlDataAdapter();
            dep_adap.SelectCommand = getdep_cmd;
            DataTable dep_table = new DataTable();
            dep_adap.Fill(dep_table);

            DataRow itemrow = dep_table.NewRow();
            itemrow[0] = "Select Department";
            dep_table.Rows.InsertAt(itemrow, 0);

            cmbxdepartment.DataSource = dep_table;
            cmbxdepartment.DisplayMember = "D_Name";
            cmbxdepartment.ValueMember = "D_Name";
            getdepartmets.Close();
            string[] gender_array = new string[2] {"Male","Female"};
            cmbxGender.DataSource = gender_array;
        }

        private void btnInsertstudentData_Click(object sender, EventArgs e)
        {
            if (
                (
                (cmbxdepartment.SelectedValue.ToString() == "Select Department")
                ||
                (txt_student_id_login.Text == "")
                ||
                (txt_student_Fname_login.Text == "")
                ||
                (txt_student_Lname_login.Text == "")
                ||
                (txt_student_B_date_login.Text == "")
                ||
                (txt_student_Address_login.Text == "")
                )
                )

            {
                MessageBox.Show("Complete Your Data");

            }
            else
            {
                // define variable to use in the insert statment
                int student_id = Convert.ToInt32(txt_student_id_login.Text);
                string student_First_name = txt_student_Fname_login.Text;
                string student_last_name = txt_student_Lname_login.Text;
                var date_of_birth = DateTime.ParseExact(txt_student_B_date_login.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string address = txt_student_Address_login.Text;
                string gender = cmbxGender.SelectedValue.ToString();
                string dept_name = cmbxdepartment.SelectedValue.ToString();

                // define a variable to retrive depatyment id out of choosen department name
                int department_id = 107; // this value will be changed below but without assigning i get error
                SqlConnection getDept_Id = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getDept_Id.Open();
                SqlCommand studentTableInsert = new SqlCommand("Select D_Id from Department where D_Name = @dept_name", getDept_Id);
                studentTableInsert.Parameters.AddWithValue("dept_name" , dept_name);
                SqlDataReader dept_id_from_dept_name_reader;
                dept_id_from_dept_name_reader = studentTableInsert.ExecuteReader(); 

                if (dept_id_from_dept_name_reader.Read())
                {
                    department_id = Convert.ToInt32(dept_id_from_dept_name_reader["D_Id"].ToString());
                }



                SqlConnection InsertstudentData = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                InsertstudentData.Open();
                SqlDataAdapter insert_stud_data_adap = new SqlDataAdapter();
                SqlCommand studentInsertquery = new SqlCommand("INSERT INTO Student " +
                    "(S_Id , S_Fname , S_Lname , DOB , Address , gender , D_Id) VALUES" +
                    "(@S_Id, @S_Fname , @S_Lname , @DOB ,@Address , @gender , @D_Id )", InsertstudentData);

                // inserting values
                studentInsertquery.Parameters.AddWithValue("S_Id", student_id);
                studentInsertquery.Parameters.AddWithValue("S_Fname", student_First_name);
                studentInsertquery.Parameters.AddWithValue("S_Lname", student_last_name);
                studentInsertquery.Parameters.AddWithValue("DOB", date_of_birth);
                studentInsertquery.Parameters.AddWithValue("Address", address);
                studentInsertquery.Parameters.AddWithValue("gender", gender);
                studentInsertquery.Parameters.AddWithValue("D_Id", department_id);
                // executing the insert command
                insert_stud_data_adap.InsertCommand = studentInsertquery;
                insert_stud_data_adap.InsertCommand.ExecuteNonQuery();
                // closing the connection
                InsertstudentData.Close();
                Program.Signout = 1;
                this.Dispose();


            }
        }
    }
}
    