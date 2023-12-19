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

        public static void name_generator()
        {
            List<string> prefixes_fantasy = new List<string> { "Cor", "Jan", "Aef", "Ory", "Sam", "Gan", "Win", "Und", "Ell", "Eca", "Mim", "Hoy", "Var", "Lib", "Sha"};
            List<string> prefixes_highfantasy = new List<string> { "Aen", "Viu", "Ran", "Izze", "Paa", "Eif", "Drak", "Loy", "Uar", "Miu", "Veu", "Jin", "Eer", "Caa", "Uon"};
            
            List<string> prefixes_future = new List<string> { "Dor", "Hil", "Xal", "Ylas", "Tex", "Mega", "Tron", "Exo", "Win", "Raxu", "Milo", "Ins", "Ion", "Vo", "U-Ca"};
            List<string> prefixes_robot = new List<string> { "K-", "HAL", "91-", "XL", "19-", "Hyper", "Mega", "Giga", "Tera", "Exa", "EX-", "B98-", "TA-", "HXX", "XM88-", "P-", "PP-", "X", "VTGK", "JDC", "US", "RUS", "SWE", "CN", "TWA", "FIN", "ITA", "ARG", "rA9", "Bob"};

            List<string> prefixes_asian = new List<string> { "Xing", "San", "Wuk", "Tao", "Tsu", "Woa", "Rei", "Kumi", "Oni", "Jon", "Lem", "Puk", "Han", "Wei", "Miu", "Yao", "Bushi", "Son", "Tzen", "Tei", "Tui", "Budo", "Xom", "Wim"};

            List<string> prefixes_leader = new List<string> { "Cpt ", "Master ", "Captain ", "Operator ", "Liutenant ", "Leader ", "Lt. ", "Op. "};
            
            string name = "";

            Random r = new Random();
            
            if (name == Settings.Default.name)
            {
                name_generator();
            }
            Settings.Default.name = name;

        }
    }
} 