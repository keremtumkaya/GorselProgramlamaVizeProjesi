namespace SiteEmlakTakibi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsite = new System.Windows.Forms.ComboBox();
            this.cmbsat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmetre = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbblok = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnzambak = new System.Windows.Forms.Button();
            this.btngul = new System.Windows.Forms.Button();
            this.btnmenekse = new System.Windows.Forms.Button();
            this.btnpapatya = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngoruntule = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gayrimenkul Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site :";
            // 
            // cmbsite
            // 
            this.cmbsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbsite.FormattingEnabled = true;
            this.cmbsite.Items.AddRange(new object[] {
            "Zambak Sitesi",
            "Papatya Sitesi",
            "Gül Sitesi",
            "Menekşe Sitesi"});
            this.cmbsite.Location = new System.Drawing.Point(179, 108);
            this.cmbsite.Name = "cmbsite";
            this.cmbsite.Size = new System.Drawing.Size(169, 30);
            this.cmbsite.TabIndex = 2;
            this.cmbsite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbsat
            // 
            this.cmbsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbsat.FormattingEnabled = true;
            this.cmbsat.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cmbsat.Location = new System.Drawing.Point(179, 173);
            this.cmbsat.Name = "cmbsat";
            this.cmbsat.Size = new System.Drawing.Size(169, 30);
            this.cmbsat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sat / Kira :";
            // 
            // cmboda
            // 
            this.cmboda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboda.FormattingEnabled = true;
            this.cmboda.Items.AddRange(new object[] {
            "1+1",
            "2+1\t",
            "3+1",
            "4+1",
            "5+1",
            "5+2"});
            this.cmboda.Location = new System.Drawing.Point(179, 241);
            this.cmboda.Name = "cmboda";
            this.cmboda.Size = new System.Drawing.Size(169, 30);
            this.cmboda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Metrekare :";
            // 
            // txtmetre
            // 
            this.txtmetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmetre.Location = new System.Drawing.Point(179, 316);
            this.txtmetre.Name = "txtmetre";
            this.txtmetre.Size = new System.Drawing.Size(169, 28);
            this.txtmetre.TabIndex = 8;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.Location = new System.Drawing.Point(179, 389);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(169, 28);
            this.txtfiyat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fiyat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(622, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(635, 86);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(189, 28);
            this.txtad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(484, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad :";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(635, 150);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(189, 28);
            this.txttel.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(484, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon :";
            // 
            // txtnot
            // 
            this.txtnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnot.Location = new System.Drawing.Point(635, 218);
            this.txtnot.Multiline = true;
            this.txtnot.Name = "txtnot";
            this.txtnot.Size = new System.Drawing.Size(189, 174);
            this.txtnot.TabIndex = 19;
            this.txtnot.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(484, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 31);
            this.label11.TabIndex = 18;
            this.label11.Text = "Notlar :";
            // 
            // cmbblok
            // 
            this.cmbblok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbblok.FormattingEnabled = true;
            this.cmbblok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbblok.Location = new System.Drawing.Point(119, 464);
            this.cmbblok.Name = "cmbblok";
            this.cmbblok.Size = new System.Drawing.Size(67, 30);
            this.cmbblok.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Blok :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(201, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "No :";
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtno.Location = new System.Drawing.Point(272, 466);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(76, 28);
            this.txtno.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(1156, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 31);
            this.label13.TabIndex = 24;
            this.label13.Text = "Site ";
            // 
            // btnzambak
            // 
            this.btnzambak.BackColor = System.Drawing.Color.Gray;
            this.btnzambak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnzambak.Location = new System.Drawing.Point(1121, 38);
            this.btnzambak.Name = "btnzambak";
            this.btnzambak.Size = new System.Drawing.Size(141, 88);
            this.btnzambak.TabIndex = 25;
            this.btnzambak.Text = "ZAMBAK";
            this.btnzambak.UseVisualStyleBackColor = false;
            // 
            // btngul
            // 
            this.btngul.BackColor = System.Drawing.Color.Gray;
            this.btngul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngul.Location = new System.Drawing.Point(993, 131);
            this.btngul.Name = "btngul";
            this.btngul.Size = new System.Drawing.Size(132, 88);
            this.btngul.TabIndex = 26;
            this.btngul.Text = "GÜL";
            this.btngul.UseVisualStyleBackColor = false;
            // 
            // btnmenekse
            // 
            this.btnmenekse.BackColor = System.Drawing.Color.Gray;
            this.btnmenekse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmenekse.Location = new System.Drawing.Point(1121, 225);
            this.btnmenekse.Name = "btnmenekse";
            this.btnmenekse.Size = new System.Drawing.Size(141, 88);
            this.btnmenekse.TabIndex = 27;
            this.btnmenekse.Text = "MENEKŞE";
            this.btnmenekse.UseVisualStyleBackColor = false;
            // 
            // btnpapatya
            // 
            this.btnpapatya.BackColor = System.Drawing.Color.Gray;
            this.btnpapatya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpapatya.Location = new System.Drawing.Point(1249, 131);
            this.btnpapatya.Name = "btnpapatya";
            this.btnpapatya.Size = new System.Drawing.Size(145, 88);
            this.btnpapatya.TabIndex = 28;
            this.btnpapatya.Text = "PAPATYA";
            this.btnpapatya.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(26, 602);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1221, 340);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İd";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Site";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Metre";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Blok";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No";
            this.columnHeader7.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ad Soyad";
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telefon";
            this.columnHeader9.Width = 87;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Notlar";
            this.columnHeader10.Width = 99;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SatKira";
            this.columnHeader11.Width = 122;
            // 
            // btngoruntule
            // 
            this.btngoruntule.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoruntule.Location = new System.Drawing.Point(26, 528);
            this.btngoruntule.Name = "btngoruntule";
            this.btngoruntule.Size = new System.Drawing.Size(134, 49);
            this.btngoruntule.TabIndex = 30;
            this.btngoruntule.Text = "Görüntüle";
            this.btngoruntule.UseVisualStyleBackColor = true;
            this.btngoruntule.Click += new System.EventHandler(this.btngoruntule_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduzelt.Location = new System.Drawing.Point(733, 528);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(134, 49);
            this.btnduzelt.TabIndex = 31;
            this.btnduzelt.Text = "Düzenle";
            this.btnduzelt.UseVisualStyleBackColor = true;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(490, 528);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(134, 49);
            this.btnsil.TabIndex = 32;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(264, 528);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(134, 49);
            this.btnkaydet.TabIndex = 33;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(179, 60);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(169, 28);
            this.txtid.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(28, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 31);
            this.label14.TabIndex = 34;
            this.label14.Text = "İD :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(966, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 36;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiteEmlakTakibi.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(1431, 954);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btngoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnpapatya);
            this.Controls.Add(this.btnmenekse);
            this.Controls.Add(this.btngul);
            this.Controls.Add(this.btnzambak);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbblok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmetre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbsat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbsite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Gayrimenkul Kayıt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsite;
        private System.Windows.Forms.ComboBox cmbsat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmetre;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbblok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnzambak;
        private System.Windows.Forms.Button btngul;
        private System.Windows.Forms.Button btnmenekse;
        private System.Windows.Forms.Button btnpapatya;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btngoruntule;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}