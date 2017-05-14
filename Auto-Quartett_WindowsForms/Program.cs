using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Quartett_WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(createForm1());
        }

        private static Form1 createForm1()
        {
            DatenZugriff datenZugriff = new DatenZugriff("VordefinierteKarten.xml");
            return new Form1(datenZugriff);
        }
    }
}
