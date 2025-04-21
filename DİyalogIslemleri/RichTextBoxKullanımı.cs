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
    public partial class RichTextBoxKullanımı : Form
    {
        public RichTextBoxKullanımı()
        {
            InitializeComponent();
        }
        private void RichTextBoxKullanımı_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zengin Metin Biçimi |*.rtf| Metin Belgesi |*.txt| Tüm Dosya Türleri |*.*";

        }
        private void btn_ac_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("olmadı", "başarısız");
            }
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                string yol = saveFileDialog1.FileName;
                richTextBox1.SaveFile(yol);
            }
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = fontDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                Font fnt = fontDialog1.Font;
                richTextBox1.Font = fnt;
            }
        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            DialogResult renk = colorDialog1.ShowDialog();
            if (renk == DialogResult.OK)
            {
                Color c = colorDialog1.Color;
                richTextBox1.ForeColor = c;
            }
        }

        private void btn_klasor_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                string yol = folderBrowserDialog1.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(yol);

                foreach (FileInfo item in di.GetFiles())
                {
                    listBox1.Items.Add(item.Name);
                }
                
            }
        }

        private void btn_secilenfont_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = fontDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                Font fnt = fontDialog1.Font;
                richTextBox1.SelectionFont = fnt;
            }
        }

        private void btn_secilenrenk_Click(object sender, EventArgs e)
        {
            DialogResult renk = colorDialog1.ShowDialog();
            if (renk == DialogResult.OK)
            {
                Color c = colorDialog1.Color;
                richTextBox1.SelectionColor = c;
            }
        }
    }
}