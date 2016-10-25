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
            this.t_displayText = new System.Windows.Forms.TextBox();
            this.b_loadAllData = new System.Windows.Forms.Button();
            this.b_loadSomeData = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // t_displayText
            // 
            this.t_displayText.Location = new System.Drawing.Point(31, 76);
            this.t_displayText.Multiline = true;
            this.t_displayText.Name = "t_displayText";
            this.t_displayText.Size = new System.Drawing.Size(454, 266);
            this.t_displayText.TabIndex = 0;
            this.t_displayText.TextChanged += new System.EventHandler(this.t_displayText_TextChanged);
            // 
            // b_loadAllData
            // 
            this.b_loadAllData.Location = new System.Drawing.Point(31, 33);
            this.b_loadAllData.Name = "b_loadAllData";
            this.b_loadAllData.Size = new System.Drawing.Size(83, 23);
            this.b_loadAllData.TabIndex = 1;
            this.b_loadAllData.Text = "Load All Data";
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(299, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(418, 36);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.b_loadSomeData);
            this.Controls.Add(this.b_loadAllData);
            this.Controls.Add(this.t_displayText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_displayText;
        private System.Windows.Forms.Button b_loadAllData;
        private System.Windows.Forms.Button b_loadSomeData;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

