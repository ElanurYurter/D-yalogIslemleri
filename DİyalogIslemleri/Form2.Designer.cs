namespace DİyalogIslemleri
{
    partial class Form2
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
            this.btn_standart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ikonlu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_butonlu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_retrycancel = new System.Windows.Forms.Button();
            this.btn_yesnocancel = new System.Windows.Forms.Button();
            this.btn_yesnoac = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_resimsec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_standart
            // 
            this.btn_standart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_standart.Location = new System.Drawing.Point(6, 36);
            this.btn_standart.Name = "btn_standart";
            this.btn_standart.Size = new System.Drawing.Size(130, 42);
            this.btn_standart.TabIndex = 0;
            this.btn_standart.Text = "Message Box Aç";
            this.btn_standart.UseVisualStyleBackColor = true;
            this.btn_standart.Click += new System.EventHandler(this.btn_standart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_standart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standart messagebox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "sadece bilgilendirme amacıyla \r\nkullanılan mesaj kutusudur.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_ikonlu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(269, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İkon\'lu messagebox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "tüm messageboxlara kullanım \r\nyerine göre ikon ekler.";
            // 
            // btn_ikonlu
            // 
            this.btn_ikonlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ikonlu.Location = new System.Drawing.Point(6, 36);
            this.btn_ikonlu.Name = "btn_ikonlu";
            this.btn_ikonlu.Size = new System.Drawing.Size(130, 42);
            this.btn_ikonlu.TabIndex = 0;
            this.btn_ikonlu.Text = "Message Box Aç";
            this.btn_ikonlu.UseVisualStyleBackColor = true;
            this.btn_ikonlu.Click += new System.EventHandler(this.btn_ikonlu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_butonlu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(533, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 128);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MessageBox Butonları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "MessageBox butonları isteğe ve \r\namaca göre değiştirilebilir.";
            // 
            // btn_butonlu
            // 
            this.btn_butonlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_butonlu.Location = new System.Drawing.Point(6, 36);
            this.btn_butonlu.Name = "btn_butonlu";
            this.btn_butonlu.Size = new System.Drawing.Size(130, 42);
            this.btn_butonlu.TabIndex = 0;
            this.btn_butonlu.Text = "Message Box Aç";
            this.btn_butonlu.UseVisualStyleBackColor = true;
            this.btn_butonlu.Click += new System.EventHandler(this.btn_butonlu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_retrycancel);
            this.groupBox4.Controls.Add(this.btn_yesnocancel);
            this.groupBox4.Controls.Add(this.btn_yesnoac);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(539, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 173);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MessageBox Butonları";
            // 
            // btn_retrycancel
            // 
            this.btn_retrycancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_retrycancel.Location = new System.Drawing.Point(6, 125);
            this.btn_retrycancel.Name = "btn_retrycancel";
            this.btn_retrycancel.Size = new System.Drawing.Size(130, 42);
            this.btn_retrycancel.TabIndex = 2;
            this.btn_retrycancel.Text = "Message Box Aç";
            this.btn_retrycancel.UseVisualStyleBackColor = true;
            this.btn_retrycancel.Click += new System.EventHandler(this.btn_retrycancel_Click);
            // 
            // btn_yesnocancel
            // 
            this.btn_yesnocancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yesnocancel.Location = new System.Drawing.Point(6, 80);
            this.btn_yesnocancel.Name = "btn_yesnocancel";
            this.btn_yesnocancel.Size = new System.Drawing.Size(130, 42);
            this.btn_yesnocancel.TabIndex = 1;
            this.btn_yesnocancel.Text = "Message Box Aç";
            this.btn_yesnocancel.UseVisualStyleBackColor = true;
            this.btn_yesnocancel.Click += new System.EventHandler(this.btn_yesnocancel_Click);
            // 
            // btn_yesnoac
            // 
            this.btn_yesnoac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yesnoac.Location = new System.Drawing.Point(6, 36);
            this.btn_yesnoac.Name = "btn_yesnoac";
            this.btn_yesnoac.Size = new System.Drawing.Size(130, 42);
            this.btn_yesnoac.TabIndex = 0;
            this.btn_yesnoac.Text = "Message Box Aç";
            this.btn_yesnoac.UseVisualStyleBackColor = true;
            this.btn_yesnoac.Click += new System.EventHandler(this.btn_yesnoac_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.btn_resimsec);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(27, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(472, 176);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Open file dialog";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Zoom",
            "Stretch"});
            this.comboBox1.Location = new System.Drawing.Point(337, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_resimsec
            // 
            this.btn_resimsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_resimsec.Location = new System.Drawing.Point(336, 43);
            this.btn_resimsec.Name = "btn_resimsec";
            this.btn_resimsec.Size = new System.Drawing.Size(130, 38);
            this.btn_resimsec.TabIndex = 2;
            this.btn_resimsec.Text = "Resim Seçiniz\r\n";
            this.btn_resimsec.UseVisualStyleBackColor = true;
            this.btn_resimsec.Click += new System.EventHandler(this.btn_resimsec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 383);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_standart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ikonlu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_butonlu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_yesnoac;
        private System.Windows.Forms.Button btn_yesnocancel;
        private System.Windows.Forms.Button btn_retrycancel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_resimsec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}