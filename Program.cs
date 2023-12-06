using Character_Creator.Properties;
using Microsoft.VisualBasic;
using System.Drawing.Text;

namespace Character_Creator
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }

        public static void name_generator()
        {
            List<string> l_name = new List<string>();
            string name;

            l_name.Add("Steve");
            l_name.Add("Bob");
            l_name.Add("Eric");
            l_name.Add("Dylan");
            l_name.Add("Max");

            Random r = new Random();
            
            name = l_name[r.Next(5)];
            if (name == Settings.Default.name)
            {
                name = l_name[r.Next(5)];
            }
            Settings.Default.name = name;
        }
    }
}