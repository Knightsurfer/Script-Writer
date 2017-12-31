using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Script_Writer 
{


    //Main 
    //
    partial class Main : Form
    {

        #region Script Writer


    


        #endregion
        #region Test Stuff
        private void Cmd_Name(object sender, EventArgs e)
        {
            INIFile ini = new INIFile("Settings/commands.ini");
            string desc2 = ini.Read(name1.Text, "Description");
            desc1.Text = desc2;

            string bytes2 = ini.Read(name1.Text, "Bytes Used");
            bytes1.Text = bytes2;

            string usage2 = ini.Read(name1.Text, "Usage");
            usage1.Text = usage2;

            string types1 = ini.Read(name1.Text, "Type");
            type1.Text = types1;

            ini = new INIFile("Settings/Arguments.ini");

            string args1 = ini.Read(name1.Text, "Argbx1");
            arg1.Text = args1;

            string args2 = ini.Read(name1.Text, "Argbx2");
            arg2.Text = args2;

            string args3 = ini.Read(name1.Text, "Argbx3");
            arg3.Text = args3;

            string args4 = ini.Read(name1.Text, "Argbx4");
            arg4.Text = args4;



        }

        #endregion




    }


    // Activations






    //
    public partial class Main : Form
    {
        #region Switches
        private void CommandBoxSwitch()
        {
            switch (CommandBox.Text)
            {
                #region Standard
                case "nop":
                    desc_read = "does nothing.";
                    type_read = "N/A";
                    bytes_read = "1";
                    use_read = "nop";

                    arg_read = "false";
                    break;


                case "nop1":
                    desc_read = "does nothing.";
                    type_read = "N/A";
                    bytes_read = "1";
                    use_read = "nop1";

                    arg_read = "false";
                    break;










                    #endregion


            }
        }
        #endregion





    }
    
}