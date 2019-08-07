using COMP123_S2019_LESSON13B_PART2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSON13B_PART2
{
    public static class Program
    {
        public static MyMDIParent parentform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            parentform = new MyMDIParent();
            Application.Run(parentform);
        }
    }
}
