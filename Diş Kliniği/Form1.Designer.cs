namespace Diş_Kliniği
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KullaniciTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ParolaTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lbldurum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(32, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(32, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parola";
            // 
            // KullaniciTb
            // 
            this.KullaniciTb.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciTb.BorderColor = System.Drawing.Color.White;
            this.KullaniciTb.BorderRadius = 10;
            this.KullaniciTb.BorderThickness = 2;
            this.KullaniciTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KullaniciTb.DefaultText = "";
            this.KullaniciTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KullaniciTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KullaniciTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KullaniciTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KullaniciTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.KullaniciTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KullaniciTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.KullaniciTb.ForeColor = System.Drawing.Color.Black;
            this.KullaniciTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KullaniciTb.Location = new System.Drawing.Point(168, 344);
            this.KullaniciTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KullaniciTb.Name = "KullaniciTb";
            this.KullaniciTb.PlaceholderText = "";
            this.KullaniciTb.SelectedText = "";
            this.KullaniciTb.Size = new System.Drawing.Size(253, 27);
            this.KullaniciTb.TabIndex = 2;
            this.KullaniciTb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // ParolaTb
            // 
            this.ParolaTb.BackColor = System.Drawing.Color.Transparent;
            this.ParolaTb.BorderColor = System.Drawing.Color.White;
            this.ParolaTb.BorderRadius = 10;
            this.ParolaTb.BorderThickness = 2;
            this.ParolaTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ParolaTb.DefaultText = "";
            this.ParolaTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ParolaTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ParolaTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ParolaTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ParolaTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ParolaTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ParolaTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ParolaTb.ForeColor = System.Drawing.Color.Black;
            this.ParolaTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ParolaTb.Location = new System.Drawing.Point(168, 379);
            this.ParolaTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParolaTb.Name = "ParolaTb";
            this.ParolaTb.PlaceholderText = "";
            this.ParolaTb.SelectedText = "";
            this.ParolaTb.Size = new System.Drawing.Size(253, 27);
            this.ParolaTb.TabIndex = 2;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton1.BorderRadius = 20;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(168, 445);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "Giriş Yap";
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(86, 53);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(322, 255);
            this.pictureEdit1.TabIndex = 4;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // lbldurum
            // 
            this.lbldurum.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbldurum.Appearance.Options.UseForeColor = true;
            this.lbldurum.Location = new System.Drawing.Point(177, 510);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(0, 13);
            this.lbldurum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Diş_Kliniği.Properties.Resources._20250618_1951_Premium_Arka_Plan_simple_compose_01jy1z6fk2ed89107xt2ctfhp5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 544);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.ParolaTb);
            this.Controls.Add(this.KullaniciTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox KullaniciTb;
        private Guna.UI2.WinForms.Guna2TextBox ParolaTb;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lbldurum;
    }
}

