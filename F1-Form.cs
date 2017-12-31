#region Using
using System;
using System.IO;
using System.Windows.Forms;
#endregion



namespace Script_Writer
{
    partial class Main
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ToolStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddressBox = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Bytes = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ScriptTextOutput = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.BytesUsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Types = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label0 = new System.Windows.Forms.Label();
            this.Usage = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.CommandBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.ByteSum = new System.Windows.Forms.Label();
            this.Textoffset = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ScriptTextOutput2 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Forgottennumbers = new System.Windows.Forms.ListBox();
            this.name1 = new System.Windows.Forms.ComboBox();
            this.arg4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.arg3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.arg2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.arg1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.type1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.usage1 = new System.Windows.Forms.TextBox();
            this.bytes1 = new System.Windows.Forms.TextBox();
            this.desc1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveINI = new System.Windows.Forms.Button();
            this.LoadINI = new System.Windows.Forms.Button();
            this.ByteCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip_File
            // 
            this.ToolStrip_File.Name = "ToolStrip_File";
            this.ToolStrip_File.Size = new System.Drawing.Size(37, 20);
            this.ToolStrip_File.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 20);
            this.Help.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_File,
            this.toolsToolStripMenuItem,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 449);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.AddressBox);
            this.tabPage1.Controls.Add(this.Save);
            this.tabPage1.Controls.Add(this.CategoryBox);
            this.tabPage1.Controls.Add(this.Remove);
            this.tabPage1.Controls.Add(this.Bytes);
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Controls.Add(this.Reset);
            this.tabPage1.Controls.Add(this.BytesUsed);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Description);
            this.tabPage1.Controls.Add(this.Types);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.Label0);
            this.tabPage1.Controls.Add(this.Usage);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.CommandBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(722, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Script Builder";
            // 
            // AddressBox
            // 
            this.AddressBox.FormattingEnabled = true;
            this.AddressBox.Items.AddRange(new object[] {
            "000000",
            "1E81F9",
            "1E81F9",
            "1E8163",
            "1E818F"});
            this.AddressBox.Location = new System.Drawing.Point(526, 32);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(121, 21);
            this.AddressBox.TabIndex = 36;
            this.AddressBox.Text = "Pointer";
            this.AddressBox.SelectedValueChanged += new System.EventHandler(this.PointerValue);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(611, 369);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 35;
            this.Save.Text = "Save Script";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "All",
            "Generic",
            "Add",
            "Give",
            "Remove",
            "Query",
            "Movement",
            "Other"});
            this.CategoryBox.Location = new System.Drawing.Point(505, 118);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(87, 21);
            this.CategoryBox.TabIndex = 1;
            this.CategoryBox.Text = "Generic";
            this.CategoryBox.SelectedValueChanged += new System.EventHandler(this.CmdCat_Value);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(598, 174);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 31;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Bytes
            // 
            this.Bytes.AutoSize = true;
            this.Bytes.Location = new System.Drawing.Point(358, 129);
            this.Bytes.Name = "Bytes";
            this.Bytes.Size = new System.Drawing.Size(100, 13);
            this.Bytes.TabIndex = 17;
            this.Bytes.Text = "No. of Bytes: 0/999";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(29, 123);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(439, 277);
            this.tabControl3.TabIndex = 29;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ScriptTextOutput);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(431, 251);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Text";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ScriptTextOutput
            // 
            this.ScriptTextOutput.FormattingEnabled = true;
            this.ScriptTextOutput.Items.AddRange(new object[] {
            "//---------------",
            "#org 0x000000"});
            this.ScriptTextOutput.Location = new System.Drawing.Point(-4, 0);
            this.ScriptTextOutput.Name = "ScriptTextOutput";
            this.ScriptTextOutput.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ScriptTextOutput.Size = new System.Drawing.Size(444, 251);
            this.ScriptTextOutput.TabIndex = 32;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.richTextBox2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(431, 251);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Hex";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(-4, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(435, 248);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "\n";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(598, 203);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 28;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // BytesUsed
            // 
            this.BytesUsed.AutoSize = true;
            this.BytesUsed.Location = new System.Drawing.Point(98, 35);
            this.BytesUsed.Name = "BytesUsed";
            this.BytesUsed.Size = new System.Drawing.Size(13, 13);
            this.BytesUsed.TabIndex = 27;
            this.BytesUsed.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bytes Used:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "How To Use:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(98, 85);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(13, 13);
            this.Description.TabIndex = 22;
            this.Description.Text = "0";
            // 
            // Types
            // 
            this.Types.AutoSize = true;
            this.Types.Location = new System.Drawing.Point(67, 59);
            this.Types.Name = "Types";
            this.Types.Size = new System.Drawing.Size(13, 13);
            this.Types.TabIndex = 25;
            this.Types.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(26, 59);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Types:";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.Location = new System.Drawing.Point(27, 85);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(75, 13);
            this.Label0.TabIndex = 20;
            this.Label0.Text = "Description:";
            // 
            // Usage
            // 
            this.Usage.AutoSize = true;
            this.Usage.Location = new System.Drawing.Point(106, 15);
            this.Usage.Name = "Usage";
            this.Usage.Size = new System.Drawing.Size(13, 13);
            this.Usage.TabIndex = 23;
            this.Usage.Text = "0";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(598, 145);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_click);
            // 
            // CommandBox
            // 
            this.CommandBox.FormattingEnabled = true;
            this.CommandBox.Items.AddRange(new object[] {
            "nop",
            "nop1",
            "call",
            "goto",
            "msgbox",
            "sound",
            "fanfare",
            "playsong",
            "cry",
            "sethealingplace"});
            this.CommandBox.Location = new System.Drawing.Point(505, 145);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(87, 251);
            this.CommandBox.TabIndex = 18;
            this.CommandBox.SelectedValueChanged += new System.EventHandler(this.CmdBox_value);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.ByteCount);
            this.tabPage2.Controls.Add(this.ByteSum);
            this.tabPage2.Controls.Add(this.Textoffset);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(722, 423);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Text/Hex";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox4.Font = new System.Drawing.Font("Courier New", 9F);
            this.richTextBox4.Location = new System.Drawing.Point(4, 42);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(106, 348);
            this.richTextBox4.TabIndex = 5;
            this.richTextBox4.Text = "";
            // 
            // ByteSum
            // 
            this.ByteSum.AutoSize = true;
            this.ByteSum.Location = new System.Drawing.Point(668, 46);
            this.ByteSum.Name = "ByteSum";
            this.ByteSum.Size = new System.Drawing.Size(51, 13);
            this.ByteSum.TabIndex = 3;
            this.ByteSum.Text = "= 0 Bytes";
            // 
            // Textoffset
            // 
            this.Textoffset.FormattingEnabled = true;
            this.Textoffset.Items.AddRange(new object[] {
            "1E81F9",
            "1E8163",
            "1E818F",
            "1E8211",
            "1E8297",
            "1E82A2",
            "1E8281",
            "1E828C",
            "1E82AD",
            "1E82F0",
            "1E8693",
            "1E8405",
            "1E8448",
            "1E8686",
            "1E8333",
            "1E8348",
            "1E835D",
            "1E8372",
            "1E8387",
            "1E839C",
            "1E83B1",
            "1E83C6",
            "1E83DB",
            "1E83F0",
            "1E848B",
            "1E8496",
            "1E84A1",
            "1E84C7",
            "1E84ED",
            "1E8513",
            "1E8539",
            "1E855F",
            "1E8585",
            "1E85AB"});
            this.Textoffset.Location = new System.Drawing.Point(541, 43);
            this.Textoffset.Name = "Textoffset";
            this.Textoffset.Size = new System.Drawing.Size(121, 21);
            this.Textoffset.TabIndex = 2;
            this.Textoffset.Text = "0x00000";
            this.Textoffset.SelectedValueChanged += new System.EventHandler(this.Textoff_Value);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(109, 18);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(434, 379);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 353);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(3, 3);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(420, 347);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(426, 353);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Hex";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 347);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ScriptTextOutput2);
            this.tabPage5.Controls.Add(this.TextBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(722, 423);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Hex Viewer";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ScriptTextOutput2
            // 
            this.ScriptTextOutput2.Location = new System.Drawing.Point(122, 18);
            this.ScriptTextOutput2.Name = "ScriptTextOutput2";
            this.ScriptTextOutput2.Size = new System.Drawing.Size(211, 248);
            this.ScriptTextOutput2.TabIndex = 17;
            this.ScriptTextOutput2.Text = "";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(16, 18);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 96);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.richTextBox3);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.Forgottennumbers);
            this.tabPage8.Controls.Add(this.name1);
            this.tabPage8.Controls.Add(this.arg4);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.arg3);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.arg2);
            this.tabPage8.Controls.Add(this.label13);
            this.tabPage8.Controls.Add(this.arg1);
            this.tabPage8.Controls.Add(this.label12);
            this.tabPage8.Controls.Add(this.type1);
            this.tabPage8.Controls.Add(this.label11);
            this.tabPage8.Controls.Add(this.usage1);
            this.tabPage8.Controls.Add(this.bytes1);
            this.tabPage8.Controls.Add(this.desc1);
            this.tabPage8.Controls.Add(this.label10);
            this.tabPage8.Controls.Add(this.label9);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.SaveINI);
            this.tabPage8.Controls.Add(this.LoadINI);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(722, 423);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Test Stuff";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(37, 227);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(240, 96);
            this.richTextBox3.TabIndex = 40;
            this.richTextBox3.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "0";
            this.label16.Visible = false;
            // 
            // Forgottennumbers
            // 
            this.Forgottennumbers.FormattingEnabled = true;
            this.Forgottennumbers.Location = new System.Drawing.Point(19, 63);
            this.Forgottennumbers.Name = "Forgottennumbers";
            this.Forgottennumbers.Size = new System.Drawing.Size(66, 56);
            this.Forgottennumbers.TabIndex = 38;
            this.Forgottennumbers.Visible = false;
            // 
            // name1
            // 
            this.name1.FormattingEnabled = true;
            this.name1.Items.AddRange(new object[] {
            "nop",
            "nop1",
            "call",
            "msgbox",
            "callstd",
            "callasm",
            "special",
            "special2",
            "goto",
            "gotostd",
            "checkgender",
            "compare",
            "if1",
            "gotostdif",
            "if2",
            "callstdif",
            "setflag",
            "clearflag",
            "checkflag",
            "checkdailyflags",
            "resetvars",
            "countpokemon",
            "checkcoins",
            "showcoins",
            "hidecoins",
            "updatecoins",
            "givecoins",
            "removecoins",
            "setwildbattle",
            "dowildbattle",
            "wildbattle",
            "wildbattle2",
            "setvirtualaddress",
            "virtualgoto",
            "virtualcall",
            "virtualgotoif",
            "virtualcallif",
            "virtualmsgbox",
            "virtualloadpointer",
            "virtualbuffer",
            "additem",
            "removeitem",
            "giveitem",
            "giveitem2",
            "giveitem3",
            "checkitemroom",
            "checkitem",
            "checkitemtype",
            "addpcitem",
            "checkpcitem",
            "bufferitems",
            "bufferitems2",
            "givepokemon",
            "giveegg",
            "setpkmnpp",
            "checkattack",
            "bufferpokemon",
            "bufferfirstpokemon",
            "bufferitem",
            "bufferdecoration",
            "bufferattack",
            "buffernumber",
            "bufferstd",
            "bufferpublic string",
            "pokemart",
            "pokemart2",
            "pokemart3",
            "pokecasino",
            "choosecontestpkmn",
            "startcontest",
            "showcontestresults",
            "contestlinktransfer",
            "buffercontestype",
            "random",
            "givemoney",
            "paymoney",
            "checkmoney",
            "showmoney",
            "hidemoney",
            "updatemoney",
            "fadescreen",
            "fadescreen3",
            "fadescreendelay",
            "darken",
            "lighten",
            "setdooropened",
            "setdooropened2",
            "setdoorclosed",
            "setdoorclosed2",
            "doorchange",
            "setdooropened2",
            "adddecoration",
            "removedecoration",
            "testdecoration",
            "checkdecoration",
            "jumpram",
            "executeram",
            "killscript",
            "setvar",
            "addvar",
            "subvar",
            "copyvar",
            "copyvarifnotzero",
            "comparebanks",
            "comparebanktobyte",
            "comparebanktofarbyte",
            "comparefarbytetobank",
            "comparefarbytetobyte",
            "comparefarbytes",
            "comparevars",
            "setworldmapflag",
            "sound",
            "checksound",
            "fanfare",
            "waitfanfare",
            "playsong",
            "playsong2",
            "fadedefault",
            "fadesong",
            "fadeout",
            "fadein",
            "cry",
            "waitcry",
            "bufferboxname",
            "textcolor",
            "showbox",
            "hidebox",
            "hidebox2",
            "clearbox",
            "showpokepic",
            "hidepokepic",
            "showcontestwinner",
            "braille",
            "signmsg",
            "normalmsg",
            "msgbox",
            "preparemsg",
            "waitmsg",
            "closeonkeypress",
            "waitkeypress",
            "yesnobox",
            "multichoice",
            "multichoice2",
            "multichoice3",
            "pokenavcall",
            "registernav",
            "sethealingplace",
            "setcatchlocation",
            "applymovement",
            "applymovementpos",
            "spritebehave",
            "waitmovement",
            "waitmovementpos",
            "setanimation",
            "doanimation",
            "checkanimation",
            "hidesprite",
            "hidespritepos",
            "showsprite",
            "showspritepos",
            "movesprite",
            "movesprite2",
            "moveoffscreen",
            "spritevisible",
            "spriteinvisible",
            "faceplayer",
            "spriteface",
            "spritelevelup",
            "restorespritelevel",
            "createsprite",
            "spriteface2",
            "trainerbattle",
            "repeatetrainerbattle",
            "endtrainerbattle",
            "endtrainerbattle2",
            "checktrainerflag",
            "cleartrainerflag",
            "settrainerflag",
            "buffertrainerclass",
            "buffertrainername",
            "lock",
            "lockall",
            "release",
            "releaseall",
            "waitstate",
            "pause",
            "setmaptile",
            "doweather",
            "setweather",
            "resetweather",
            "setmapfooter",
            "warp",
            "warpmuted",
            "warpwalk",
            "warphole",
            "warpteleport",
            "warpteleport2",
            "warp3",
            "setwarpplace",
            "warp4",
            "warp5",
            "warp6",
            "getplayerpos",
            "end",
            "return",
            "setbyte",
            "setbyte2",
            "setfarbyte",
            "copybyte",
            "writebytetooffset",
            "loadbytefrompointer",
            "loadpointer",
            "copyscriptbanks",
            "comparehiddenvar",
            "setobedience",
            "checkobedience",
            "cmd24",
            "cmd2c",
            "cmd8a",
            "cmd96",
            "cmda6",
            "cmdb1",
            "cmdb2",
            "cmdc3",
            "cmdc8",
            "cmdc9",
            "cmdd5",
            "cmdd6",
            "cmdd8",
            "cmdd9",
            "braille2",
            "preparemsg2",
            "preparemsg3",
            "warp7",
            "warp8"});
            this.name1.Location = new System.Drawing.Point(404, 39);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(121, 21);
            this.name1.TabIndex = 25;
            this.name1.SelectedValueChanged += new System.EventHandler(this.Cmd_Name);
            // 
            // arg4
            // 
            this.arg4.Location = new System.Drawing.Point(558, 227);
            this.arg4.Name = "arg4";
            this.arg4.Size = new System.Drawing.Size(100, 20);
            this.arg4.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Argument 4";
            // 
            // arg3
            // 
            this.arg3.Location = new System.Drawing.Point(416, 227);
            this.arg3.Name = "arg3";
            this.arg3.Size = new System.Drawing.Size(100, 20);
            this.arg3.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(416, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Argument 3";
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(558, 176);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(100, 20);
            this.arg2.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Argument 2";
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(416, 176);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(100, 20);
            this.arg1.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Argument 1";
            // 
            // type1
            // 
            this.type1.Location = new System.Drawing.Point(558, 99);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(100, 20);
            this.type1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(558, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Type:";
            // 
            // usage1
            // 
            this.usage1.Location = new System.Drawing.Point(413, 99);
            this.usage1.Name = "usage1";
            this.usage1.Size = new System.Drawing.Size(100, 20);
            this.usage1.TabIndex = 3;
            // 
            // bytes1
            // 
            this.bytes1.Location = new System.Drawing.Point(558, 39);
            this.bytes1.Name = "bytes1";
            this.bytes1.Size = new System.Drawing.Size(100, 20);
            this.bytes1.TabIndex = 2;
            // 
            // desc1
            // 
            this.desc1.Location = new System.Drawing.Point(347, 292);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(311, 96);
            this.desc1.TabIndex = 4;
            this.desc1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bytes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Usage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "test";
            // 
            // SaveINI
            // 
            this.SaveINI.Location = new System.Drawing.Point(583, 394);
            this.SaveINI.Name = "SaveINI";
            this.SaveINI.Size = new System.Drawing.Size(75, 23);
            this.SaveINI.TabIndex = 2;
            this.SaveINI.Text = "Save INI";
            this.SaveINI.UseVisualStyleBackColor = true;
            this.SaveINI.Click += new System.EventHandler(this.SaveINI_Click);
            // 
            // LoadINI
            // 
            this.LoadINI.Location = new System.Drawing.Point(19, 394);
            this.LoadINI.Name = "LoadINI";
            this.LoadINI.Size = new System.Drawing.Size(75, 23);
            this.LoadINI.TabIndex = 1;
            this.LoadINI.Text = "Load INI";
            this.LoadINI.UseVisualStyleBackColor = true;
            // 
            // ByteCount
            // 
            this.ByteCount.AutoSize = true;
            this.ByteCount.Location = new System.Drawing.Point(585, 91);
            this.ByteCount.Name = "ByteCount";
            this.ByteCount.Size = new System.Drawing.Size(77, 13);
            this.ByteCount.TabIndex = 4;
            this.ByteCount.Text = "Byte Count = 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriptWriter";
            this.Load += new System.EventHandler(this.Default);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            #region Items
            private System.Windows.Forms.ToolStripMenuItem ToolStrip_File;
            private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem Help;
            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.TabControl tabControl1;
            private System.Windows.Forms.TabPage tabPage1;
            private System.Windows.Forms.Button Reset;
            private System.Windows.Forms.Button Add;
            private System.Windows.Forms.TabPage tabPage2;
            private System.Windows.Forms.RichTextBox TextBox;
            private System.Windows.Forms.ComboBox Textoffset;
            private System.Windows.Forms.TabControl tabControl2;
            private System.Windows.Forms.TabPage tabPage3;
            private System.Windows.Forms.TabPage tabPage4;
            private System.Windows.Forms.RichTextBox richTextBox1;
            private System.Windows.Forms.TabPage tabPage5;
            private System.Windows.Forms.TabControl tabControl3;
            private System.Windows.Forms.TabPage tabPage6;
            private System.Windows.Forms.TabPage tabPage7;
            private System.Windows.Forms.RichTextBox richTextBox2;
            public System.Windows.Forms.RichTextBox TextBox1;
            public System.Windows.Forms.ListBox CommandBox;
            private System.Windows.Forms.Label ByteSum;
            public System.Windows.Forms.Label BytesUsed;
            public System.Windows.Forms.Label Bytes;
            private System.Windows.Forms.Button Remove;
            public System.Windows.Forms.RichTextBox ScriptTextOutput2;
            private System.Windows.Forms.TabPage tabPage8;
            private System.Windows.Forms.ComboBox CategoryBox;
            private System.Windows.Forms.Button Save;
            private System.Windows.Forms.ComboBox AddressBox;
            private System.Windows.Forms.Button LoadINI;
            private System.Windows.Forms.Button SaveINI;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox type1;
            private System.Windows.Forms.Label label11;
            private System.Windows.Forms.TextBox usage1;
            private System.Windows.Forms.TextBox bytes1;
            private System.Windows.Forms.RichTextBox desc1;
            private System.Windows.Forms.Label label10;
            private System.Windows.Forms.Label label9;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.Label label7;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.TextBox arg4;
            private System.Windows.Forms.Label label14;
            private System.Windows.Forms.TextBox arg3;
            private System.Windows.Forms.Label label15;
            private System.Windows.Forms.TextBox arg2;
            private System.Windows.Forms.Label label13;
            private System.Windows.Forms.TextBox arg1;
            private System.Windows.Forms.Label label12;
            private System.Windows.Forms.ComboBox name1;
            public System.Windows.Forms.ListBox ScriptTextOutput;
            public System.Windows.Forms.Label label16;
            public System.Windows.Forms.ListBox Forgottennumbers;









            #endregion

            public Label label2;
            public Label label1;
            public Label Description;
            public Label Types;
            public Label Label3;
            public Label Label0;
            private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Label ByteCount;
        public Label Usage;


    }

    partial class Main : Form
    #region Main Form

    {
        public Main()
        {
            InitializeComponent();

        }
        #endregion


        #region Default public strings
        public void Default(object sender, EventArgs e)
        {
            Default_Stuff();
        }
        #endregion






    }
}









