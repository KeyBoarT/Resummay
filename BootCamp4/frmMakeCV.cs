using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BootCamp4
{
    public partial class frmMakeCV : Form
    {
        public frmMakeCV()
        {
            InitializeComponent();
        }

        private void frmMakeCV_Load(object sender, EventArgs e)
        {
            gbxCommonInfos.Click += new EventHandler(FormFocus);
            gbxEducationInfos.Click += new EventHandler(FormFocus);
            gbxJobExperience.Click += new EventHandler(FormFocus);
            this.Click += new EventHandler(FormFocus);
        }

        public void FormFocus(object sender, EventArgs e)
        {
            tbxFocus.Focus();
        }

        private void iconbtnAddImage_Click(object sender, EventArgs e)
        {
            pbxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Dosya seçiniz...";
            openFileDialog.Filter = "PNG Dosyaları |*.png| JPG Dosyaları|*.jpg| JPEG Dosyaları |*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxUser.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void ıconbtnMakePdf_Click(object sender, EventArgs e)
        {
            //Turkish Alphabet
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
            //Fonts
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font HeaderFont = new iTextSharp.text.Font(STF_Helvetica_Turkish, 30, iTextSharp.text.Font.NORMAL);
            
            //Design
            PDFPage pdfPage = new PDFPage(tbxName.Text + tbxSurname.Text);
            pdfPage.SetInfos($"{tbxName.Text} {tbxSurname.Text}", "Resummay");
            pdfPage.AddImage(iTextSharp.text.Image.GetInstance(pbxUser.Image ,BaseColor.WHITE), 180, 0, 0, 180, (float)22.5, pdfPage.Height - (float)202.5);
            pdfPage.WriteLines(BaseColor.BLACK);
            pdfPage.AddPhrase("İsim: " + tbxName.Text, fontNormal, 10, pdfPage.Height - 250);
            pdfPage.AddPhrase("Soyisim: " + tbxSurname.Text, fontNormal, 10, pdfPage.Height - 275);
            pdfPage.AddPhrase("Cinsiyet: " + cmbxGender.Text, fontNormal, 10, pdfPage.Height - 300);
            pdfPage.AddPhrase("Doğum: " + dtpBirthDay.Text, fontNormal, 10, pdfPage.Height - 325);
            pdfPage.AddPhrase("Medeni Durum: " + cmbxMaritalStatus.Text, fontNormal, 10, pdfPage.Height - 350);
            pdfPage.AddPhrase("Uyruk: " + tbxNation.Text, fontNormal, 10, pdfPage.Height - 375);
            pdfPage.AddPhrase("EĞİTİM BİLGİLERİ", HeaderFont, (float)282.5, pdfPage.Height - 55);
            pdfPage.AddPhrase("İŞ DENEYİMLERİ", HeaderFont, (float)292.5, pdfPage.Height - 462);
            pdfPage.AddParagraph(tbxEducationInfos.Text, fontNormal, 575, 361, 245, 30);
            pdfPage.AddParagraph(tbxJobExperience.Text, fontNormal, 575, 772, 245, 441);
            
            //Closing...
            pdfPage.Close();


            MessageBox.Show("Özgeçmiş başarıyla oluşturuldu !");
        }
    }
}
