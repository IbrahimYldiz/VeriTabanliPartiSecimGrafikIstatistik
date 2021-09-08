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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut1 = new SqlCommand("Select IlceAdi from TbLInce", bgl);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            bgl.Close();

            //Grafiğe Sonuçları Getirme
            bgl.Open();
            SqlCommand sqlCommand = new SqlCommand("Select Sum(AParti),sum(BParti),sum(CParti),sum(DParti),sum(EParti) from TbLInce", bgl);
            SqlDataReader dr2 = sqlCommand.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti",dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Part", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Part", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Part", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Part", dr2[4]);
            }
            bgl.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from TbLInce where IlceAdi=@p1", bgl);
            label7.Text = comboBox1.Text.Trim();
            komut.Parameters.AddWithValue("@p1",label7.Text );
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                PrbAParti.Value = Convert.ToInt32(dr[2].ToString());
                LblA.Text = dr[2].ToString();
                PrbBParti.Value = Convert.ToInt32(dr[3].ToString());
                LblB.Text = dr[3].ToString();
                PrbCParti.Value = Convert.ToInt32(dr[4].ToString());
                LblC.Text = dr[4].ToString();
                PrbDParti.Value = Convert.ToInt32(dr[5].ToString());
                LblD.Text = dr[5].ToString();
                PrbEParti.Value = Convert.ToInt32(dr[6].ToString());
                LblE.Text = dr[6].ToString();
            }
            bgl.Close();
        }
    }
}
