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
        #region Read Commands
        public string desc_read;
        public string type_read;
        public string bytes_read;
        public string use_read;

        public string arg_read;
        public string fgt_read;
        #endregion
        #region Sums
        public string Pointer = "0x000000";
        public int number;
        public int fgt_number;
        public int numberofbytes = 0;
        public int MaxBytes = 999;
        public int MinBytes = 0;
        #endregion

        int value = 30;

        

        #region Methods
        public INIFile cini  = new INIFile("Settings/Commands.ini");
        public INIFile pini  = new INIFile("Settings/Pointers.ini");
        public INIFile cfini = new INIFile("Settings/config.ini");
        public INIFile aini  = new INIFile("Settings/config.ini");
        #endregion
        #region Form2
        public string args1;
        public int ByteSums = 0;
        public int bytes2 = 0;
        #endregion

















        string command;
        string command_bytes;
        string script_bytesused;
        string other;











    }}
