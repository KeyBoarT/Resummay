using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BootCamp4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private string fileName;
        public void OpenChildMenu(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void icobtnMakeCV_Click(object sender, EventArgs e)
        {
            OpenChildMenu(new frmMakeCV());
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            pnlSendCV.Location = new Point(this.pnlMain.Width - pnlSendCV.Width, this.pnlMain.Height - pnlSendCV.Height);
        }

        private void iconbtnPanelExit_Click(object sender, EventArgs e)
        {
            for (int i = pnlSendCV.Height; i >= 0; i--)
            {
                pnlSendCV.Location = new Point(this.pnlMain.Width - pnlSendCV.Width, this.pnlMain.Height - i);
            }
            pnlSendCV.Visible = false;
        }

        private void iconbtnSendCV_Click(object sender, EventArgs e)
        {
            pnlSendCV.Location = new Point(this.pnlMain.Width - pnlSendCV.Width, this.pnlMain.Height - pnlSendCV.Height);
            pnlSendCV.Visible = true;
            pnlSendCV.BringToFront();
        }

        private void tbxSenderEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxEmailSender.Text))
                tbxEmailSender.Text = "E-Mail";
        }

        private void tbxPasswordSender_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxPasswordSender.Text))
                tbxPasswordSender.Text = "Parola";
        }

        private void tbxEmailSender_Enter(object sender, EventArgs e)
        {
            if (tbxEmailSender.Text == "E-Mail")
                tbxEmailSender.Text = "";
        }

        private void tbxPasswordSender_Enter(object sender, EventArgs e)
        {
            if (tbxPasswordSender.Text == "Parola")
                tbxPasswordSender.Text = "";
        }

        private void tbxEmailReceiver_Leave(object sender, EventArgs e)
        {
            if (tbxEmailReceiver.Text == "")
                tbxEmailReceiver.Text = "E-Mail";
        }

        private void tbxEmailReceiver_Enter(object sender, EventArgs e)
        {
            if (tbxEmailReceiver.Text == "E-Mail")
                tbxEmailReceiver.Text = "";
        }

        private void iconBtnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Dosyası |*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                if (openFileDialog.SafeFileName.Length > 37)
                    tbxFileName.Text = openFileDialog.SafeFileName.Substring(0, 34) + "...";
                else
                    tbxFileName.Text = openFileDialog.SafeFileName;
            }
            MessageBox.Show("Dosya Eklendi !", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage myMessage = new MailMessage();
                myMessage.Subject = "Özgeçmiş Belgesi";
                myMessage.From = new MailAddress("bootcamp4proje@outlook.com");
                myMessage.From = new MailAddress(tbxEmailSender.Text);
                myMessage.To.Add("bootcamp4proje@outlook.com");
                myMessage.To.Add(tbxEmailReceiver.Text);
                myMessage.Attachments.Add(new Attachment(fileName));
                SmtpClient client = new SmtpClient()
                {
                    Credentials = new System.Net.NetworkCredential(tbxEmailSender.Text, tbxPasswordSender.Text),
                    Port = 587,
                    Host = "smtp-mail.outlook.com",
                    EnableSsl = true
                };
                client.Send(myMessage);
                MessageBox.Show("Mail Başarıyla Gönderildi !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
