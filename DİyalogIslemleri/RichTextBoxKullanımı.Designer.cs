namespace DİyalogIslemleri
{
    partial class RichTextBoxKullanımı
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_ac = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_font = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_renk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_klasor = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_secilenfont = new System.Windows.Forms.Button();
            this.btn_secilenrenk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RichTextBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "richtextbox tarafından üretilen dosyanın uzantısı  .rtf olmaktadır.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(772, 274);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btn_ac
            // 
            this.btn_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ac.Location = new System.Drawing.Point(21, 81);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(77, 32);
            this.btn_ac.TabIndex = 3;
            this.btn_ac.Text = "Aç";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(104, 81);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(87, 32);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_font
            // 
            this.btn_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_font.Location = new System.Drawing.Point(197, 81);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(87, 32);
            this.btn_font.TabIndex = 5;
            this.btn_font.Text = "Font";
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_renk
            // 
            this.btn_renk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_renk.Location = new System.Drawing.Point(290, 81);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(118, 32);
            this.btn_renk.TabIndex = 6;
            this.btn_renk.Text = "Renk Değiştir";
            this.btn_renk.UseVisualStyleBackColor = true;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(790, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 277);
            this.listBox1.TabIndex = 7;
            // 
            // btn_klasor
            // 
            this.btn_klasor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_klasor.Location = new System.Drawing.Point(790, 81);
            this.btn_klasor.Name = "btn_klasor";
            this.btn_klasor.Size = new System.Drawing.Size(111, 32);
            this.btn_klasor.TabIndex = 8;
            this.btn_klasor.Text = "Klasör Aç";
            this.btn_klasor.UseVisualStyleBackColor = true;
            this.btn_klasor.Click += new System.EventHandler(this.btn_klasor_Click);
            // 
            // btn_secilenfont
            // 
            this.btn_secilenfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secilenfont.Location = new System.Drawing.Point(414, 81);
            this.btn_secilenfont.Name = "btn_secilenfont";
            this.btn_secilenfont.Size = new System.Drawing.Size(118, 32);
            this.btn_secilenfont.TabIndex = 9;
            this.btn_secilenfont.Text = "Seçilen Font";
            this.btn_secilenfont.UseVisualStyleBackColor = true;
            this.btn_secilenfont.Click += new System.EventHandler(this.btn_secilenfont_Click);
            // 
            // btn_secilenrenk
            // 
            this.btn_secilenrenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secilenrenk.Location = new System.Drawing.Point(538, 81);
            this.btn_secilenrenk.Name = "btn_secilenrenk";
            this.btn_secilenrenk.Size = new System.Drawing.Size(118, 32);
            this.btn_secilenrenk.TabIndex = 10;
            this.btn_secilenrenk.Text = "Seçilen Renk";
            this.btn_secilenrenk.UseVisualStyleBackColor = true;
            this.btn_secilenrenk.Click += new System.EventHandler(this.btn_secilenrenk_Click);
            // 
            // RichTextBoxKullanımı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 414);
            this.Controls.Add(this.btn_secilenrenk);
            this.Controls.Add(this.btn_secilenfont);
            this.Controls.Add(this.btn_klasor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_renk);
            this.Controls.Add(this.btn_font);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RichTextBoxKullanımı";
            this.Text = "RichTextBoxKullanımı";
            this.Load += new System.EventHandler(this.RichTextBoxKullanımı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_font;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_renk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_klasor;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_secilenfont;
        private System.Windows.Forms.Button btn_secilenrenk;
    }
}