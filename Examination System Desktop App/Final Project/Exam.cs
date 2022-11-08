using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;


namespace Final_Project
{
    

  
    public partial class Exam : Form
    {
        public Exam()  
        {
            InitializeComponent();
            
        }

        public Exam(string s_id ,string Fname, string Lname)  //66
        {
            InitializeComponent();

            lblstudfullname.Text = Fname + " " + Lname;  //66
        }
        public string propFname { set; get; } //66
        public string propLname { set; get; } //66
        public string props_id { set; get; }
        
        string current_qst_id;
        string course_id;
        string exam_id;
        string datenow;
        string student_final_grade_in_course;

        // define list of ten questions 
        List<String> questions_list = new List<string>();   // for all question text
        List<String> model_ans_list = new List<string>();    // for all model answers  // may remove
        List<String> question_ids = new List<string>(); // for all ids     //may reomve
        List<String> question_grades = new List<string>();

        String[] student_answer_list = new String [10]{"0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        List<int> correcting = new List<int>();
        string choosen_answer_of_first_Qst = "Hello";



        private void Form2_Load(object sender, EventArgs e)
        {



            datenow = DateTime.Now.ToString("yyyy-MM-dd");
            lbldate.Text = datenow;
            lblstudentid.Text = props_id;


            lblstudfullname.Text = propFname + " " + propLname;

            // defining connection to get course list
            SqlConnection getcourses = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            getcourses.Open();
            SqlCommand gtcrs = new SqlCommand("SELECT  C_Name FROM Course ", getcourses);
            SqlDataAdapter crsda = new SqlDataAdapter();
            crsda.SelectCommand = gtcrs;
            DataTable crstable = new DataTable();
            crsda.Fill(crstable);

            DataRow itemrow = crstable.NewRow();
            itemrow[0] = "Select Course";
            crstable.Rows.InsertAt(itemrow, 0);

            cmbbx1.DataSource = crstable;
            cmbbx1.DisplayMember = "C_Name";
            cmbbx1.ValueMember = "C_name";
            getcourses.Close();

           
            lblquestion.Hide();
            rbchoice1.Hide();
            rbchoice2.Hide();
            rbchoice3.Hide();
            rbchoice4.Hide();
            dgv_all_answers.Hide();
            dgvmodelans.Hide();
            btnsubmit.Hide();
            btnnext.Hide();
            LblTotalQs.Hide();
            lblnumberofchoosen.Hide();
            lblqstnumber.Hide();
            LblChosenAns.Hide();
            lblchoosendummy.Hide();
            PBxNext.Hide();
            PBxSubmit.Hide();
            BtnStuAnsDGV.Hide();
            BtnModelAnsDGV.Hide();


        }
        

        private void cmbbx1_SelectedValueChanged(object sender, EventArgs e)
        {
            lblcurrentexam.Text = cmbbx1.SelectedValue.ToString() + " " + "Exam";

            SqlConnection getcourseid = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            getcourseid.Open();
            SqlCommand getcrsid = new SqlCommand("SELECT C_Id FROM Course WHERE C_Name =@C_Name ", getcourseid);
            getcrsid.Parameters.AddWithValue("C_Name", cmbbx1.SelectedValue.ToString());
            SqlDataReader reader2;
            reader2 = getcrsid.ExecuteReader();
            if (reader2.Read())
            {
                course_id = reader2["C_id"].ToString();
                lblcourseid.Text = course_id;
            }

        }
        List<String> choices = new List<String>();
        
        int number_of_current_qst = 1;


        // Start button click_event
        private void btnstart_Click(object sender, EventArgs e )
        {
            
            if (cmbbx1.SelectedValue.ToString() == "Select Course")
            {
                MessageBox.Show("Select Course");

            }
            else
            {

                lblquestion.Show();
                lblselectcourse.Hide();
                cmbbx1.Hide();
                rbchoice1.Show();
                rbchoice2.Show();
                rbchoice3.Show();
                rbchoice4.Show();
                btnsubmit.Show();
                btnnext.Show();
                lblstudfullname.Show();
                LblTotalQs.Show();
                lblnumberofchoosen.Show();
                lblqstnumber.Show();
                LblChosenAns.Show();
                lblchoosendummy.Show();
                PBxNext.Show();
                PBxSubmit.Show();
                PBxStart.Hide();
                PBxMainLogin.Hide();

                // get the exam questions (10 questions)

                SqlConnection getquestion = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getquestion.Open();
                SqlCommand gtqst = new SqlCommand("SELECT  TOP(10) Q_Text , Model_Ans , Q_ID ,Q_Grade FROM Question WHERE C_Id = @C_Id and len(Q_Text)<180 ORDER BY newid()  ", getquestion);
                gtqst.Parameters.AddWithValue("C_Id",lblcourseid.Text);
                SqlDataReader qstda;
                qstda = gtqst.ExecuteReader();
                while(qstda.Read())
                {
                    // loading question into a list
                    questions_list.Add(Convert.ToString(qstda["Q_Text"]));
                    model_ans_list.Add(Convert.ToString(qstda["Model_Ans"]));    // i may remove this
                    question_ids.Add(Convert.ToString(qstda["Q_Id"]));            // i may remove this
                    question_grades.Add(Convert.ToString(qstda["Q_Grade"]));
                    
                }

                // getting the first question from questions' list
                string question1 = questions_list[0].ToString();
                //current_question_id = qstda["Q_Id"].ToString();
                getquestion.Close();

                

                // connection to get question id
                SqlConnection getid = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getid.Open();
                SqlCommand gtid = new SqlCommand("SELECT Q_Id FROM Question WHERE Q_Text = @Q_text", getid);
                gtid.Parameters.AddWithValue("Q_Text", question1);
                SqlDataReader idda = gtid.ExecuteReader();
                if (idda.Read())
                {
                    current_qst_id =Convert.ToString(idda["Q_Id"]);
                }
                current_qst_id = Convert.ToString(idda["Q_Id"]);
                getid.Close();



                // get the choices of the question
                choices.Clear();
                SqlConnection getchoices = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getchoices.Open();
                SqlCommand gtchs = new SqlCommand("SELECT Q_Id , Choice FROM Choices WHERE Q_Id = @Q_Id ", getchoices);             
                gtchs.Parameters.AddWithValue("Q_Id", current_qst_id);     
                SqlDataReader chsda;
                chsda = gtchs.ExecuteReader();
                while (chsda.Read())
                {
                    choices.Add(Convert.ToString(chsda["Choice"]));
                }
                getchoices.Close();



                // get model answer

                SqlConnection getmodelans = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getmodelans.Open();
                SqlCommand gtchvalid = new SqlCommand("SELECT Model_Ans FROM Question WHERE Q_Id = @Q_Id ", getmodelans);
                gtchvalid.Parameters.AddWithValue("Q_Id", current_qst_id);
                SqlDataReader chvalidda;
                chvalidda = gtchvalid.ExecuteReader();
                while (chvalidda.Read())
                {
                    choices.Add(Convert.ToString(chvalidda["Model_Ans"]));
                    //////lblop4txt.Text = choices[choices.Count-1];
                }
                getmodelans.Close();

                // checking choosen answer of the first question


                choices.Sort();
                

                lblqstnumber.Text = (number_of_current_qst).ToString();   
                int lenquestions = questions_list.Count;
                lblnumberofchoosen.Text = lenquestions.ToString();       // to show the number of questions in our list
                lblquestion.Text = question1;          
                string q1 = questions_list[0];
                string ch1 = choices[0];
                string ch2 = choices[1];
                string ch3 = choices[2];
                string ch4 = choices[3];
                rbchoice1.Text = ch1.ToString();   //
                rbchoice2.Text = ch2.ToString();  //
                rbchoice3.Text = ch3.ToString();   //
                rbchoice4.Text = ch4.ToString();   //
                int lenlist = choices.Count;
                btnstart.Hide();

                student_answer_list[number_of_current_qst - 1] = choosen_answer_of_first_Qst;
                lblchoosendummy.Text = choosen_answer_of_first_Qst;

            }
        }


        // next button_event
        private void btnnext_Click(object sender, EventArgs e)
        {
            
            


            rbchoice1.Checked = false;
            rbchoice2.Checked = false;
            rbchoice3.Checked = false;
            rbchoice4.Checked = false;
            if (number_of_current_qst < 10)
            {


                number_of_current_qst += 1;
                lblqstnumber.Text = number_of_current_qst.ToString();


                // check condition to show the back btn
                



                

                //int indexofquestion = 1;
                lblquestion.Text = questions_list[number_of_current_qst - 1];
                SqlConnection getid = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getid.Open();
                SqlCommand gtid = new SqlCommand("SELECT Q_Id FROM Question WHERE Q_Text = @Q_text", getid);
                gtid.Parameters.AddWithValue("Q_Text", questions_list[number_of_current_qst - 1]);
                SqlDataReader idda = gtid.ExecuteReader();
                if (idda.Read())
                {
                    current_qst_id = Convert.ToString(idda["Q_Id"]);
                }
                current_qst_id = Convert.ToString(idda["Q_Id"]);
                getid.Close();


                // get the choices of the question
                choices.Clear();        // to remove every choice in this list so that there always only be 4 choices
                SqlConnection getchoices = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getchoices.Open();
                SqlCommand gtchs = new SqlCommand("SELECT Q_Id , Choice FROM Choices WHERE Q_Id = @Q_Id ", getchoices);
                gtchs.Parameters.AddWithValue("Q_Id", current_qst_id);
                SqlDataReader chsda;
                chsda = gtchs.ExecuteReader();
                while (chsda.Read())
                {
                    choices.Add(Convert.ToString(chsda["Choice"]));
                }
                getchoices.Close();

                // get model answer

                SqlConnection getmodelans = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                getmodelans.Open();
                SqlCommand gtchvalid = new SqlCommand("SELECT Model_Ans FROM Question WHERE Q_Id = @Q_Id ", getmodelans);
                gtchvalid.Parameters.AddWithValue("Q_Id", current_qst_id);
                SqlDataReader chvalidda;
                chvalidda = gtchvalid.ExecuteReader();
                while (chvalidda.Read())
                {
                    choices.Add(Convert.ToString(chvalidda["Model_Ans"]));
                    //////lblop4txt.Text = choices[choices.Count-1];
                }

                getmodelans.Close();

                choices.Sort();
                


                string ch1 = choices[0];
                string ch2 = choices[1];
                string ch3 = choices[2];
                string ch4 = choices[3];
                rbchoice1.Text = ch1.ToString();   ///
                rbchoice2.Text = ch2.ToString();    //
                rbchoice3.Text = ch3.ToString();
                rbchoice4.Text = ch4.ToString();


                if (number_of_current_qst == 10)
                {
                    btnnext.Hide();
                    PBxNext.Hide();
                }
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {


            // hide the submit button
            btnsubmit.Hide();
            PBxSubmit.Hide();
            lblqstnumber.Hide();
            lblquestion.Hide();
            rbchoice1.Hide();
            rbchoice2.Hide();
            rbchoice3.Hide();
            rbchoice4.Hide();
            btnnext.Hide();
            PBxNext.Hide();
            BtnModelAnsDGV.Show();
            BtnStuAnsDGV.Show();



            // This block of code helps showing the string (not its length) form a list in a datagridView
            dgv_all_answers.Show();
            var result = student_answer_list.Select(s => new { value = s }).ToList();
            dgv_all_answers.DataSource = result;
            dgv_all_answers.ClearSelection();


            // show the correct answers 
            dgvmodelans.Show();
            var modelAnsToGetMark = model_ans_list.Select(s => new { value = s }).ToList();
            dgvmodelans.DataSource = modelAnsToGetMark;
            dgvmodelans.ClearSelection();



            // defining a function to get student grade
            for (int i = 0; i < model_ans_list.Count; i++)
            {
                if (student_answer_list[i] == model_ans_list[i])
                {
                    correcting.Add(1);
                }
                else
                {
                    correcting.Add(0);
                }
            }
            student_final_grade_in_course = correcting.Sum().ToString();



            try
            {
                if (Student.FullName != "Admin")
                {

                    // these lines of code are used to ionsert date in exam table after student finished his exam;
                    exam_id = course_id + props_id;
                    SqlConnection insertintoexamtable = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                    insertintoexamtable.Open();
                    SqlDataAdapter examinsertadapter = new SqlDataAdapter();
                    SqlCommand ExamTableInsertQuery = new SqlCommand("INSERT INTO EXAM (E_Id , Date , C_Id) VALUES (@exam_id, @datenow , @course_id)", insertintoexamtable);
                    ExamTableInsertQuery.Parameters.AddWithValue("exam_id", exam_id);
                    ExamTableInsertQuery.Parameters.AddWithValue("datenow", datenow);
                    ExamTableInsertQuery.Parameters.AddWithValue("course_id", course_id);
                    examinsertadapter.InsertCommand = ExamTableInsertQuery;
                    examinsertadapter.InsertCommand.ExecuteNonQuery();





                    //these lines of code are used to insert data into the take exam table
                    SqlConnection InsertIntoTakeExamTable = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                    InsertIntoTakeExamTable.Open();
                    SqlDataAdapter TakeExaminsertAdapter = new SqlDataAdapter();


                    for (int i = 0; i < 10; i++)
                    {
                        SqlCommand TakeExamInsertQuery = new SqlCommand("INSERT INTO Take_Exam (E_Id , S_Id , Q_Id , St_Ans ,SQ_Grade) VALUES (@exam_id , @props_id ,@current_qst_id , @st_Ans , @student_final_grade_in_course )", InsertIntoTakeExamTable);
                        TakeExamInsertQuery.Parameters.AddWithValue("exam_id", exam_id);
                        TakeExamInsertQuery.Parameters.AddWithValue("props_id", props_id);
                        TakeExamInsertQuery.Parameters.AddWithValue("current_qst_id", question_ids[i]);
                        TakeExamInsertQuery.Parameters.AddWithValue("St_Ans", correcting[i]);
                        TakeExamInsertQuery.Parameters.AddWithValue("student_final_grade_in_course", Convert.ToInt32(question_grades[i]) * correcting[i]);
                        TakeExaminsertAdapter.InsertCommand = TakeExamInsertQuery;
                        TakeExaminsertAdapter.InsertCommand.ExecuteNonQuery();
                    }



                    // define a variable that is 3 month before now
                    var enroll_date = DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd");
                    // defining a variable of student's final grade as percentage
                    double final_grade = ((correcting.Sum()) / (double)10) * 100;
                    // these lines of code are used to insert into stu_crs tables
                    SqlConnection InsertIntoStuCrs = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                    InsertIntoStuCrs.Open();
                    SqlCommand StuCrsInsertQuery = new SqlCommand("INSERT INTO Stu_Crs (S_Id , C_Id , Enroll_Date , Stu_Crs_Grade ) VALUES (@props_id,@course_id ,@enroll_date , @final_grade )", InsertIntoStuCrs);
                    StuCrsInsertQuery.Parameters.AddWithValue("props_id", props_id);
                    StuCrsInsertQuery.Parameters.AddWithValue("course_id", course_id);
                    StuCrsInsertQuery.Parameters.AddWithValue("enroll_date", enroll_date);
                    StuCrsInsertQuery.Parameters.AddWithValue("final_grade", final_grade);
                    SqlDataAdapter StuCrsInsertAdapter = new SqlDataAdapter();
                    StuCrsInsertAdapter.InsertCommand = StuCrsInsertQuery;
                    StuCrsInsertAdapter.InsertCommand.ExecuteNonQuery();

                }

                MessageBox.Show("Your Grade is: " + student_final_grade_in_course, "Final Grade", MessageBoxButtons.OK);

            }
            catch 
            {
                MessageBox.Show("You Took an Exam in this Course Before", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void rbchoice1_CheckedChanged(object sender, EventArgs e)
        {
            lblchoosendummy.Text = rbchoice1.Text;
            student_answer_list[number_of_current_qst - 1] = rbchoice1.Text;
        }

        private void rbchoice2_CheckedChanged(object sender, EventArgs e)
        {
            lblchoosendummy.Text = rbchoice2.Text;
            student_answer_list[number_of_current_qst-1 ] = rbchoice2.Text;
        }

        private void rbchoice3_CheckedChanged(object sender, EventArgs e)
        {
            lblchoosendummy.Text = rbchoice3.Text;
            student_answer_list[number_of_current_qst-1 ] = rbchoice3.Text;
        }

        private void rbchoice4_CheckedChanged(object sender, EventArgs e)
        {
            lblchoosendummy.Text = rbchoice4.Text;
            student_answer_list[number_of_current_qst - 1] = rbchoice4.Text;
        }

        private void BtnEndExam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (number_of_current_qst > 1)
            {
                number_of_current_qst -= 1;
                lblqstnumber.Text = number_of_current_qst.ToString();


            lblquestion.Text = questions_list[number_of_current_qst - 1];
            SqlConnection getid = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            getid.Open();
            SqlCommand gtid = new SqlCommand("SELECT Q_Id FROM Question WHERE Q_Text = @Q_text", getid);
            gtid.Parameters.AddWithValue("Q_Text", questions_list[number_of_current_qst - 1]);
            SqlDataReader idda = gtid.ExecuteReader();
            if (idda.Read())
            {
                current_qst_id = Convert.ToString(idda["Q_Id"]);
            }
            current_qst_id = Convert.ToString(idda["Q_Id"]);
            getid.Close();


            // get the choices of the question
            choices.Clear();        // to remove every choice in this list so that there always only be 4 choices
            SqlConnection getchoices = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            getchoices.Open();
            SqlCommand gtchs = new SqlCommand("SELECT Q_Id , Choice FROM Choices WHERE Q_Id = @Q_Id ", getchoices);
            gtchs.Parameters.AddWithValue("Q_Id", current_qst_id);
            SqlDataReader chsda;
            chsda = gtchs.ExecuteReader();
            while (chsda.Read())
            {
                choices.Add(Convert.ToString(chsda["Choice"]));
            }
            getchoices.Close();

            // get model answer

            SqlConnection getmodelans = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            getmodelans.Open();
            SqlCommand gtchvalid = new SqlCommand("SELECT Model_Ans FROM Question WHERE Q_Id = @Q_Id ", getmodelans);
            gtchvalid.Parameters.AddWithValue("Q_Id", current_qst_id);
            SqlDataReader chvalidda;
            chvalidda = gtchvalid.ExecuteReader();
            while (chvalidda.Read())
            {
                choices.Add(Convert.ToString(chvalidda["Model_Ans"]));
                //////lblop4txt.Text = choices[choices.Count-1];
            }

            getmodelans.Close();

            choices.Sort();
            choices.Sort();



            string ch1 = choices[0];
            string ch2 = choices[1];
            string ch3 = choices[2];
            string ch4 = choices[3];
            rbchoice1.Text = ch1.ToString();   ///
            rbchoice2.Text = ch2.ToString();    //
            rbchoice3.Text = ch3.ToString();
            rbchoice4.Text = ch4.ToString();
            }





        }
    }


    
    

}



