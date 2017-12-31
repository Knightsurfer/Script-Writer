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
        long sconversion;

        long econversion;



        #region Smaller Parts
        void offsetvaluechange()
        {

            sconversion = Convert.ToInt32(Textoffset.Text, 16);
            
            switch (Textoffset.Text)
            {





                case "1E8211":
                    econversion = 1999487;
                    break;


                case "1E81F9":
                    econversion = 1999361;
                    break;

                case "1E8163":
                    econversion = 1999228;
                    break;

                case "1E818F":
                    econversion = 1999272;
                    break;


                case "1E8297":
                    econversion = 1999521;
                    break;


            }


            




            TextBox.Text = "";




        }



#endregion








        void Textoff_Value(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
            offsetvaluechange();
            decompiler();
            
            ByteSum.Text = "=" + " " + (econversion) + " " + "Bytes";
            

            bytecount = 0;






        }


        


        void decompiler()
        {
            long conversion = Convert.ToInt32(Textoffset.Text, 16)-1;
            





            while (conversion < econversion)
            {
          

                conversion++;
                
                BinaryReader reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                reader.BaseStream.Position = conversion; byte[] data = reader.ReadBytes(0x1); reader.Close(); string hexdata = BitConverter.ToString(data);
                //reads the current position and the hex value dictates the command.
                
                switch (hexdata)
                {


                    #region case 00 - nop
                    case "00":
                        bytecount += 1;
                        TextBox.Text += "nop \n";
                        break;
                    #endregion

                    #region case 01 - nop1
                    case "01":
                        bytecount += 1;
                        TextBox.Text += "nop1 \n";
                        break;
                    #endregion

                    #region case 02 - end
                    case "02":
                        bytecount += 1;
                        TextBox.Text += "end \n";
                        break;
                    #endregion

                    #region case 03 - return
                    case "03":
                        bytecount += 1;
                        TextBox.Text += "return \n";
                        break;
                    #endregion













                    #region case 04 - call
                    case "04":
                        bytecount += 5;
                        TextBox.Text += "call 0x8";
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion + 3;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        TextBox.Text += hexdata;

                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion + 2;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        TextBox.Text += hexdata;

                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion + 1;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        TextBox.Text += hexdata + "\n";

                        conversion += 4;



                        break;
                    #endregion

                    #region case 05 - goto
                    case "05":
                        bytecount += 5;
                        TextBox.Text += "goto 0x8";


                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion + 3;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        TextBox.Text += hexdata;

                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion + 2;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        TextBox.Text += hexdata;

                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion + 1;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        TextBox.Text += hexdata + "\n";

                        conversion += 4;


                        break;
                    #endregion

                    #region case A0 - checkgender
                    case "A0":
                        bytecount += 1;
                        TextBox.Text += "checkgender \n";
                        break;
                    #endregion

                    #region case 16 - setvar
                    case "16":
                        bytecount += 5;
                        TextBox.Text += "setvar 0x";
                        //Determines the command is "setvar" and commences the instructions".

                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion 
                        reader.BaseStream.Position = conversion + 2; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata;
                        //goes up by an inter of two and send it to the "hexdata" variable, then outputs the result.

                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion + 1; data = reader.ReadBytes(0x1); reader.Close();
                        //goes up 1 byte and sends it to the data variable 

                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata + " 0x";
                        //converts the data to hex and outputs the result

                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion + 3; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += data[0] + "\n";
                        //goes up 3 bytes and outputs the result.

                        conversion += 4;
                        //skips ahead to the next command.

                        break;
                    #endregion

                    #region case 21 - compare
                    case "21":
                        bytecount += 5;
                        TextBox.Text += "compare ";
                        //reads the current position and the hex value dictates the command.


                        conversion++;

                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        switch (hexdata)
                        {
                            case "0D":
                                TextBox.Text += "LASTRESULT 0x";

                                break;



                        }



                        conversion += 2;

                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));

                        reader.BaseStream.Position = conversion;     // The offset you are reading the data from
                        data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                        reader.Close();

                        hexdata = BitConverter.ToString(data);

                        switch (data[0])
                        {
                            default:
                                TextBox.Text += Convert.ToInt32(hexdata) + "\n";
                                break;


                        }
                        conversion -= 2;
                        break;
                    #endregion

                    #region case 69 - lockall
                    case "69":
                        
                        bytecount += 1;
                        TextBox.Text += "lockall" + "\n";
                        break;
                    #endregion

                    #region case 6B - releaseall
                    case "6B":
                        bytecount += 1;
                        TextBox.Text += "releaseall \n";
                        break;
                    #endregion

                    #region case 80 - if
                    case "80":
                        bytecount += 9;
                        conversion += 4;
                        TextBox.Text += "if ";

                        // Reads the command as "if" and proceeds to read the pointer.


                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); //TextBox.Text += Convert.ToInt32(hexdata) + " ";

                        switch (hexdata)
                        {

                            case "01":
                                TextBox.Text += "YES ";
                                break;


                            case "00":
                                TextBox.Text += "NO ";
                                break;


                        }




                        conversion -= 1;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data);

                        switch (hexdata)
                        {
                            case "07":
                                TextBox.Text += "call 0x8";
                                break;
                        }

                        conversion += 4;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();

                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata;

                        conversion -= 1;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata;

                        conversion -= 1;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata + "\n";



                        break;

                    #endregion

                    #region case 0F - MsgBox
                    case "0F":
                        bytecount += 8;
                        TextBox.Text += "MsgBox 0x8";

                        conversion += 4;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion


                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata;

                        conversion -= 1;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion


                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata;

                        conversion -= 1;
                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion


                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data); TextBox.Text += hexdata;

                        TextBox.Text += " ";



                        conversion += 5;
                        // Goes down 1 byte to read the second part of the pointer.


                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();
                        hexdata = BitConverter.ToString(data);

                        switch (hexdata)
                        {
                            case "04":
                                TextBox.Text += "MESSAGE_KEEPOPEN \n";

                                break;
                        }
                        // Determines how the message will be displayed.

                        #region reading
                        reader = new BinaryReader(new FileStream("D:\\Games\\Emulators\\Roms\\Handheld\\GBA\\Pokemon-Emerald.GBA", FileMode.Open, FileAccess.Read, FileShare.None));
                        #endregion
                        reader.BaseStream.Position = conversion; data = reader.ReadBytes(0x1); reader.Close();




                        break;

                    #endregion

                    #region case 68 - closeonkeypress
                    case "68":
                        bytecount += 1;
                        TextBox.Text += "closeonkeypress \n";
                        break;
                        #endregion




                }
                

                ByteCount.Text = "Byte Count = " + bytecount;





            }










        }


    }
}
