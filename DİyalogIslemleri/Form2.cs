using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DİyalogIslemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Jpg dosyası|*.jpg|Png dosyası|*.png|Tüm dosya türleri|*.*"; //filtreler.
        }

        private void btn_standart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İçerik", "Başlık");
        }

        private void btn_ikonlu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBoxIcon.Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("MessageBoxIcon.Question", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show("MessageBoxIcon.Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("MessageBoxIcon.Warning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("MessageBoxIcon.Hand", "Hand", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btn_butonlu_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("İşleme devam edilsin mi?", "Dikkat", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show("Kabul edildi");
            }
            if (sonuc == DialogResult.Cancel)
            {
                MessageBox.Show("Reddedildi");
            }
        }

        private void btn_yesnoac_Click(object sender, EventArgs e)
        {
            DialogResult sonuc2 = MessageBox.Show("İşleme devam edilsin mi?", "Dikkat", MessageBoxButtons.YesNo);
            if (sonuc2 == DialogResult.Yes)
            {
                MessageBox.Show("Kabul edildi");
            }
            if (sonuc2 == DialogResult.No)
            {
                MessageBox.Show("Reddedildi");
            }
        }

        private void btn_yesnocancel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc3 = MessageBox.Show("İşleme devam edilsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel);
            if (sonuc3 == DialogResult.Yes)
            {
                MessageBox.Show("Kabul Edildi");
            }
            if (sonuc3 == DialogResult.No)
            {
                MessageBox.Show("Reddedildi");
            }
            if (sonuc3 == DialogResult.Cancel)
            {
                MessageBox.Show("İptal edildi");
            }
        }

        private void btn_retrycancel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc3 = MessageBox.Show("İşleme devam edilsin mi?", "Dikkat", MessageBoxButtons.RetryCancel);
            if (sonuc3 == DialogResult.Retry)
            {
                MessageBox.Show("Tekrar Denendi");
            }
            if (sonuc3 == DialogResult.Cancel)
            {
                MessageBox.Show("Reddedildi");
            }
        }

        private void btn_resimsec_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            //openFİleDialog1 içerisinde OK basılmış ise
            if (sonuc == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Dosya Seçilmedi");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Zoom");
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (comboBox1.SelectedItem.ToString() == "Stretch") ;
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
