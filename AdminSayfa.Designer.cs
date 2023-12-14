namespace HastaneSistemi
{
    partial class AdminSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_doctorListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_doktorKayit = new System.Windows.Forms.Button();
            this.btn_depertmanListe = new System.Windows.Forms.Button();
            this.btn_departmanKayit = new System.Windows.Forms.Button();
            this.btn_hastaListe = new System.Windows.Forms.Button();
            this.btn_hastaKayit = new System.Windows.Forms.Button();
            this.btn_hastaGuncelle = new System.Windows.Forms.Button();
            this.btn_hastaBilgi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "HASTANE SİSTEMİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1149, 65);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "left-arrow.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(12, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 63);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            //this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "people.png");
            this.ımageList1.Images.SetKeyName(1, "geri.png");
            this.ımageList1.Images.SetKeyName(2, "arrow.png");
            this.ımageList1.Images.SetKeyName(3, "backward.png");
            this.ımageList1.Images.SetKeyName(4, "left-arrow.png");
            this.ımageList1.Images.SetKeyName(5, "doctor.png");
            this.ımageList1.Images.SetKeyName(6, "notes.png");
            this.ımageList1.Images.SetKeyName(7, "department.png");
            this.ımageList1.Images.SetKeyName(8, "departmentekle.png");
            this.ımageList1.Images.SetKeyName(9, "patient.png");
            this.ımageList1.Images.SetKeyName(10, "add-user.png");
            this.ımageList1.Images.SetKeyName(11, "patientadd.png");
            this.ımageList1.Images.SetKeyName(12, "data-processing.png");
            this.ımageList1.Images.SetKeyName(13, "personal-information.png");
            // 
            // btn_doctorListele
            // 
            this.btn_doctorListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_doctorListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctorListele.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_doctorListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctorListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doctorListele.ImageKey = "doctor.png";
            this.btn_doctorListele.ImageList = this.ımageList1;
            this.btn_doctorListele.Location = new System.Drawing.Point(12, 108);
            this.btn_doctorListele.Name = "btn_doctorListele";
            this.btn_doctorListele.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_doctorListele.Size = new System.Drawing.Size(300, 80);
            this.btn_doctorListele.TabIndex = 8;
            this.btn_doctorListele.Text = "Doktor Listele";
            this.btn_doctorListele.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_doktorKayit
            // 
            this.btn_doktorKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_doktorKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorKayit.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_doktorKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doktorKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doktorKayit.ImageKey = "notes.png";
            this.btn_doktorKayit.ImageList = this.ımageList1;
            this.btn_doktorKayit.Location = new System.Drawing.Point(12, 194);
            this.btn_doktorKayit.Name = "btn_doktorKayit";
            this.btn_doktorKayit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_doktorKayit.Size = new System.Drawing.Size(300, 80);
            this.btn_doktorKayit.TabIndex = 8;
            this.btn_doktorKayit.Text = "Doktor Kayıt";
            this.btn_doktorKayit.UseVisualStyleBackColor = false;
            // 
            // btn_depertmanListe
            // 
            this.btn_depertmanListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_depertmanListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depertmanListe.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_depertmanListe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_depertmanListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depertmanListe.ImageKey = "department.png";
            this.btn_depertmanListe.ImageList = this.ımageList1;
            this.btn_depertmanListe.Location = new System.Drawing.Point(12, 280);
            this.btn_depertmanListe.Name = "btn_depertmanListe";
            this.btn_depertmanListe.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btn_depertmanListe.Size = new System.Drawing.Size(300, 80);
            this.btn_depertmanListe.TabIndex = 8;
            this.btn_depertmanListe.Text = "Departman Listele";
            this.btn_depertmanListe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_depertmanListe.UseVisualStyleBackColor = false;
            // 
            // btn_departmanKayit
            // 
            this.btn_departmanKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_departmanKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_departmanKayit.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_departmanKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_departmanKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_departmanKayit.ImageKey = "departmentekle.png";
            this.btn_departmanKayit.ImageList = this.ımageList1;
            this.btn_departmanKayit.Location = new System.Drawing.Point(12, 366);
            this.btn_departmanKayit.Name = "btn_departmanKayit";
            this.btn_departmanKayit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_departmanKayit.Size = new System.Drawing.Size(300, 80);
            this.btn_departmanKayit.TabIndex = 8;
            this.btn_departmanKayit.Text = "Departman Kayıt";
            this.btn_departmanKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_departmanKayit.UseVisualStyleBackColor = false;
            // 
            // btn_hastaListe
            // 
            this.btn_hastaListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_hastaListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hastaListe.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastaListe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hastaListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hastaListe.ImageKey = "patient.png";
            this.btn_hastaListe.ImageList = this.ımageList1;
            this.btn_hastaListe.Location = new System.Drawing.Point(830, 108);
            this.btn_hastaListe.Name = "btn_hastaListe";
            this.btn_hastaListe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_hastaListe.Size = new System.Drawing.Size(300, 80);
            this.btn_hastaListe.TabIndex = 8;
            this.btn_hastaListe.Text = "Hasta Listele";
            this.btn_hastaListe.UseVisualStyleBackColor = false;
            this.btn_hastaListe.Click += new System.EventHandler(this.btn_hastaListe_Click);
            // 
            // btn_hastaKayit
            // 
            this.btn_hastaKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_hastaKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hastaKayit.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastaKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hastaKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hastaKayit.ImageKey = "patientadd.png";
            this.btn_hastaKayit.ImageList = this.ımageList1;
            this.btn_hastaKayit.Location = new System.Drawing.Point(830, 194);
            this.btn_hastaKayit.Name = "btn_hastaKayit";
            this.btn_hastaKayit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_hastaKayit.Size = new System.Drawing.Size(300, 80);
            this.btn_hastaKayit.TabIndex = 8;
            this.btn_hastaKayit.Text = "Hasta Kayıt";
            this.btn_hastaKayit.UseVisualStyleBackColor = false;
            this.btn_hastaKayit.Click += new System.EventHandler(this.btn_hastaKayit_Click);
            // 
            // btn_hastaGuncelle
            // 
            this.btn_hastaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_hastaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hastaGuncelle.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastaGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hastaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hastaGuncelle.ImageKey = "data-processing.png";
            this.btn_hastaGuncelle.ImageList = this.ımageList1;
            this.btn_hastaGuncelle.Location = new System.Drawing.Point(830, 280);
            this.btn_hastaGuncelle.Name = "btn_hastaGuncelle";
            this.btn_hastaGuncelle.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btn_hastaGuncelle.Size = new System.Drawing.Size(300, 80);
            this.btn_hastaGuncelle.TabIndex = 8;
            this.btn_hastaGuncelle.Text = "Hasta Güncelle-Sil";
            this.btn_hastaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hastaGuncelle.UseVisualStyleBackColor = false;
            // 
            // btn_hastaBilgi
            // 
            this.btn_hastaBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btn_hastaBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hastaBilgi.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastaBilgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hastaBilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hastaBilgi.ImageKey = "personal-information.png";
            this.btn_hastaBilgi.ImageList = this.ımageList1;
            this.btn_hastaBilgi.Location = new System.Drawing.Point(830, 366);
            this.btn_hastaBilgi.Name = "btn_hastaBilgi";
            this.btn_hastaBilgi.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_hastaBilgi.Size = new System.Drawing.Size(300, 80);
            this.btn_hastaBilgi.TabIndex = 8;
            this.btn_hastaBilgi.Text = "Hasta Bilgileri";
            this.btn_hastaBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hastaBilgi.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(985, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Admin Panel";
            // 
            // AdminSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1142, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_hastaBilgi);
            this.Controls.Add(this.btn_hastaGuncelle);
            this.Controls.Add(this.btn_departmanKayit);
            this.Controls.Add(this.btn_hastaKayit);
            this.Controls.Add(this.btn_depertmanListe);
            this.Controls.Add(this.btn_hastaListe);
            this.Controls.Add(this.btn_doktorKayit);
            this.Controls.Add(this.btn_doctorListele);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminSayfa";
            this.Text = "AdminSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
        private ImageList ımageList1;
        private Button btn_doctorListele;
        private PictureBox pictureBox1;
        private Button btn_doktorKayit;
        private Button btn_depertmanListe;
        private Button btn_departmanKayit;
        private Button btn_hastaListe;
        private Button btn_hastaKayit;
        private Button btn_hastaGuncelle;
        private Button btn_hastaBilgi;
        private Label label2;
    }
}