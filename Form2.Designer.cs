namespace Script_Writer
{
    partial class Arguebox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.OK = new System.Windows.Forms.Button();
            this.Arg1 = new System.Windows.Forms.ComboBox();
            this.Arg2 = new System.Windows.Forms.ComboBox();
            this.cmd = new System.Windows.Forms.Label();
            this.Arg3 = new System.Windows.Forms.ComboBox();
            this.Arg4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(315, 60);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Arg1
            // 
            this.Arg1.FormattingEnabled = true;
            this.Arg1.Location = new System.Drawing.Point(18, 47);
            this.Arg1.Name = "Arg1";
            this.Arg1.Size = new System.Drawing.Size(121, 21);
            this.Arg1.TabIndex = 3;
            this.Arg1.Text = "byte1";
            // 
            // Arg2
            // 
            this.Arg2.Enabled = false;
            this.Arg2.FormattingEnabled = true;
            this.Arg2.Location = new System.Drawing.Point(161, 47);
            this.Arg2.Name = "Arg2";
            this.Arg2.Size = new System.Drawing.Size(121, 21);
            this.Arg2.TabIndex = 4;
            this.Arg2.Visible = false;
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(15, 21);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(27, 13);
            this.cmd.TabIndex = 10;
            this.cmd.Text = "cmd";
            // 
            // Arg3
            // 
            this.Arg3.Enabled = false;
            this.Arg3.FormattingEnabled = true;
            this.Arg3.Location = new System.Drawing.Point(18, 74);
            this.Arg3.Name = "Arg3";
            this.Arg3.Size = new System.Drawing.Size(121, 21);
            this.Arg3.TabIndex = 12;
            this.Arg3.Visible = false;
            // 
            // Arg4
            // 
            this.Arg4.Enabled = false;
            this.Arg4.FormattingEnabled = true;
            this.Arg4.Location = new System.Drawing.Point(161, 74);
            this.Arg4.Name = "Arg4";
            this.Arg4.Size = new System.Drawing.Size(121, 21);
            this.Arg4.TabIndex = 13;
            this.Arg4.Visible = false;
            // 
            // Arguebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 119);
            this.Controls.Add(this.Arg4);
            this.Controls.Add(this.Arg3);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.Arg2);
            this.Controls.Add(this.Arg1);
            this.Controls.Add(this.OK);
            this.Name = "Arguebox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Default);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.ComboBox Arg2;
        public System.Windows.Forms.ComboBox Arg1;
        public System.Windows.Forms.Label cmd;
        public System.Windows.Forms.ComboBox Arg3;
        public System.Windows.Forms.ComboBox Arg4;
    }
}