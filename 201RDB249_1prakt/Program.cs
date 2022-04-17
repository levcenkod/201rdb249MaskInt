using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201RDB249_1prakt
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            Form1 mainForm = new Form1(Form2.PlayerStartsFirst);
            Application.Run(mainForm);
            while (Form1.wantToPlayAgain == true)
            {
                Application.Run(new Form2());
                Form1 mainForm2 = new Form1(Form2.PlayerStartsFirst);
                Application.Run(mainForm2);
            }
        }
    }
}
