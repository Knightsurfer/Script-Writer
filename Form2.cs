using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script_Writer
{




    public partial class Arguebox : Form
    {


        



        Main ths;
        public Arguebox(Main frm)
        {
            InitializeComponent();
            ths = frm;
        }
        public void Default(object sender, EventArgs e)
        {
            Standard();
        }
        public void OK_Click(object sender, EventArgs e)
        {

            ths.Forgottennumbers.Items.Add(ths.CommandBox.Text);
            ths.Forgottennumbers.SelectedIndex = ths.Forgottennumbers.Items.Count - 1;
            ths.fgt_read = ths.cini.Read(ths.Forgottennumbers.Text, "Bytes Used"); ths.label16.Text = ths.fgt_read;
            ths.fgt_number = Convert.ToInt32(ths.fgt_read);
            ths.numberofbytes += ths.number;

            ths.Bytes.Text = "No. of Bytes: " + ths.numberofbytes + "/" + ths.MaxBytes;


            switch (Arg2.Visible)
            {
                case false:
                    ths.ScriptTextOutput.Items.Add(ths.CommandBox.SelectedItem + " " + Arg1.Text);
                    break;

                   case true:
                    


                    switch (Arg3.Visible)
                    {
                        case false:

                            ths.ScriptTextOutput.Items.Add(ths.CommandBox.SelectedItem + " " + Arg1.Text + " " + Arg2.Text);

                            break;

                        default:


                            break;
                    }


                            break;

            }



            switch (Arg2.Text)
            {
                case "":



                    ths.numberofbytes += ths.bytes2;
                    ths.Bytes.Text = "No. of Bytes: " + ths.numberofbytes + "/" + ths.MaxBytes;

                    break;

                default:

                    break;


            }


            //ths.ScriptTextOutput.Items.Add(ths.CommandBox.SelectedItem + " " + (Arg1s) + " " + (Arg2s) + "\n");

            this.Close();





        }
    }
}
