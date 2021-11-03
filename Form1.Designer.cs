
namespace Vpacker
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrowseGameDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGameDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGame = new System.Windows.Forms.FolderBrowserDialog();
            this.tabVpack = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.comboBox_Mods = new MaterialSkin.Controls.MaterialComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExtraParams = new System.Windows.Forms.TextBox();
            this.textBoxCNBounds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCSize = new System.Windows.Forms.TextBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_ClearBatchFolders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox_Folders = new System.Windows.Forms.RichTextBox();
            this.checkBoxMultichunk = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox_manualvpkpath = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox_VpkGame = new System.Windows.Forms.ComboBox();
            this.tabVpack.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseGameDirectory
            // 
            this.BrowseGameDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseGameDirectory.Location = new System.Drawing.Point(433, 30);
            this.BrowseGameDirectory.Name = "BrowseGameDirectory";
            this.BrowseGameDirectory.Size = new System.Drawing.Size(90, 23);
            this.BrowseGameDirectory.TabIndex = 2;
            this.BrowseGameDirectory.Text = "Browse";
            this.BrowseGameDirectory.UseVisualStyleBackColor = true;
            this.BrowseGameDirectory.Click += new System.EventHandler(this.BrowseGameDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "VPK Game";
            // 
            // textBoxGameDirectory
            // 
            this.textBoxGameDirectory.Location = new System.Drawing.Point(145, 31);
            this.textBoxGameDirectory.Name = "textBoxGameDirectory";
            this.textBoxGameDirectory.Size = new System.Drawing.Size(282, 20);
            this.textBoxGameDirectory.TabIndex = 4;
            this.textBoxGameDirectory.TextChanged += new System.EventHandler(this.textBoxGameDirectory_TextChanged);
            // 
            // tabVpack
            // 
            this.tabVpack.Controls.Add(this.tabPage1);
            this.tabVpack.Controls.Add(this.tabPage3);
            this.tabVpack.Controls.Add(this.tabPage4);
            this.tabVpack.Controls.Add(this.tabPage2);
            this.tabVpack.Location = new System.Drawing.Point(16, 77);
            this.tabVpack.Name = "tabVpack";
            this.tabVpack.SelectedIndex = 0;
            this.tabVpack.Size = new System.Drawing.Size(611, 373);
            this.tabVpack.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox_Mods);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxExtraParams);
            this.tabPage1.Controls.Add(this.textBoxCNBounds);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxCSize);
            this.tabPage1.Controls.Add(this.richTextBoxLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            // 
            // button1
            // 
            this.button1.AutoSize = false;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(198, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pack FIles";
            this.toolTip1.SetToolTip(this.button1, "Pack the mod folders/files into vpk\'s.");
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Mods
            // 
            this.comboBox_Mods.AutoResize = false;
            this.comboBox_Mods.BackColor = System.Drawing.Color.White;
            this.comboBox_Mods.Depth = 0;
            this.comboBox_Mods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Mods.DropDownHeight = 174;
            this.comboBox_Mods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mods.DropDownWidth = 121;
            this.comboBox_Mods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox_Mods.ForeColor = System.Drawing.Color.White;
            this.comboBox_Mods.FormattingEnabled = true;
            this.comboBox_Mods.IntegralHeight = false;
            this.comboBox_Mods.ItemHeight = 43;
            this.comboBox_Mods.Location = new System.Drawing.Point(175, 58);
            this.comboBox_Mods.MaxDropDownItems = 4;
            this.comboBox_Mods.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox_Mods.Name = "comboBox_Mods";
            this.comboBox_Mods.Size = new System.Drawing.Size(234, 49);
            this.comboBox_Mods.StartIndex = 0;
            this.comboBox_Mods.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Warning: Do not change  these unless you know what you are doing! You have been w" +
    "arned.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aditional parameters";
            // 
            // textBoxExtraParams
            // 
            this.textBoxExtraParams.Location = new System.Drawing.Point(286, 229);
            this.textBoxExtraParams.Name = "textBoxExtraParams";
            this.textBoxExtraParams.Size = new System.Drawing.Size(280, 20);
            this.textBoxExtraParams.TabIndex = 11;
            // 
            // textBoxCNBounds
            // 
            this.textBoxCNBounds.Enabled = false;
            this.textBoxCNBounds.Location = new System.Drawing.Point(160, 229);
            this.textBoxCNBounds.Name = "textBoxCNBounds";
            this.textBoxCNBounds.Size = new System.Drawing.Size(36, 20);
            this.textBoxCNBounds.TabIndex = 10;
            this.textBoxCNBounds.TextChanged += new System.EventHandler(this.textBoxCNBounds_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chunk n-byte Bounds";
            this.toolTip1.SetToolTip(this.label3, "Align the files within the vpk chunk on n-byte boundary.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chunk Size";
            this.toolTip1.SetToolTip(this.label2, "How big each vpk is in MB\'s.");
            // 
            // textBoxCSize
            // 
            this.textBoxCSize.Enabled = false;
            this.textBoxCSize.Location = new System.Drawing.Point(36, 229);
            this.textBoxCSize.Name = "textBoxCSize";
            this.textBoxCSize.Size = new System.Drawing.Size(33, 20);
            this.textBoxCSize.TabIndex = 7;
            this.textBoxCSize.TextChanged += new System.EventHandler(this.textBoxCSize_TextChanged);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(25, 256);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(541, 77);
            this.richTextBoxLog.TabIndex = 5;
            this.richTextBoxLog.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.Controls.Add(this.button_ClearBatchFolders);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.richTextBox_Folders);
            this.tabPage3.Controls.Add(this.checkBoxMultichunk);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(603, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Batch";
            this.tabPage3.ToolTipText = "pack single or multiple folders ";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage3_DragDrop);
            this.tabPage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage3_DragEnter);
            // 
            // button_ClearBatchFolders
            // 
            this.button_ClearBatchFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearBatchFolders.Location = new System.Drawing.Point(113, 297);
            this.button_ClearBatchFolders.Name = "button_ClearBatchFolders";
            this.button_ClearBatchFolders.Size = new System.Drawing.Size(119, 42);
            this.button_ClearBatchFolders.TabIndex = 2;
            this.button_ClearBatchFolders.Text = "Clear";
            this.button_ClearBatchFolders.UseVisualStyleBackColor = true;
            this.button_ClearBatchFolders.Click += new System.EventHandler(this.button_ClearBatchFolders_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(378, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox_Folders
            // 
            this.richTextBox_Folders.Location = new System.Drawing.Point(113, 24);
            this.richTextBox_Folders.Name = "richTextBox_Folders";
            this.richTextBox_Folders.ReadOnly = true;
            this.richTextBox_Folders.Size = new System.Drawing.Size(384, 216);
            this.richTextBox_Folders.TabIndex = 0;
            this.richTextBox_Folders.Text = "";
            // 
            // checkBoxMultichunk
            // 
            this.checkBoxMultichunk.AutoSize = true;
            this.checkBoxMultichunk.Checked = true;
            this.checkBoxMultichunk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMultichunk.Location = new System.Drawing.Point(266, 310);
            this.checkBoxMultichunk.Name = "checkBoxMultichunk";
            this.checkBoxMultichunk.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMultichunk.TabIndex = 6;
            this.checkBoxMultichunk.Text = "MultiChunk";
            this.toolTip1.SetToolTip(this.checkBoxMultichunk, "When Enabled creates multichunk vpk\'s like for a source mod.\r\nWhen off it behaves" +
        " as if you dragged the current folder onto vpk.exe.\r\nDo not turn off for very la" +
        "rge folders. it will fail.");
            this.checkBoxMultichunk.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox_manualvpkpath);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBoxGameDirectory);
            this.tabPage4.Controls.Add(this.BrowseGameDirectory);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(603, 347);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox_manualvpkpath
            // 
            this.checkBox_manualvpkpath.AutoSize = true;
            this.checkBox_manualvpkpath.Location = new System.Drawing.Point(11, 8);
            this.checkBox_manualvpkpath.Name = "checkBox_manualvpkpath";
            this.checkBox_manualvpkpath.Size = new System.Drawing.Size(107, 17);
            this.checkBox_manualvpkpath.TabIndex = 17;
            this.checkBox_manualvpkpath.Text = "Use vpk override";
            this.checkBox_manualvpkpath.UseVisualStyleBackColor = true;
            this.checkBox_manualvpkpath.CheckedChanged += new System.EventHandler(this.checkBox_manualvpkpath_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "VPK Override";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.versionlabel);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vpacker.Properties.Resources._2a1dcf881660409d387809d193fce61b;
            this.pictureBox2.Location = new System.Drawing.Point(127, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 92);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vpacker.Properties.Resources.Henyatsu_small;
            this.pictureBox1.Location = new System.Drawing.Point(9, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 59);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created by Anthonypython and Nbc66";
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionlabel.Location = new System.Drawing.Point(4, 72);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(107, 29);
            this.versionlabel.TabIndex = 2;
            this.versionlabel.Text = "Version: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(341, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(256, 333);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(480, 453);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(143, 36);
            this.button_Refresh.TabIndex = 16;
            this.button_Refresh.Text = "Refresh";
            this.toolTip1.SetToolTip(this.button_Refresh, "Refreshes steam library & Source Mod list");
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // comboBox_VpkGame
            // 
            this.comboBox_VpkGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VpkGame.FormattingEnabled = true;
            this.comboBox_VpkGame.Location = new System.Drawing.Point(163, 461);
            this.comboBox_VpkGame.Name = "comboBox_VpkGame";
            this.comboBox_VpkGame.Size = new System.Drawing.Size(282, 21);
            this.comboBox_VpkGame.TabIndex = 17;
            this.toolTip1.SetToolTip(this.comboBox_VpkGame, "Source Game to use for vpk.exe");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 497);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.comboBox_VpkGame);
            this.Controls.Add(this.tabVpack);
            this.Controls.Add(this.label1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vpacker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabVpack.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BrowseGameDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGameDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGame;
        private System.Windows.Forms.TabControl tabVpack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.CheckBox checkBoxMultichunk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExtraParams;
        private System.Windows.Forms.TextBox textBoxCNBounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox_Folders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_ClearBatchFolders;
        private System.Windows.Forms.ComboBox comboBox_VpkGame;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_manualvpkpath;
        private MaterialSkin.Controls.MaterialComboBox comboBox_Mods;
        private MaterialSkin.Controls.MaterialButton button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

