#region Using
using System;
using System.IO;
using System.Windows.Forms;
#endregion

namespace Script_Writer
{
    public partial class Arguebox : Form
    {string quantity;
        INIFile ini = new INIFile
       ("Settings/Arguments.ini");
        string reini;
        public string Arg1s;
        public string Arg2s;
    }
}
