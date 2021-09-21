
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.BrowseGameDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGameDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGame = new System.Windows.Forms.FolderBrowserDialog();
            this.tabVpack = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExtraParams = new System.Windows.Forms.TextBox();
            this.textBoxCNBounds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCSize = new System.Windows.Forms.TextBox();
            this.checkBoxMultichunk = new System.Windows.Forms.CheckBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabVpack.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pack Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseGameDirectory
            // 
            this.BrowseGameDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseGameDirectory.Location = new System.Drawing.Point(492, 25);
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
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "VPK Game Directory";
            // 
            // textBoxGameDirectory
            // 
            this.textBoxGameDirectory.Location = new System.Drawing.Point(204, 27);
            this.textBoxGameDirectory.Name = "textBoxGameDirectory";
            this.textBoxGameDirectory.Size = new System.Drawing.Size(282, 20);
            this.textBoxGameDirectory.TabIndex = 4;
            this.textBoxGameDirectory.TextChanged += new System.EventHandler(this.textBoxGameDirectory_TextChanged);
            // 
            // tabVpack
            // 
            this.tabVpack.Controls.Add(this.tabPage1);
            this.tabVpack.Controls.Add(this.tabPage2);
            this.tabVpack.Location = new System.Drawing.Point(12, 12);
            this.tabVpack.Name = "tabVpack";
            this.tabVpack.SelectedIndex = 0;
            this.tabVpack.Size = new System.Drawing.Size(611, 426);
            this.tabVpack.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxExtraParams);
            this.tabPage1.Controls.Add(this.textBoxCNBounds);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxCSize);
            this.tabPage1.Controls.Add(this.checkBoxMultichunk);
            this.tabPage1.Controls.Add(this.richTextBoxLog);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BrowseGameDirectory);
            this.tabPage1.Controls.Add(this.textBoxGameDirectory);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aditional parameters";
            // 
            // textBoxExtraParams
            // 
            this.textBoxExtraParams.Location = new System.Drawing.Point(302, 278);
            this.textBoxExtraParams.Name = "textBoxExtraParams";
            this.textBoxExtraParams.Size = new System.Drawing.Size(280, 20);
            this.textBoxExtraParams.TabIndex = 11;
            // 
            // textBoxCNBounds
            // 
            this.textBoxCNBounds.Location = new System.Drawing.Point(194, 278);
            this.textBoxCNBounds.Name = "textBoxCNBounds";
            this.textBoxCNBounds.Size = new System.Drawing.Size(36, 20);
            this.textBoxCNBounds.TabIndex = 10;
            this.textBoxCNBounds.TextChanged += new System.EventHandler(this.textBoxCNBounds_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chunk n-byte bounds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ChunkSize";
            // 
            // textBoxCSize
            // 
            this.textBoxCSize.Location = new System.Drawing.Point(110, 278);
            this.textBoxCSize.Name = "textBoxCSize";
            this.textBoxCSize.Size = new System.Drawing.Size(33, 20);
            this.textBoxCSize.TabIndex = 7;
            this.textBoxCSize.TextChanged += new System.EventHandler(this.textBoxCSize_TextChanged);
            // 
            // checkBoxMultichunk
            // 
            this.checkBoxMultichunk.AutoSize = true;
            this.checkBoxMultichunk.Checked = true;
            this.checkBoxMultichunk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMultichunk.Location = new System.Drawing.Point(26, 262);
            this.checkBoxMultichunk.Name = "checkBoxMultichunk";
            this.checkBoxMultichunk.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMultichunk.TabIndex = 6;
            this.checkBoxMultichunk.Text = "Multichunk";
            this.checkBoxMultichunk.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(11, 301);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(571, 96);
            this.richTextBoxLog.TabIndex = 5;
            this.richTextBoxLog.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.versionlabel);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created by Anthonypython";
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
            this.richTextBox1.Location = new System.Drawing.Point(302, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 322);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.tabVpack);
            this.Name = "Form1";
            this.Text = "Vpacker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabVpack.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

