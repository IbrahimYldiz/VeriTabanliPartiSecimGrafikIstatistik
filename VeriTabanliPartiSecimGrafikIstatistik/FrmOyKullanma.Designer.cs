﻿
namespace VeriTabanliPartiSecimGrafikIstatistik
{
    partial class FrmOyKullanma
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
            this.CmbIlceAdi = new System.Windows.Forms.ComboBox();
            this.CmbParti = new System.Windows.Forms.ComboBox();
            this.BtnOyKullan = new System.Windows.Forms.Button();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(76, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parti:";
            // 
            // CmbIlceAdi
            // 
            this.CmbIlceAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIlceAdi.FormattingEnabled = true;
            this.CmbIlceAdi.Location = new System.Drawing.Point(139, 26);
            this.CmbIlceAdi.Name = "CmbIlceAdi";
            this.CmbIlceAdi.Size = new System.Drawing.Size(266, 33);
            this.CmbIlceAdi.TabIndex = 2;
            this.CmbIlceAdi.SelectedIndexChanged += new System.EventHandler(this.CmbIlceAdi_SelectedIndexChanged);
            // 
            // CmbParti
            // 
            this.CmbParti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParti.FormattingEnabled = true;
            this.CmbParti.Items.AddRange(new object[] {
            "A Parti",
            "B Parti",
            "C Parti",
            "D Parti",
            "E Parti"});
            this.CmbParti.Location = new System.Drawing.Point(139, 65);
            this.CmbParti.Name = "CmbParti";
            this.CmbParti.Size = new System.Drawing.Size(266, 33);
            this.CmbParti.TabIndex = 3;
            this.CmbParti.SelectedIndexChanged += new System.EventHandler(this.CmbParti_SelectedIndexChanged);
            // 
            // BtnOyKullan
            // 
            this.BtnOyKullan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.BtnOyKullan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOyKullan.Location = new System.Drawing.Point(139, 140);
            this.BtnOyKullan.Name = "BtnOyKullan";
            this.BtnOyKullan.Size = new System.Drawing.Size(266, 39);
            this.BtnOyKullan.TabIndex = 4;
            this.BtnOyKullan.Text = "Oy Girişi Yap";
            this.BtnOyKullan.UseVisualStyleBackColor = false;
            this.BtnOyKullan.Click += new System.EventHandler(this.BtnOyKullan_Click);
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.BtnGrafikler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGrafikler.Location = new System.Drawing.Point(275, 185);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(130, 39);
            this.BtnGrafikler.TabIndex = 6;
            this.BtnGrafikler.Text = "Grafikler";
            this.BtnGrafikler.UseVisualStyleBackColor = false;
            this.BtnGrafikler.Click += new System.EventHandler(this.BtnGrafikler_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.BtnCikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCikis.Location = new System.Drawing.Point(139, 185);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(130, 39);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "Çıkış Yap";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oy Sayısı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 30);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(53, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // FrmOyKullanma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(500, 255);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGrafikler);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnOyKullan);
            this.Controls.Add(this.CmbParti);
            this.Controls.Add(this.CmbIlceAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOyKullanma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmOyKullanma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbIlceAdi;
        private System.Windows.Forms.ComboBox CmbParti;
        private System.Windows.Forms.Button BtnOyKullan;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

