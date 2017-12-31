using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Script_Writer
{


    partial class Main : Form
    {
       int bytecount;

        #region Pointer Box
        public void PointerValue(object sender, EventArgs e)
        {
            Pointer = AddressBox.Text;

            ScriptTextOutput.Items.RemoveAt(1);
            ScriptTextOutput.Items.Insert(1, "#org 0x" + Pointer);
            PointerBox();
            //   args1 = pini.Read(Pointer, "MaxBytes");
            //   MaxBytes = Convert.ToInt32(args1);
            Bytes.Text = "No. of Bytes: " + numberofbytes + "/" + MaxBytes;


            













            
        }
        public void PointerBox()
        {
            switch (AddressBox.Text)
            {
                case "1E81F9":
                    MaxBytes = 10;
                    break;

                case "1E8163":
                    MaxBytes = 27;
                    break;

                case "1E818F":
                    MaxBytes = 27;
                    break;

            }
        }
        #endregion





    }
}
