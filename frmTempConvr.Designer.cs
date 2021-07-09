namespace lab1_A
{
    partial class form1
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
            this.cnvrtF = new System.Windows.Forms.Button();
            this.cnvrtC = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.Converted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnvrtF
            // 
            this.cnvrtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnvrtF.Location = new System.Drawing.Point(68, 213);
            this.cnvrtF.Name = "cnvrtF";
            this.cnvrtF.Size = new System.Drawing.Size(204, 99);
            this.cnvrtF.TabIndex = 0;
            this.cnvrtF.Text = "Convert to Fahrenheit";
            this.cnvrtF.UseVisualStyleBackColor = true;
            this.cnvrtF.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnvrtC
            // 
            this.cnvrtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnvrtC.Location = new System.Drawing.Point(358, 213);
            this.cnvrtC.Name = "cnvrtC";
            this.cnvrtC.Size = new System.Drawing.Size(204, 99);
            this.cnvrtC.TabIndex = 1;
            this.cnvrtC.Text = "Convert to Celsius";
            this.cnvrtC.UseVisualStyleBackColor = true;
            this.cnvrtC.Click += new System.EventHandler(this.cnvrtC_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(371, 129);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(325, 20);
            this.input.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(650, 292);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(285, 20);
            this.output.TabIndex = 3;
            this.output.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Converted
            // 
            this.Converted.AutoSize = true;
            this.Converted.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Converted.Location = new System.Drawing.Point(697, 213);
            this.Converted.Name = "Converted";
            this.Converted.Size = new System.Drawing.Size(135, 31);
            this.Converted.TabIndex = 4;
            this.Converted.Text = "Converted";
            this.Converted.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 49);
            this.label1.MinimumSize = new System.Drawing.Size(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "please enter a temp in fahrenheit or Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(371, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 99);
            this.button3.TabIndex = 6;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1156, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Converted);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.cnvrtC);
            this.Controls.Add(this.cnvrtF);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cnvrtF;
        private System.Windows.Forms.Button cnvrtC;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label Converted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

