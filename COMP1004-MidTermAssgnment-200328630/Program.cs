using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MidTermAssgnment_200328630
{
    static class Program
    {
        internal static Character character;

        public static Character Character { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AbilityForm());
        }
    }
}
