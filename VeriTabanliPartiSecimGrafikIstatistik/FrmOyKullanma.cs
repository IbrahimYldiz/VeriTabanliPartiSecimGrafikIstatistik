using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabanliPartiSecimGrafikIstatistik
{
    public partial class FrmOyKullanma : Form
    {
        public FrmOyKullanma()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void BtnOyKullan_Click(object sender, EventArgs e)
        {
            if (CmbIlceAdi.Text.Trim() != "" && CmbParti.Text.Trim() != "" && textBox1.Text.Trim() != "")
            {
                bgl.Open();
                

                


                if (label4.Text == "A Parti")
                {
                    SqlCommand komut1 = new SqlCommand("update TbLInce set AParti=@p7 where IlceAdi=@p6", bgl);
                    komut1.Parameters.AddWithValue("@p6", label5.Text);
                    komut1.Parameters.AddWithValue("@p7", textBox1.Text);
                    komut1.ExecuteNonQuery();

                }
                if (label4.Text == "B Parti")
                {
                    SqlCommand komut2 = new SqlCommand("update TbLInce set BParti=@p2 where IlceAdi=@p6", bgl);
                    komut2.Parameters.AddWithValue("@p6", label5.Text);
                    komut2.Parameters.AddWithValue("@p2", textBox1.Text);
                    komut2.ExecuteNonQuery();
                }
                if (label4.Text == "C Parti")
                {
                    SqlCommand komut3 = new SqlCommand("CParti=@p3 where IlceAdi=@p6", bgl);
                    komut3.Parameters.AddWithValue("@p6", label5.Text);
                    komut3.Parameters.AddWithValue("@p3", textBox1.Text);
                    komut3.ExecuteNonQuery();
                }
                if (label4.Text == "D Parti")
                {
                    SqlCommand komut4 = new SqlCommand("update TbLInce set DParti=@p4 where IlceAdi=@p6", bgl);
                    komut4.Parameters.AddWithValue("@p6", label5.Text);
                    komut4.Parameters.AddWithValue("@p4", textBox1.Text);
                    komut4.ExecuteNonQuery();
                }
                if (label4.Text == "E Parti")
                {
                    SqlCommand komut5 = new SqlCommand("update TbLInce set EParti=@p5 where IlceAdi=@p6", bgl);
                    komut5.Parameters.AddWithValue("@p6", label5.Text);
                    komut5.Parameters.AddWithValue("@p5", textBox1.Text);
                    komut5.ExecuteNonQuery();
                }
              
                bgl.Close();
                MessageBox.Show(CmbIlceAdi.Text + " " + CmbParti.Text + " Girişi Başarılı Şekilde Kayıt Edildi");
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Değerleri Doldurunuz");
            }
        }

        private void FrmOyKullanma_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut1 = new SqlCommand("Select * from TbLInce", bgl);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                CmbIlceAdi.Items.Add(dr[1]);
            }

            bgl.Close();
        }

        private void CmbParti_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = CmbParti.Text.Trim();
        }

        private void CmbIlceAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = CmbIlceAdi.Text.Trim();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
            this.Hide();
        }
    }
}
