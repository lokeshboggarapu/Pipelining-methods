using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pipelining_methods
{
    static class Program
    {
        
        ///  entry point into the application.
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
