namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNILAIA = new System.Windows.Forms.TextBox();
            this.txtNILAIB = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Hasil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NILAI A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NILAI B";
            // 
            // txtNILAIA
            // 
            this.txtNILAIA.Location = new System.Drawing.Point(105, 18);
            this.txtNILAIA.Name = "txtNILAIA";
            this.txtNILAIA.Size = new System.Drawing.Size(93, 22);
            this.txtNILAIA.TabIndex = 2;
            // 
            // txtNILAIB
            // 
            this.txtNILAIB.Location = new System.Drawing.Point(105, 72);
            this.txtNILAIB.Name = "txtNILAIB";
            this.txtNILAIB.Size = new System.Drawing.Size(93, 22);
            this.txtNILAIB.TabIndex = 3;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(262, 41);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(93, 28);
            this.btnHitung.TabIndex = 4;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "[Hasil]";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(704, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Hasil";
            this.comboBox1.ValueMember = "[ Hasil ]";
            // 
            // Hasil
            // 
            this.Hasil.DisplayMember = "lstHasil";
            this.Hasil.FormattingEnabled = true;
            this.Hasil.ItemHeight = 16;
            this.Hasil.Location = new System.Drawing.Point(51, 168);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(703, 260);
            this.Hasil.TabIndex = 6;
            this.Hasil.ValueMember = "lstHasil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtNILAIB);
            this.Controls.Add(this.txtNILAIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNILAIA;
        private System.Windows.Forms.TextBox txtNILAIB;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox Hasil;
    }
}

