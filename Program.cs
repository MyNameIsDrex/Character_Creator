using Character_Creator.Properties;
using Microsoft.VisualBasic;
using System.Drawing.Text;
using System.Security.Permissions;

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

        public static void name_generator(int theme,int gender, bool leader)
        {
            //prefixes
            List<string> prefixes_fantasy = new List<string> { "Cor", "Jan", "Aef", "Ory", "Sam", "Gan", "Win", "Und", "Ell", "Eca", "Mim", "Hoy", "Var", "Lib", "Sha"};
            List<string> prefixes_highfantasy = new List<string> { "Aen", "Viu", "Ran", "Izze", "Paa", "Eif", "Drak", "Loy", "Uar", "Miu", "Veu", "Jin", "Eer", "Caa", "Uon"};
            
            List<string> prefixes_future = new List<string> { "Dor", "Hil", "Xal", "Ylas", "Tex", "Mega", "Tron", "Exo", "Win", "Raxu", "Milo", "Ins", "Ion", "Vo", "U-Ca"};
            List<string> prefixes_robot = new List<string> { "K-", "HAL", "91-", "XL", "19-", "Hyper", "Mega", "Giga", "Tera", "Exa", "EX-", "B98-", "TA-", "HXX", "XM88-", "P-", "PP-", "X", "VTGK", "JDC", "US", "RUS", "SWE", "CN", "TWA", "FIN", "ITA", "ARG", "rA9", "Bob"};

            List<string> prefixes_asian = new List<string> { "Xing", "San", "Wuk", "Tao", "Tsu", "Woa", "Rei", "Kumi", "Oni", "Jon", "Lem", "Puk", "Han", "Wei", "Miu", "Yao", "Bushi", "Son", "Tzen", "Tei", "Tui", "Budo", "Xom", "Wim"};

            List<string> prefixes_leader = new List<string> { "Cpt ", "Master ", "Captain ", "Operator ", "Liutenant ", "Leader ", "Lt. ", "Op. "};

            List<string> prefixes_steampunk = new List<string> { "Cog", "Gear", "Mech", "Wrench", "Steam", "Engine", "Wheel", "Industry", "Pipe", "Weld", "Rust", "Core", "Coal", "Big", "Metal", "Steel", "Power"};

            //suffixes
            List<string> suffixes_fantasy = new List<string> { "pus", "ian", "io", "ett", "fey", "pal", "ae", "ea", "sulus", "ovus", "id", "itus", "vit", "met", "akon", "us" };

            List<string> suffixes_future = new List<string> { "mar", "mus", "moir", "makor", "may", "icor", "ion", "ius", "illas", "iar", "dus", "dan", "dos", "dot", "dak", "xas", "xom", "x", "xci", "xok", "oom", "oz", "oyor", "opp", "bis", "bus", "bash", "bet", "pus", "pas", "pilas", "icus", "lian", "yx", "caw"};

            List<string> suffixes_steampunk = new List<string> { "works", "imus", "itus", "as", "tech", "weld", "maker", "machine", "master", "valve", "er", "y"};

            List<string> suffixes_robot1 = new List<string> { "46", "84", "35", "96", "01", "99", "9000", "3", "104", "44", "77", "01", "001", "1000", "2000", "4858", "9583", "7266", "957", "1111", "3633", "992", "853" };
            List<string> suffixes_robot2 = new List<string> { "-MK1", "-MK2", "-MK3", "-MK4", "-Mk5", "-MK6", " FPG", " Magnum", " Ultra", "-A", "-B", "-C", "-D", "-E", "-F"};

            //variables
            string name = "";
            
            Random r = new Random();

            //initial name generation
            if (theme == 0)
            {
                name = prefixes_fantasy[r.Next(prefixes_fantasy.Count)] + suffixes_fantasy[r.Next(suffixes_fantasy.Count)];
            }
            if (theme == 1)
            {
                name = prefixes_steampunk[r.Next(prefixes_steampunk.Count)] + suffixes_steampunk[r.Next(suffixes_steampunk.Count)];
            }
            if (theme == 2)
            {
                name = prefixes_future[r.Next(prefixes_future.Count)] + suffixes_future[r.Next(suffixes_future.Count)];
            }
            if (theme == 3)
            {
                name = prefixes_robot[r.Next(prefixes_robot.Count)] + suffixes_robot1[r.Next(suffixes_robot1.Count)] + suffixes_robot2[r.Next(suffixes_robot2.Count)]; 
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (name == Settings.Default.name) //makes sure the same name does not come up twice
            {
                name_generator(theme, gender, leader);
            }

            if (leader == true) //adds a leader prefix infront of the name
            {
                name = prefixes_leader[r.Next(prefixes_leader.Count)] + name;
            }
            
            if (gender == 0) //if gender is set to male then any female like names are regenerated
            {
                if (name.EndsWith("y") || name.EndsWith("a"))
                {
                    name_generator(theme, gender, leader);
                }
            }
            if (gender == 1) //if gender is set to female then any male like names are regenerated
            {
                if (name.EndsWith("n") || name.EndsWith("r") || name.EndsWith("t"))
                {
                    name_generator(theme, gender, leader);
                }
            }

            Settings.Default.name = name;
        }

        
    }
} 