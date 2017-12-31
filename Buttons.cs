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
        #region ScriptWriter
        private void Add_click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(bytes_read); if (CommandBox.Text == "") { }
            else
            {
                switch (arg_read)
                {
                    case "true":

                        if (number + numberofbytes > MaxBytes)
                        {
                            MessageBox.Show("TOO MANY BYTES");
                        }
                        else
                        {
                            new Arguebox(this).Show();
                        }
                        break;

                    case "false":

                        if (number + numberofbytes > MaxBytes)
                        {
                            MessageBox.Show("TOO MANY BYTES");
                        }
                        else
                        {
                            ScriptTextOutput.Items.Add(CommandBox.Text);
                            Forgottennumbers.Items.Add(CommandBox.Text);
                            numberofbytes += number;
                            Bytes.Text = "No. of Bytes: " + numberofbytes + "/" + MaxBytes;

                            Forgottennumbers.SelectedIndex = Forgottennumbers.Items.Count - 1;
                            fgt_read = cini.Read(Forgottennumbers.Text, "Bytes Used"); label16.Text = fgt_read;
                            fgt_number = Convert.ToInt32(fgt_read);

                        }
                        break;
                }

            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(bytes_read);

            if (Forgottennumbers.Items.Count == 0) { }
            else
            {
                fgt_read = cini.Read(Forgottennumbers.Text, "Bytes Used"); label16.Text = fgt_read;
                fgt_number = Convert.ToInt32(fgt_read);



                if (Forgottennumbers.Items.Count < 1) { }
                else
                {

                    if (numberofbytes - fgt_number < 0) { }
                    else
                    {
                        ScriptTextOutput.Items.RemoveAt(ScriptTextOutput.Items.Count - 1);
                        Forgottennumbers.Items.RemoveAt(Forgottennumbers.Items.Count - 1);
                        fgt_read = cini.Read(Forgottennumbers.Text, "Bytes Used");
                        numberofbytes -= fgt_number;

                        Bytes.Text = "No. of Bytes: " + numberofbytes + "/" + MaxBytes;
                        Forgottennumbers.SelectedIndex = Forgottennumbers.Items.Count - 1;
                    }

                }
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            ScriptTextOutput.Items.Clear();
            ScriptTextOutput.Items.Add("//---------------");
            ScriptTextOutput.Items.Add("#org " + Pointer);
            Forgottennumbers.Items.Clear();


            numberofbytes = 0;
            Bytes.Text = "No. of Bytes: " + numberofbytes + "/" + MaxBytes;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Rubikon Code Files|*.rbc|RKC Header Files|*.rbh|Rubikon Template Files|*.rbt", ValidateNames = true })
            {
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter sw = new StreamWriter(sfd.FileName))

                    {

                        foreach (string itemText in ScriptTextOutput.Items)
                        {

                            sw.WriteLine(itemText);
                        }

                    }

                    MessageBox.Show("File Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }


            }//Script Saving
            using (StreamWriter sw = new StreamWriter("Assets/Reading/Log/Last Entries.txt"))
            {

                sw.WriteLine(numberofbytes);

            }
        }
        #endregion

        #region TestStuff


        private void SaveINI_Click(object sender, EventArgs e)
        {
            cini.Write(name1.Text, "Description", desc1.Text);
            cini.Write(name1.Text, "Type", type1.Text);
            cini.Write(name1.Text, "Bytes Used", bytes1.Text);
            cini.Write(name1.Text, "Usage", usage1.Text);

            aini = new INIFile("Settings/Arguments.ini");

            aini.Write(name1.Text, "Argbx1", arg1.Text);
            aini.Write(name1.Text, "Argbx2", arg2.Text);
            aini.Write(name1.Text, "Argbx3", arg3.Text);
            aini.Write(name1.Text, "Argbx4", arg4.Text);

            switch (arg1.Text)
            {

                case "":

                    break;
                default:
                    aini.Write("MaxArguments", arg1.Text, "5");
                    aini.Write("MaxArguments", arg2.Text, "5");
                    aini.Write("MaxArguments", arg3.Text, "5");
                    aini.Write("MaxArguments", arg4.Text, "5");
                    break;
            }
        }
        #endregion









    }
}
