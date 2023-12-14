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
            //List<string> male_names = new List<string> { "Steve" , "Bob" , "Eric" , "Dylan" , "Max"};
            //List<string> female_names = new List<string> { "Cassandra" , "Hannah" , "Sylvia" , "Nelly"};
            //string name;

            //Random r = new Random();
            
            /*
            name = male_names[r.Next(5)];
            if (name == Settings.Default.name)
            {
                name = male_names[r.Next(5)];
            }
            Settings.Default.name = name;
            */
        }

        class name_info
        {
            public string Name { get; }
            public Gender Gender { get; }
            public Theme Theme { get; }
            public Profession Profession { get; }

            public name_info(string name, Gender gender, Theme theme, Profession profession)
            {
                Name = name;
                Gender = gender;
                Theme = theme;
                Profession = profession;
            }
        }

        static List<name_info> namesDatabase = new List<name_info>
        {
            //male names
        new name_info("Martimus", Gender.Male, Theme.Fantasy, Profession.Warrior),
        new name_info("Alex", Gender.Male, Theme.Fantasy, Profession.Wizard),
        //new name_info("")


            //female names
        new name_info("Emily", Gender.Female, Theme.Fantasy, Profession.Wizard),
        
        };

        enum Gender
        {
            Male,
            Female
        }

        enum Theme
        {
            Fantasy,
            // Add more themes as needed
        }

        enum Profession
        {
            None,
            Warrior,
            Wizard,
            // Add more professions as needed
        }
    }
} 