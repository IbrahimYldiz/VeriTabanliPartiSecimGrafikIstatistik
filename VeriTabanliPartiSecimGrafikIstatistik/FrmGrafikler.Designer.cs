
namespace VeriTabanliPartiSecimGrafikIstatistik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrbAParti = new System.Windows.Forms.ProgressBar();
            this.PrbBParti = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PrbCParti = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PrbDParti = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.PrbEParti = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(98, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1139, 395);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.PrbEParti);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PrbDParti);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PrbCParti);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PrbBParti);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PrbAParti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1237, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlçe Seçin:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "A Parti:";
            // 
            // PrbAParti
            // 
            this.PrbAParti.Location = new System.Drawing.Point(202, 117);
            this.PrbAParti.Maximum = 200;
            this.PrbAParti.Name = "PrbAParti";
            this.PrbAParti.Size = new System.Drawing.Size(334, 35);
            this.PrbAParti.TabIndex = 4;
            // 
            // PrbBParti
            // 
            this.PrbBParti.Location = new System.Drawing.Point(202, 158);
            this.PrbBParti.Maximum = 200;
            this.PrbBParti.Name = "PrbBParti";
            this.PrbBParti.Size = new System.Drawing.Size(334, 35);
            this.PrbBParti.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "B Parti:";
            // 
            // PrbCParti
            // 
            this.PrbCParti.Location = new System.Drawing.Point(202, 199);
            this.PrbCParti.Maximum = 200;
            this.PrbCParti.Name = "PrbCParti";
            this.PrbCParti.Size = new System.Drawing.Size(334, 35);
            this.PrbCParti.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "C Parti:";
            // 
            // PrbDParti
            // 
            this.PrbDParti.Location = new System.Drawing.Point(202, 240);
            this.PrbDParti.Maximum = 200;
            this.PrbDParti.Name = "PrbDParti";
            this.PrbDParti.Size = new System.Drawing.Size(334, 35);
            this.PrbDParti.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "D Parti:";
            // 
            // PrbEParti
            // 
            this.PrbEParti.Location = new System.Drawing.Point(202, 281);
            this.PrbEParti.Maximum = 200;
            this.PrbEParti.Name = "PrbEParti";
            this.PrbEParti.Size = new System.Drawing.Size(334, 35);
            this.PrbEParti.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "E Parti:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(542, 127);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(23, 25);
            this.LblA.TabIndex = 13;
            this.LblA.Text = "0";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(542, 163);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(23, 25);
            this.LblB.TabIndex = 14;
            this.LblB.Text = "0";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(542, 204);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(23, 25);
            this.LblC.TabIndex = 15;
            this.LblC.Text = "0";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(542, 245);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(23, 25);
            this.LblD.TabIndex = 16;
            this.LblD.Text = "0";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(542, 286);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(23, 25);
            this.LblE.TabIndex = 17;
            this.LblE.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1007, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1261, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.ProgressBar PrbEParti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PrbDParti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar PrbCParti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PrbBParti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PrbAParti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}