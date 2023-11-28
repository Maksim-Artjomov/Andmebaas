namespace Andmebaas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LisaKategooriaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.LisaToodeButton = new System.Windows.Forms.Button();
            this.KutsutaToodeButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.KutsutaKategooriaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kat_Box
            // 
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(423, 200);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(121, 21);
            this.Kat_Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // LisaKategooriaButton
            // 
            this.LisaKategooriaButton.Location = new System.Drawing.Point(344, 233);
            this.LisaKategooriaButton.Name = "LisaKategooriaButton";
            this.LisaKategooriaButton.Size = new System.Drawing.Size(55, 36);
            this.LisaKategooriaButton.TabIndex = 3;
            this.LisaKategooriaButton.Text = "Lisa kategooria";
            this.LisaKategooriaButton.UseVisualStyleBackColor = true;
            this.LisaKategooriaButton.Click += new System.EventHandler(this.LisaKategooriaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hind:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kogus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kategooried:";
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(168, 157);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(100, 20);
            this.Kogus_txt.TabIndex = 9;
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(168, 117);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(100, 20);
            this.Toode_txt.TabIndex = 10;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(168, 200);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(100, 20);
            this.Hind_txt.TabIndex = 11;
            // 
            // LisaToodeButton
            // 
            this.LisaToodeButton.Location = new System.Drawing.Point(118, 233);
            this.LisaToodeButton.Name = "LisaToodeButton";
            this.LisaToodeButton.Size = new System.Drawing.Size(55, 36);
            this.LisaToodeButton.TabIndex = 12;
            this.LisaToodeButton.Text = "Lisa";
            this.LisaToodeButton.UseVisualStyleBackColor = true;
            this.LisaToodeButton.Click += new System.EventHandler(this.LisaToodeButton_Click);
            // 
            // KutsutaToodeButton
            // 
            this.KutsutaToodeButton.Location = new System.Drawing.Point(240, 233);
            this.KutsutaToodeButton.Name = "KutsutaToodeButton";
            this.KutsutaToodeButton.Size = new System.Drawing.Size(65, 36);
            this.KutsutaToodeButton.TabIndex = 13;
            this.KutsutaToodeButton.Text = "Kutsusta";
            this.KutsutaToodeButton.UseVisualStyleBackColor = true;
            this.KutsutaToodeButton.Click += new System.EventHandler(this.KutsutaToodeButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Uuenda";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // KutsutaKategooriaButton
            // 
            this.KutsutaKategooriaButton.Location = new System.Drawing.Point(423, 233);
            this.KutsutaKategooriaButton.Name = "KutsutaKategooriaButton";
            this.KutsutaKategooriaButton.Size = new System.Drawing.Size(55, 36);
            this.KutsutaKategooriaButton.TabIndex = 15;
            this.KutsutaKategooriaButton.Text = "Kutsuta kategooria";
            this.KutsutaKategooriaButton.UseVisualStyleBackColor = true;
            this.KutsutaKategooriaButton.Click += new System.EventHandler(this.KutsutaKategooriaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KutsutaKategooriaButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.KutsutaToodeButton);
            this.Controls.Add(this.LisaToodeButton);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LisaKategooriaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LisaKategooriaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Button LisaToodeButton;
        private System.Windows.Forms.Button KutsutaToodeButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button KutsutaKategooriaButton;
    }
}

