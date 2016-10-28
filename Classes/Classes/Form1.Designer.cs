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
            this.b_loadAllData = new System.Windows.Forms.Button();
            this.b_loadSomeData = new System.Windows.Forms.Button();
            this.n_start = new System.Windows.Forms.NumericUpDown();
            this.n_end = new System.Windows.Forms.NumericUpDown();
            this.l_start = new System.Windows.Forms.Label();
            this.l_end = new System.Windows.Forms.Label();
            this.b_write = new System.Windows.Forms.Button();
            this.b_eraseFile = new System.Windows.Forms.Button();
            this.lbox_NotPresent = new System.Windows.Forms.ListBox();
            this.lbox_Present = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.n_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_end)).BeginInit();
            this.SuspendLayout();
            // 
            // b_loadAllData
            // 
            this.b_loadAllData.Location = new System.Drawing.Point(31, 33);
            this.b_loadAllData.Name = "b_loadAllData";
            this.b_loadAllData.Size = new System.Drawing.Size(83, 23);
            this.b_loadAllData.TabIndex = 1;
            this.b_loadAllData.Text = "Load Class";
            this.b_loadAllData.UseVisualStyleBackColor = true;
            this.b_loadAllData.Click += new System.EventHandler(this.b_loadData_Click);
            // 
            // b_loadSomeData
            // 
            this.b_loadSomeData.Location = new System.Drawing.Point(132, 33);
            this.b_loadSomeData.Name = "b_loadSomeData";
            this.b_loadSomeData.Size = new System.Drawing.Size(100, 23);
            this.b_loadSomeData.TabIndex = 2;
            this.b_loadSomeData.Text = "Load Some Data";
            this.b_loadSomeData.UseVisualStyleBackColor = true;
            this.b_loadSomeData.Click += new System.EventHandler(this.b_loadSomeData_Click);
            // 
            // n_start
            // 
            this.n_start.Location = new System.Drawing.Point(299, 36);
            this.n_start.Name = "n_start";
            this.n_start.Size = new System.Drawing.Size(67, 20);
            this.n_start.TabIndex = 3;
            this.n_start.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // n_end
            // 
            this.n_end.Location = new System.Drawing.Point(418, 36);
            this.n_end.Name = "n_end";
            this.n_end.Size = new System.Drawing.Size(67, 20);
            this.n_end.TabIndex = 4;
            this.n_end.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // l_start
            // 
            this.l_start.AutoSize = true;
            this.l_start.Location = new System.Drawing.Point(252, 38);
            this.l_start.Name = "l_start";
            this.l_start.Size = new System.Drawing.Size(29, 13);
            this.l_start.TabIndex = 5;
            this.l_start.Text = "Start";
            // 
            // l_end
            // 
            this.l_end.AutoSize = true;
            this.l_end.Location = new System.Drawing.Point(376, 38);
            this.l_end.Name = "l_end";
            this.l_end.Size = new System.Drawing.Size(26, 13);
            this.l_end.TabIndex = 6;
            this.l_end.Text = "End";
            // 
            // b_write
            // 
            this.b_write.Location = new System.Drawing.Point(157, 324);
            this.b_write.Name = "b_write";
            this.b_write.Size = new System.Drawing.Size(75, 23);
            this.b_write.TabIndex = 7;
            this.b_write.Text = "Write to File";
            this.b_write.UseVisualStyleBackColor = true;
            this.b_write.Click += new System.EventHandler(this.b_write_Click);
            // 
            // b_eraseFile
            // 
            this.b_eraseFile.Location = new System.Drawing.Point(255, 324);
            this.b_eraseFile.Name = "b_eraseFile";
            this.b_eraseFile.Size = new System.Drawing.Size(75, 23);
            this.b_eraseFile.TabIndex = 8;
            this.b_eraseFile.Text = "Erase File";
            this.b_eraseFile.UseVisualStyleBackColor = true;
            this.b_eraseFile.Click += new System.EventHandler(this.b_eraseFile_Click);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.lbox_Present);
            this.Controls.Add(this.lbox_NotPresent);
            this.Controls.Add(this.b_eraseFile);
            this.Controls.Add(this.b_write);
            this.Controls.Add(this.l_end);
            this.Controls.Add(this.l_start);
            this.Controls.Add(this.n_end);
            this.Controls.Add(this.n_start);
            this.Controls.Add(this.b_loadSomeData);
            this.Controls.Add(this.b_loadAllData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_loadAllData;
        private System.Windows.Forms.Button b_loadSomeData;
        private System.Windows.Forms.NumericUpDown n_start;
        private System.Windows.Forms.NumericUpDown n_end;
        private System.Windows.Forms.Label l_start;
        private System.Windows.Forms.Label l_end;
        private System.Windows.Forms.Button b_write;
        private System.Windows.Forms.Button b_eraseFile;
        private System.Windows.Forms.ListBox lbox_NotPresent;
        private System.Windows.Forms.ListBox lbox_Present;
    }
}

