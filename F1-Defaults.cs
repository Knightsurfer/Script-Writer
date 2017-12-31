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



        #region Script Writer
        public void Default_Stuff()
        {
            Usage.Text = "";
            BytesUsed.Text = "";
            Types.Text = "";
            Description.Text = "";

            richTextBox3.Text = "";


            ///////////////////////////////////
            long hexbegin;
            long hexend = 9999;
            string hexvalue;




            try
            {
                for (hexbegin = 000000; hexbegin < hexend; hexbegin += 6)
                {
                    BinaryReader reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                    reader.BaseStream.Position = hexbegin;     // The offset you are reading the data from
                    byte[] data = reader.ReadBytes(0x6); // Read 16 bytes into an array
                    reader.Close();

                    string hexdata = BitConverter.ToString(data);

                    ScriptTextOutput2.Text += hexdata + "\n";


                }
            }
            catch
            {
                MessageBox.Show("Rom In Use!");
            }
















            }
        #endregion






























    }
}
