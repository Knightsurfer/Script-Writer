using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Script_Writer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());//(args.Length == 0 ?*/new Form1(public string.Empty) :*=  new Form1(args[0]));
        }
    }
}
