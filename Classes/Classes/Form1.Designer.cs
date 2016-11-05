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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t_fileName = new System.Windows.Forms.ToolStripTextBox();
            this.clearFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.l_CurrentVoter = new System.Windows.Forms.Label();
            this.lbox_Voter = new System.Windows.Forms.ListBox();
            this.b_TeamMaker = new System.Windows.Forms.Button();
            this.b_Voting = new System.Windows.Forms.Button();
            this.lbox_Students = new System.Windows.Forms.ListBox();
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
            this.fileToolStripMenuItem,
            this.writeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.clearFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_fileName});
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadFileToolStripMenuItem.Text = "Load File To Box";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // t_fileName
            // 
            this.t_fileName.Name = "t_fileName";
            this.t_fileName.Size = new System.Drawing.Size(100, 23);
            this.t_fileName.Click += new System.EventHandler(this.t_fileName_Click);
            // 
            // clearFileToolStripMenuItem
            // 
            this.clearFileToolStripMenuItem.Name = "clearFileToolStripMenuItem";
            this.clearFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearFileToolStripMenuItem.Text = "Clear Box";
            this.clearFileToolStripMenuItem.Click += new System.EventHandler(this.clearFileToolStripMenuItem_Click);
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
            // l_CurrentVoter
            // 
            this.l_CurrentVoter.AutoSize = true;
            this.l_CurrentVoter.Location = new System.Drawing.Point(281, 39);
            this.l_CurrentVoter.Name = "l_CurrentVoter";
            this.l_CurrentVoter.Size = new System.Drawing.Size(69, 13);
            this.l_CurrentVoter.TabIndex = 13;
            this.l_CurrentVoter.Text = "Current Voter";
            this.l_CurrentVoter.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbox_Voter
            // 
            this.lbox_Voter.FormattingEnabled = true;
            this.lbox_Voter.Location = new System.Drawing.Point(365, 39);
            this.lbox_Voter.Name = "lbox_Voter";
            this.lbox_Voter.Size = new System.Drawing.Size(120, 17);
            this.lbox_Voter.TabIndex = 14;
            this.lbox_Voter.SelectedIndexChanged += new System.EventHandler(this.lbox_Voter_SelectedIndexChanged);
            // 
            // b_TeamMaker
            // 
            this.b_TeamMaker.Location = new System.Drawing.Point(421, 0);
            this.b_TeamMaker.Name = "b_TeamMaker";
            this.b_TeamMaker.Size = new System.Drawing.Size(75, 23);
            this.b_TeamMaker.TabIndex = 15;
            this.b_TeamMaker.Text = "Team Maker";
            this.b_TeamMaker.UseVisualStyleBackColor = true;
            this.b_TeamMaker.Click += new System.EventHandler(this.b_TeamMaker_Click);
            // 
            // b_Voting
            // 
            this.b_Voting.Location = new System.Drawing.Point(421, 0);
            this.b_Voting.Name = "b_Voting";
            this.b_Voting.Size = new System.Drawing.Size(75, 23);
            this.b_Voting.TabIndex = 16;
            this.b_Voting.Text = "Voting Screen";
            this.b_Voting.UseVisualStyleBackColor = true;
            this.b_Voting.Visible = false;
            this.b_Voting.Click += new System.EventHandler(this.b_Voting_Click);
            // 
            // lbox_Students
            // 
            this.lbox_Students.FormattingEnabled = true;
            this.lbox_Students.Location = new System.Drawing.Point(31, 75);
            this.lbox_Students.Name = "lbox_Students";
            this.lbox_Students.Size = new System.Drawing.Size(201, 238);
            this.lbox_Students.TabIndex = 17;
            this.lbox_Students.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.lbox_Students);
            this.Controls.Add(this.b_Voting);
            this.Controls.Add(this.b_TeamMaker);
            this.Controls.Add(this.lbox_Voter);
            this.Controls.Add(this.l_CurrentVoter);
            this.Controls.Add(this.lbox_Present);
            this.Controls.Add(this.lbox_NotPresent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nick\'s Interface";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbox_NotPresent;
        private System.Windows.Forms.ListBox lbox_Present;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseFileToolStripMenuItem1;
        private System.Windows.Forms.Label l_CurrentVoter;
        private System.Windows.Forms.ListBox lbox_Voter;
        private System.Windows.Forms.ToolStripTextBox t_fileName;
        private System.Windows.Forms.ToolStripMenuItem clearFileToolStripMenuItem;
        private System.Windows.Forms.Button b_TeamMaker;
        private System.Windows.Forms.Button b_Voting;
        private System.Windows.Forms.ListBox lbox_Students;
    }
}

