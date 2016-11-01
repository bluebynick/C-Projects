namespace WindowsFormsApplication1
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
            this.lbox_NotPresent = new System.Windows.Forms.ListBox();
            this.lbox_Present = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.t_fileName = new System.Windows.Forms.ToolStripTextBox();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_NotPresent
            // 
            this.lbox_NotPresent.FormattingEnabled = true;
            this.lbox_NotPresent.Location = new System.Drawing.Point(31, 75);
            this.lbox_NotPresent.Name = "lbox_NotPresent";
            this.lbox_NotPresent.Size = new System.Drawing.Size(201, 238);
            this.lbox_NotPresent.TabIndex = 9;
            this.lbox_NotPresent.SelectedIndexChanged += new System.EventHandler(this.lbox_NotPresent_SelectedIndexChanged);
            // 
            // lbox_Present
            // 
            this.lbox_Present.FormattingEnabled = true;
            this.lbox_Present.Location = new System.Drawing.Point(284, 75);
            this.lbox_Present.Name = "lbox_Present";
            this.lbox_Present.Size = new System.Drawing.Size(201, 238);
            this.lbox_Present.TabIndex = 10;
            this.lbox_Present.SelectedIndexChanged += new System.EventHandler(this.lbox_Present_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.writeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_fileName});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "Change File";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // t_fileName
            // 
            this.t_fileName.Name = "t_fileName";
            this.t_fileName.Size = new System.Drawing.Size(100, 23);
            this.t_fileName.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToFileToolStripMenuItem,
            this.eraseFileToolStripMenuItem1});
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // writeToFileToolStripMenuItem
            // 
            this.writeToFileToolStripMenuItem.Name = "writeToFileToolStripMenuItem";
            this.writeToFileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.writeToFileToolStripMenuItem.Text = "Write To File";
            this.writeToFileToolStripMenuItem.Click += new System.EventHandler(this.writeToFileToolStripMenuItem_Click);
            // 
            // eraseFileToolStripMenuItem1
            // 
            this.eraseFileToolStripMenuItem1.Name = "eraseFileToolStripMenuItem1";
            this.eraseFileToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.eraseFileToolStripMenuItem1.Text = "Erase File ";
            this.eraseFileToolStripMenuItem1.Click += new System.EventHandler(this.eraseFileToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.lbox_Present);
            this.Controls.Add(this.lbox_NotPresent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbox_NotPresent;
        private System.Windows.Forms.ListBox lbox_Present;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox t_fileName;
    }
}

