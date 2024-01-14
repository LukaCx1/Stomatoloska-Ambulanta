namespace Stomatoloska_ambulanta_demo_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            Form1 form1 = new Form1();

            
            if (form1.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form2());
            }
            else
            {
                Application.Exit();
            }
        }
    }
    }
