﻿
namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.LblAdSoyadd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyadd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC No :";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(124, 27);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 1;
            this.LblTC.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchSikayet);
            this.groupBox2.Location = new System.Drawing.Point(0, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 191);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // RchSikayet
            // 
            this.RchSikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchSikayet.Location = new System.Drawing.Point(3, 27);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(278, 161);
            this.RchSikayet.TabIndex = 5;
            this.RchSikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(290, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 412);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCikis);
            this.groupBox4.Controls.Add(this.BtnDuyurular);
            this.groupBox4.Controls.Add(this.BtnGuncelle);
            this.groupBox4.Location = new System.Drawing.Point(6, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 107);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(6, 67);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(263, 37);
            this.BtnCikis.TabIndex = 4;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(153, 30);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(116, 37);
            this.BtnDuyurular.TabIndex = 2;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = false;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(6, 30);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(141, 37);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.Text = "Bilgi Düzenle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // LblAdSoyadd
            // 
            this.LblAdSoyadd.AutoSize = true;
            this.LblAdSoyadd.Location = new System.Drawing.Point(124, 62);
            this.LblAdSoyadd.Name = "LblAdSoyadd";
            this.LblAdSoyadd.Size = new System.Drawing.Size(120, 23);
            this.LblAdSoyadd.TabIndex = 3;
            this.LblAdSoyadd.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad :";
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(839, 436);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnDuyurular;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label LblAdSoyadd;
        private System.Windows.Forms.Label label3;
    }
}