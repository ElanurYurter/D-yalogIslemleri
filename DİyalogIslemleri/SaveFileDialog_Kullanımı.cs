using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DİyalogIslemleri
{
    public partial class SaveFileDialog_Kullanımı : Form
    {
        public SaveFileDialog_Kullanımı()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_yazici.Text))
            {
                DialogResult sonuc = saveFileDialog1.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    string yol = saveFileDialog1 .FileName;
                    StreamWriter yazici = new StreamWriter(yol);
                    yazici.Write(tb_yazici.Text);
                    yazici.Close();
                    MessageBox.Show("Kaydedildi", "Başarılı");

                }
            }
            else
            {
                MessageBox.Show("Kaydedilecek sonuç yok", "Dikkat");
            }
        }

        private void SaveFileDialog_Kullanımı_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("Metin Belgesi (*.txt)|*.txt| Tüm Dosya Türleri |*.*");
        }
    }
}
