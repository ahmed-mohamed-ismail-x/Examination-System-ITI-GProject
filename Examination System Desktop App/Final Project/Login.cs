using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Final_Project
{
    static class Login
    {

        //username ---> student first name
        //password ---> student id
        public static int StudentLogin(string userName, int password)
        {
            int result = 0;
            string cstring = ConfigurationManager.ConnectionStrings["Project"].ToString();

            using (SqlConnection c = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand("Login_Student", c))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
                    cmd.Parameters.Add("@password", SqlDbType.Int).Value = password;
                    c.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result = int.Parse(reader["Result"].ToString());
                    }
                }
                if (result != 0)
                {
                    using (SqlCommand cmd = new SqlCommand("Student_Select", c))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@s_Id", SqlDbType.Int).Value = password;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Student.Id = reader["S_Id"].ToString();
                                Student.Firstname = reader["S_Fname"].ToString();
                                Student.Lastname = reader["S_Lname"].ToString();
                                Student.FullName = Student.Firstname + " " + Student.Lastname;
                            }
                        }
                    }
                }
            }
            return result;
        }

        ///////////////////////////////////////////////////////////////////////





        //username ---> instructor name
        //password ---> instructor id
        // 'WING CHAN', 69
        public static int InstructorLogin(string userName, int password)
        {
            int result = 0;
            string cstring = ConfigurationManager.ConnectionStrings["Project"].ToString();

            using (SqlConnection c = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand("Login_Instructor", c))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
                    cmd.Parameters.Add("@password", SqlDbType.Int).Value = password;
                    c.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result = int.Parse(reader["Result"].ToString());
                    }
                }
                if (result != 0)
                {
                    using (SqlCommand cmd = new SqlCommand("Instructor_Select", c))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ins_id", SqlDbType.Int).Value = password;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Instructor.Id = reader["Ins_Id"].ToString();
                                Instructor.Name = reader["INs_Name"].ToString();
                            }
                        }
                    }
                }
            }
            return result;
        }

        ///////////////////////////////////////////////////////////////////////













    }
}
