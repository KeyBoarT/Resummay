
namespace BootCamp4
{
    partial class frmMakeCV
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
            this.gbxCommonInfos = new System.Windows.Forms.GroupBox();
            this.cmbxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.iconbtnAddImage = new FontAwesome.Sharp.IconButton();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.tbxNation = new System.Windows.Forms.TextBox();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.gbxEducationInfos = new System.Windows.Forms.GroupBox();
            this.tbxEducationInfos = new System.Windows.Forms.TextBox();
            this.gbxJobExperience = new System.Windows.Forms.GroupBox();
            this.tbxJobExperience = new System.Windows.Forms.TextBox();
            this.tbxFocus = new System.Windows.Forms.TextBox();
            this.ıconbtnMakePdf = new FontAwesome.Sharp.IconButton();
            this.gbxCommonInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.gbxEducationInfos.SuspendLayout();
            this.gbxJobExperience.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCommonInfos
            // 
            this.gbxCommonInfos.Controls.Add(this.cmbxMaritalStatus);
            this.gbxCommonInfos.Controls.Add(this.cmbxGender);
            this.gbxCommonInfos.Controls.Add(this.iconbtnAddImage);
            this.gbxCommonInfos.Controls.Add(this.dtpBirthDay);
            this.gbxCommonInfos.Controls.Add(this.tbxNation);
            this.gbxCommonInfos.Controls.Add(this.lblNation);
            this.gbxCommonInfos.Controls.Add(this.lblMaritalStatus);
            this.gbxCommonInfos.Controls.Add(this.lblBirthDay);
            this.gbxCommonInfos.Controls.Add(this.lblGender);
            this.gbxCommonInfos.Controls.Add(this.tbxSurname);
            this.gbxCommonInfos.Controls.Add(this.lblSurname);
            this.gbxCommonInfos.Controls.Add(this.tbxName);
            this.gbxCommonInfos.Controls.Add(this.lblName);
            this.gbxCommonInfos.Controls.Add(this.pbxUser);
            this.gbxCommonInfos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxCommonInfos.Location = new System.Drawing.Point(0, 0);
            this.gbxCommonInfos.Name = "gbxCommonInfos";
            this.gbxCommonInfos.Size = new System.Drawing.Size(309, 729);
            this.gbxCommonInfos.TabIndex = 0;
            this.gbxCommonInfos.TabStop = false;
            this.gbxCommonInfos.Text = "Genel Bilgiler";
            // 
            // cmbxMaritalStatus
            // 
            this.cmbxMaritalStatus.FormattingEnabled = true;
            this.cmbxMaritalStatus.Items.AddRange(new object[] {
            "Evli",
            "Bekar",
            "Dul"});
            this.cmbxMaritalStatus.Location = new System.Drawing.Point(145, 498);
            this.cmbxMaritalStatus.Name = "cmbxMaritalStatus";
            this.cmbxMaritalStatus.Size = new System.Drawing.Size(161, 29);
            this.cmbxMaritalStatus.TabIndex = 16;
            // 
            // cmbxGender
            // 
            this.cmbxGender.FormattingEnabled = true;
            this.cmbxGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Belirtmek İstemiyorum"});
            this.cmbxGender.Location = new System.Drawing.Point(145, 428);
            this.cmbxGender.Name = "cmbxGender";
            this.cmbxGender.Size = new System.Drawing.Size(161, 29);
            this.cmbxGender.TabIndex = 15;
            // 
            // iconbtnAddImage
            // 
            this.iconbtnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.iconbtnAddImage.FlatAppearance.BorderSize = 0;
            this.iconbtnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnAddImage.ForeColor = System.Drawing.Color.White;
            this.iconbtnAddImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconbtnAddImage.IconColor = System.Drawing.Color.White;
            this.iconbtnAddImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAddImage.IconSize = 40;
            this.iconbtnAddImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnAddImage.Location = new System.Drawing.Point(145, 281);
            this.iconbtnAddImage.Name = "iconbtnAddImage";
            this.iconbtnAddImage.Size = new System.Drawing.Size(161, 43);
            this.iconbtnAddImage.TabIndex = 14;
            this.iconbtnAddImage.Text = "Resim Ekle";
            this.iconbtnAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnAddImage.UseVisualStyleBackColor = false;
            this.iconbtnAddImage.Click += new System.EventHandler(this.iconbtnAddImage_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(145, 463);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(161, 29);
            this.dtpBirthDay.TabIndex = 13;
            // 
            // tbxNation
            // 
            this.tbxNation.Location = new System.Drawing.Point(145, 533);
            this.tbxNation.Name = "tbxNation";
            this.tbxNation.Size = new System.Drawing.Size(161, 29);
            this.tbxNation.TabIndex = 12;
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNation.Location = new System.Drawing.Point(6, 536);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(55, 21);
            this.lblNation.TabIndex = 11;
            this.lblNation.Text = "Uyruk";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaritalStatus.Location = new System.Drawing.Point(6, 501);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(100, 21);
            this.lblMaritalStatus.TabIndex = 9;
            this.lblMaritalStatus.Text = "Medeni Hal";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBirthDay.Location = new System.Drawing.Point(6, 466);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(118, 21);
            this.lblBirthDay.TabIndex = 7;
            this.lblBirthDay.Text = "Doğum Tarihi";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(6, 431);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(82, 21);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Cinsiyet";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(145, 393);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(161, 29);
            this.tbxSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSurname.Location = new System.Drawing.Point(6, 396);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 21);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Soyisim";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(145, 358);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(161, 29);
            this.tbxName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(6, 361);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "İsim";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pbxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxUser.Location = new System.Drawing.Point(3, 25);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(303, 250);
            this.pbxUser.TabIndex = 0;
            this.pbxUser.TabStop = false;
            // 
            // gbxEducationInfos
            // 
            this.gbxEducationInfos.Controls.Add(this.tbxEducationInfos);
            this.gbxEducationInfos.Location = new System.Drawing.Point(309, 0);
            this.gbxEducationInfos.Name = "gbxEducationInfos";
            this.gbxEducationInfos.Size = new System.Drawing.Size(499, 330);
            this.gbxEducationInfos.TabIndex = 1;
            this.gbxEducationInfos.TabStop = false;
            this.gbxEducationInfos.Text = "Eğitim Bilgileri";
            // 
            // tbxEducationInfos
            // 
            this.tbxEducationInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxEducationInfos.Location = new System.Drawing.Point(3, 25);
            this.tbxEducationInfos.Multiline = true;
            this.tbxEducationInfos.Name = "tbxEducationInfos";
            this.tbxEducationInfos.Size = new System.Drawing.Size(493, 299);
            this.tbxEducationInfos.TabIndex = 0;
            // 
            // gbxJobExperience
            // 
            this.gbxJobExperience.Controls.Add(this.tbxJobExperience);
            this.gbxJobExperience.Controls.Add(this.tbxFocus);
            this.gbxJobExperience.Location = new System.Drawing.Point(309, 330);
            this.gbxJobExperience.Name = "gbxJobExperience";
            this.gbxJobExperience.Size = new System.Drawing.Size(499, 330);
            this.gbxJobExperience.TabIndex = 2;
            this.gbxJobExperience.TabStop = false;
            this.gbxJobExperience.Text = "İş Deneyimi";
            // 
            // tbxJobExperience
            // 
            this.tbxJobExperience.Location = new System.Drawing.Point(6, 28);
            this.tbxJobExperience.Multiline = true;
            this.tbxJobExperience.Name = "tbxJobExperience";
            this.tbxJobExperience.Size = new System.Drawing.Size(481, 299);
            this.tbxJobExperience.TabIndex = 1;
            // 
            // tbxFocus
            // 
            this.tbxFocus.Location = new System.Drawing.Point(6, 281);
            this.tbxFocus.Name = "tbxFocus";
            this.tbxFocus.Size = new System.Drawing.Size(100, 29);
            this.tbxFocus.TabIndex = 15;
            this.tbxFocus.Text = "Focus Text";
            // 
            // ıconbtnMakePdf
            // 
            this.ıconbtnMakePdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ıconbtnMakePdf.FlatAppearance.BorderSize = 0;
            this.ıconbtnMakePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconbtnMakePdf.ForeColor = System.Drawing.Color.White;
            this.ıconbtnMakePdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ıconbtnMakePdf.IconColor = System.Drawing.Color.White;
            this.ıconbtnMakePdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconbtnMakePdf.IconSize = 35;
            this.ıconbtnMakePdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconbtnMakePdf.Location = new System.Drawing.Point(635, 674);
            this.ıconbtnMakePdf.Name = "ıconbtnMakePdf";
            this.ıconbtnMakePdf.Size = new System.Drawing.Size(161, 43);
            this.ıconbtnMakePdf.TabIndex = 15;
            this.ıconbtnMakePdf.Text = "PDF Oluştur";
            this.ıconbtnMakePdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconbtnMakePdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconbtnMakePdf.UseVisualStyleBackColor = false;
            this.ıconbtnMakePdf.Click += new System.EventHandler(this.ıconbtnMakePdf_Click);
            // 
            // frmMakeCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 729);
            this.Controls.Add(this.ıconbtnMakePdf);
            this.Controls.Add(this.gbxJobExperience);
            this.Controls.Add(this.gbxEducationInfos);
            this.Controls.Add(this.gbxCommonInfos);
            this.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMakeCV";
            this.Text = "frmMakeCV";
            this.Load += new System.EventHandler(this.frmMakeCV_Load);
            this.gbxCommonInfos.ResumeLayout(false);
            this.gbxCommonInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.gbxEducationInfos.ResumeLayout(false);
            this.gbxEducationInfos.PerformLayout();
            this.gbxJobExperience.ResumeLayout(false);
            this.gbxJobExperience.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCommonInfos;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxNation;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.GroupBox gbxEducationInfos;
        private System.Windows.Forms.GroupBox gbxJobExperience;
        private System.Windows.Forms.TextBox tbxEducationInfos;
        private System.Windows.Forms.TextBox tbxJobExperience;
        private FontAwesome.Sharp.IconButton iconbtnAddImage;
        private FontAwesome.Sharp.IconButton ıconbtnMakePdf;
        private System.Windows.Forms.TextBox tbxFocus;
        private System.Windows.Forms.ComboBox cmbxMaritalStatus;
        private System.Windows.Forms.ComboBox cmbxGender;
    }
}