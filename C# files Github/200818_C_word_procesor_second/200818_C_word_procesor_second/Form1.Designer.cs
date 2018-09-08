namespace _200818_C_word_procesor_second
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.strFile = new System.Windows.Forms.ToolStripMenuItem();
            this.strOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.strSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strText = new System.Windows.Forms.ToolStripMenuItem();
            this.strCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.strPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.strUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.strClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.strBold = new System.Windows.Forms.ToolStripMenuItem();
            this.strItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.strBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.strDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.richAlltext = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strFile,
            this.strText});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // strFile
            // 
            this.strFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strOpen,
            this.strSaveAs,
            this.saveToolStripMenuItem});
            this.strFile.Name = "strFile";
            this.strFile.Size = new System.Drawing.Size(37, 20);
            this.strFile.Text = "File";
            this.strFile.Click += new System.EventHandler(this.strFile_Click);
            // 
            // strOpen
            // 
            this.strOpen.Name = "strOpen";
            this.strOpen.Size = new System.Drawing.Size(112, 22);
            this.strOpen.Text = "Open";
            this.strOpen.Click += new System.EventHandler(this.strOpen_Click);
            // 
            // strSaveAs
            // 
            this.strSaveAs.Name = "strSaveAs";
            this.strSaveAs.Size = new System.Drawing.Size(112, 22);
            this.strSaveAs.Text = "Save as";
            this.strSaveAs.Click += new System.EventHandler(this.strSaveAs_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // strText
            // 
            this.strText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strCopy,
            this.strPaste,
            this.strUndo,
            this.strClear});
            this.strText.Name = "strText";
            this.strText.Size = new System.Drawing.Size(41, 20);
            this.strText.Text = "Text";
            // 
            // strCopy
            // 
            this.strCopy.Name = "strCopy";
            this.strCopy.Size = new System.Drawing.Size(102, 22);
            this.strCopy.Text = "copy";
            this.strCopy.Click += new System.EventHandler(this.strCopy_Click);
            // 
            // strPaste
            // 
            this.strPaste.Name = "strPaste";
            this.strPaste.Size = new System.Drawing.Size(102, 22);
            this.strPaste.Text = "paste";
            this.strPaste.Click += new System.EventHandler(this.strPaste_Click);
            // 
            // strUndo
            // 
            this.strUndo.Name = "strUndo";
            this.strUndo.Size = new System.Drawing.Size(102, 22);
            this.strUndo.Text = "undo";
            this.strUndo.Click += new System.EventHandler(this.strUndo_Click);
            // 
            // strClear
            // 
            this.strClear.Name = "strClear";
            this.strClear.Size = new System.Drawing.Size(102, 22);
            this.strClear.Text = "clear";
            this.strClear.Click += new System.EventHandler(this.strClear_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strBold,
            this.strItalic,
            this.strBlue,
            this.textToolStripMenuItem1,
            this.strDefault});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // strBold
            // 
            this.strBold.Name = "strBold";
            this.strBold.Size = new System.Drawing.Size(43, 20);
            this.strBold.Text = "bold";
            this.strBold.Click += new System.EventHandler(this.strBold_Click);
            // 
            // strItalic
            // 
            this.strItalic.Name = "strItalic";
            this.strItalic.Size = new System.Drawing.Size(44, 20);
            this.strItalic.Text = "italic";
            this.strItalic.Click += new System.EventHandler(this.strItalic_Click);
            // 
            // strBlue
            // 
            this.strBlue.Name = "strBlue";
            this.strBlue.Size = new System.Drawing.Size(42, 20);
            this.strBlue.Text = "blue";
            this.strBlue.Click += new System.EventHandler(this.strBlue_Click);
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.textToolStripMenuItem1.Text = "text";
            this.textToolStripMenuItem1.Click += new System.EventHandler(this.textToolStripMenuItem1_Click);
            // 
            // strDefault
            // 
            this.strDefault.Name = "strDefault";
            this.strDefault.Size = new System.Drawing.Size(56, 20);
            this.strDefault.Text = "default";
            this.strDefault.Click += new System.EventHandler(this.strDefault_Click);
            // 
            // richAlltext
            // 
            this.richAlltext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richAlltext.Location = new System.Drawing.Point(0, 48);
            this.richAlltext.Name = "richAlltext";
            this.richAlltext.Size = new System.Drawing.Size(800, 402);
            this.richAlltext.TabIndex = 2;
            this.richAlltext.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richAlltext);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem strFile;
        private System.Windows.Forms.ToolStripMenuItem strOpen;
        private System.Windows.Forms.ToolStripMenuItem strSaveAs;
        private System.Windows.Forms.ToolStripMenuItem strText;
        private System.Windows.Forms.ToolStripMenuItem strCopy;
        private System.Windows.Forms.ToolStripMenuItem strPaste;
        private System.Windows.Forms.ToolStripMenuItem strUndo;
        private System.Windows.Forms.ToolStripMenuItem strClear;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem strBold;
        private System.Windows.Forms.ToolStripMenuItem strItalic;
        private System.Windows.Forms.ToolStripMenuItem strBlue;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem strDefault;
        private System.Windows.Forms.RichTextBox richAlltext;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

