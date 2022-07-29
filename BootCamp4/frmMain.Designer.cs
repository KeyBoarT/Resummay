
namespace BootCamp4
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.iconbtnSendCV = new FontAwesome.Sharp.IconButton();
            this.icobtnMakeCV = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSendCV = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.iconBtnFile = new FontAwesome.Sharp.IconButton();
            this.gbxFile = new System.Windows.Forms.GroupBox();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.gbxReceiver = new System.Windows.Forms.GroupBox();
            this.tbxEmailReceiver = new System.Windows.Forms.TextBox();
            this.gbxSender = new System.Windows.Forms.GroupBox();
            this.tbxPasswordSender = new System.Windows.Forms.TextBox();
            this.tbxEmailSender = new System.Windows.Forms.TextBox();
            this.iconbtnPanelExit = new FontAwesome.Sharp.IconButton();
            this.pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlSendCV.SuspendLayout();
            this.gbxFile.SuspendLayout();
            this.gbxReceiver.SuspendLayout();
            this.gbxSender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BackColor = System.Drawing.Color.White;
            this.pnlLeftSide.Controls.Add(this.iconbtnSendCV);
            this.pnlLeftSide.Controls.Add(this.icobtnMakeCV);
            this.pnlLeftSide.Controls.Add(this.pictureBox1);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(200, 729);
            this.pnlLeftSide.TabIndex = 0;
            // 
            // iconbtnSendCV
            // 
            this.iconbtnSendCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.iconbtnSendCV.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnSendCV.FlatAppearance.BorderSize = 0;
            this.iconbtnSendCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSendCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.iconbtnSendCV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnSendCV.IconColor = System.Drawing.Color.Black;
            this.iconbtnSendCV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnSendCV.Location = new System.Drawing.Point(0, 250);
            this.iconbtnSendCV.Name = "iconbtnSendCV";
            this.iconbtnSendCV.Size = new System.Drawing.Size(200, 50);
            this.iconbtnSendCV.TabIndex = 2;
            this.iconbtnSendCV.Text = "Özgeçmiş Gönder";
            this.iconbtnSendCV.UseVisualStyleBackColor = false;
            this.iconbtnSendCV.Click += new System.EventHandler(this.iconbtnSendCV_Click);
            // 
            // icobtnMakeCV
            // 
            this.icobtnMakeCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.icobtnMakeCV.Dock = System.Windows.Forms.DockStyle.Top;
            this.icobtnMakeCV.FlatAppearance.BorderSize = 0;
            this.icobtnMakeCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icobtnMakeCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.icobtnMakeCV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icobtnMakeCV.IconColor = System.Drawing.Color.Black;
            this.icobtnMakeCV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icobtnMakeCV.Location = new System.Drawing.Point(0, 200);
            this.icobtnMakeCV.Name = "icobtnMakeCV";
            this.icobtnMakeCV.Size = new System.Drawing.Size(200, 50);
            this.icobtnMakeCV.TabIndex = 1;
            this.icobtnMakeCV.Text = "Özgeçmiş Oluştur";
            this.icobtnMakeCV.UseVisualStyleBackColor = false;
            this.icobtnMakeCV.Click += new System.EventHandler(this.icobtnMakeCV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlSendCV);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(808, 729);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlSendCV
            // 
            this.pnlSendCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnlSendCV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSendCV.Controls.Add(this.btnSend);
            this.pnlSendCV.Controls.Add(this.iconBtnFile);
            this.pnlSendCV.Controls.Add(this.gbxFile);
            this.pnlSendCV.Controls.Add(this.gbxReceiver);
            this.pnlSendCV.Controls.Add(this.gbxSender);
            this.pnlSendCV.Controls.Add(this.iconbtnPanelExit);
            this.pnlSendCV.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlSendCV.Location = new System.Drawing.Point(408, 374);
            this.pnlSendCV.Name = "pnlSendCV";
            this.pnlSendCV.Size = new System.Drawing.Size(400, 355);
            this.pnlSendCV.TabIndex = 0;
            this.pnlSendCV.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(243, 311);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 35);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // iconBtnFile
            // 
            this.iconBtnFile.FlatAppearance.BorderSize = 0;
            this.iconBtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnFile.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconBtnFile.IconColor = System.Drawing.Color.Black;
            this.iconBtnFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnFile.Location = new System.Drawing.Point(3, 270);
            this.iconBtnFile.Name = "iconBtnFile";
            this.iconBtnFile.Size = new System.Drawing.Size(35, 35);
            this.iconBtnFile.TabIndex = 4;
            this.iconBtnFile.UseVisualStyleBackColor = true;
            this.iconBtnFile.Click += new System.EventHandler(this.iconBtnFile_Click);
            // 
            // gbxFile
            // 
            this.gbxFile.Controls.Add(this.tbxFileName);
            this.gbxFile.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Italic);
            this.gbxFile.Location = new System.Drawing.Point(44, 256);
            this.gbxFile.Name = "gbxFile";
            this.gbxFile.Size = new System.Drawing.Size(349, 49);
            this.gbxFile.TabIndex = 3;
            this.gbxFile.TabStop = false;
            this.gbxFile.Text = "Dosya";
            // 
            // tbxFileName
            // 
            this.tbxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.tbxFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFileName.Location = new System.Drawing.Point(6, 21);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(336, 22);
            this.tbxFileName.TabIndex = 0;
            // 
            // gbxReceiver
            // 
            this.gbxReceiver.Controls.Add(this.tbxEmailReceiver);
            this.gbxReceiver.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Italic);
            this.gbxReceiver.Location = new System.Drawing.Point(3, 178);
            this.gbxReceiver.Name = "gbxReceiver";
            this.gbxReceiver.Size = new System.Drawing.Size(390, 72);
            this.gbxReceiver.TabIndex = 2;
            this.gbxReceiver.TabStop = false;
            this.gbxReceiver.Text = "Alıcı E-Mail";
            // 
            // tbxEmailReceiver
            // 
            this.tbxEmailReceiver.Location = new System.Drawing.Point(6, 29);
            this.tbxEmailReceiver.Name = "tbxEmailReceiver";
            this.tbxEmailReceiver.Size = new System.Drawing.Size(377, 29);
            this.tbxEmailReceiver.TabIndex = 0;
            this.tbxEmailReceiver.Text = "E-Mail";
            this.tbxEmailReceiver.Enter += new System.EventHandler(this.tbxEmailReceiver_Enter);
            this.tbxEmailReceiver.Leave += new System.EventHandler(this.tbxEmailReceiver_Leave);
            // 
            // gbxSender
            // 
            this.gbxSender.Controls.Add(this.tbxPasswordSender);
            this.gbxSender.Controls.Add(this.tbxEmailSender);
            this.gbxSender.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Italic);
            this.gbxSender.Location = new System.Drawing.Point(3, 44);
            this.gbxSender.Name = "gbxSender";
            this.gbxSender.Size = new System.Drawing.Size(390, 128);
            this.gbxSender.TabIndex = 1;
            this.gbxSender.TabStop = false;
            this.gbxSender.Text = "Gönderici E-Mail";
            // 
            // tbxPasswordSender
            // 
            this.tbxPasswordSender.Location = new System.Drawing.Point(6, 76);
            this.tbxPasswordSender.Name = "tbxPasswordSender";
            this.tbxPasswordSender.Size = new System.Drawing.Size(377, 29);
            this.tbxPasswordSender.TabIndex = 1;
            this.tbxPasswordSender.Text = "Parola";
            this.tbxPasswordSender.Enter += new System.EventHandler(this.tbxPasswordSender_Enter);
            this.tbxPasswordSender.Leave += new System.EventHandler(this.tbxPasswordSender_Leave);
            // 
            // tbxEmailSender
            // 
            this.tbxEmailSender.Location = new System.Drawing.Point(6, 29);
            this.tbxEmailSender.Name = "tbxEmailSender";
            this.tbxEmailSender.Size = new System.Drawing.Size(377, 29);
            this.tbxEmailSender.TabIndex = 0;
            this.tbxEmailSender.Text = "E-Mail";
            this.tbxEmailSender.Enter += new System.EventHandler(this.tbxEmailSender_Enter);
            this.tbxEmailSender.Leave += new System.EventHandler(this.tbxSenderEmail_Leave);
            // 
            // iconbtnPanelExit
            // 
            this.iconbtnPanelExit.FlatAppearance.BorderSize = 0;
            this.iconbtnPanelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnPanelExit.ForeColor = System.Drawing.Color.DarkRed;
            this.iconbtnPanelExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconbtnPanelExit.IconColor = System.Drawing.Color.White;
            this.iconbtnPanelExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnPanelExit.IconSize = 30;
            this.iconbtnPanelExit.Location = new System.Drawing.Point(358, 3);
            this.iconbtnPanelExit.Name = "iconbtnPanelExit";
            this.iconbtnPanelExit.Size = new System.Drawing.Size(35, 35);
            this.iconbtnPanelExit.TabIndex = 0;
            this.iconbtnPanelExit.UseVisualStyleBackColor = true;
            this.iconbtnPanelExit.Click += new System.EventHandler(this.iconbtnPanelExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeftSide);
            this.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Özgeçmiş Hazırlama";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.pnlLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlSendCV.ResumeLayout(false);
            this.gbxFile.ResumeLayout(false);
            this.gbxFile.PerformLayout();
            this.gbxReceiver.ResumeLayout(false);
            this.gbxReceiver.PerformLayout();
            this.gbxSender.ResumeLayout(false);
            this.gbxSender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSide;
        private FontAwesome.Sharp.IconButton iconbtnSendCV;
        private FontAwesome.Sharp.IconButton icobtnMakeCV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSendCV;
        private FontAwesome.Sharp.IconButton iconbtnPanelExit;
        private System.Windows.Forms.GroupBox gbxSender;
        private System.Windows.Forms.TextBox tbxPasswordSender;
        private System.Windows.Forms.TextBox tbxEmailSender;
        private System.Windows.Forms.GroupBox gbxReceiver;
        private System.Windows.Forms.TextBox tbxEmailReceiver;
        private System.Windows.Forms.GroupBox gbxFile;
        private FontAwesome.Sharp.IconButton iconBtnFile;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Button btnSend;
    }
}

