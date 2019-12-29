namespace Q5v7
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
            this.Sc = new System.Windows.Forms.ComboBox();
            this.Dc = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cal = new System.Windows.Forms.Button();
            this.Source = new System.Windows.Forms.Label();
            this.Dest = new System.Windows.Forms.Label();
            this.val = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Result = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sc
            // 
            this.Sc.FormattingEnabled = true;
            this.Sc.Items.AddRange(new object[] {
            "PKR",
            "IR",
            "USD",
            "AA"});
            this.Sc.Location = new System.Drawing.Point(368, 65);
            this.Sc.Name = "Sc";
            this.Sc.Size = new System.Drawing.Size(121, 24);
            this.Sc.TabIndex = 0;
            this.Sc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Dc
            // 
            this.Dc.FormattingEnabled = true;
            this.Dc.Items.AddRange(new object[] {
            "PKR",
            "IR",
            "USD",
            "AA"});
            this.Dc.Location = new System.Drawing.Point(368, 156);
            this.Dc.Name = "Dc";
            this.Dc.Size = new System.Drawing.Size(121, 24);
            this.Dc.TabIndex = 1;
            this.Dc.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(368, 309);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(121, 23);
            this.Cal.TabIndex = 3;
            this.Cal.Text = "Calculate";
            this.Cal.UseVisualStyleBackColor = true;
            this.Cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Location = new System.Drawing.Point(96, 68);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(114, 17);
            this.Source.TabIndex = 4;
            this.Source.Text = "Source Currency";
            // 
            // Dest
            // 
            this.Dest.AutoSize = true;
            this.Dest.Location = new System.Drawing.Point(96, 159);
            this.Dest.Name = "Dest";
            this.Dest.Size = new System.Drawing.Size(140, 17);
            this.Dest.TabIndex = 5;
            this.Dest.Text = "Destination Currency";
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(96, 242);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(56, 17);
            this.val.TabIndex = 6;
            this.val.Text = "Amount";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(96, 382);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 7;
            this.Result.Text = "Result";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.val);
            this.Controls.Add(this.Dest);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dc);
            this.Controls.Add(this.Sc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Sc;
        private System.Windows.Forms.ComboBox Dc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cal;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Label Dest;
        private System.Windows.Forms.Label val;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBox2;
    }
}

