using System;
using System.IO;
using System.Windows.Forms;

namespace Script_Writer
{
    public partial class Arguebox : Form
    {

        public void Standard()
        {
            this.Text = ths.CommandBox.Text;
            cmd.Text = ths.CommandBox.Text;//Default Stuff

            Reading();
        }


        public void Reading()
        {
            #region Argument Covers
            reini = ini.Read(cmd.Text, "Argbx1");
            Arg1.Text = reini;

            reini = ini.Read(cmd.Text, "Argbx2");
            Arg2.Text = reini;
            #endregion
            #region Argument Items
            quantity = ini.Read("MaxArguments", Arg1.Text);
            int Max = Convert.ToInt32(quantity);

            for (int items = 0; items < Max; items++)
            {
                reini = ini.Read(Arg1.Text, "Value" + items.ToString());
                Arg1.Items.Add(reini);

            }

            reini = ini.Read(cmd.Text, "Argbx2");
            Arg2.Text = reini;


            reini = ini.Read(cmd.Text, "Argbx2");
            Arg2.Text = reini;


            quantity = ini.Read("MaxArguments", Arg1.Text);
            Max = Convert.ToInt32(quantity);

            for (int items = 0; items < Max; items++)
            {
                reini = ini.Read(Arg2.Text, "Value" + items.ToString());
                Arg2.Items.Add(reini);

            }
            #endregion
            #region Showe Argument 2
            switch (Arg2.Text)
            {
                case "":


                    break;

                default:
                    Arg2.Visible = true;
                    Arg2.Enabled = true;
                    switch (Arg3.Text)
                    {
                        case "":



                            break;

                        default:
                            Arg3.Visible = true;
                            Arg3.Enabled = true;

                            break;


                    }

                    break;

            }
            #endregion
        }
        




    }
}
