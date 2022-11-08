using System;
using System.Windows.Forms;

namespace Final_Project
{
    static class Program
    {
        public static int Signout = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            while (Signout == 0)
            {
                
                Application.Run(new MainLogin());
               
                if (MainLogin.login == 's')
                {
                    
                    Application.Run(new StudentHome());
                    if (Signout == 1)
                    {
                        
                        Signout = 0; 
                        MainLogin.login = 'f';
                    }
                    else Signout = 1;
                    
                }
                else if (MainLogin.login == 'i')
                {
                    Application.Run(new InstructorHome());
                    if (Signout == 1)
                    {
                        Signout = 0;
                        MainLogin.login = 'f';
                    }
                    else Signout = 1;
                }
                else Signout = 1;
            }
            Application.Exit();
        }
    }
}
