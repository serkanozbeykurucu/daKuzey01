using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace daKuzey01
{
    public partial class Urunfrm : Form
    {
        public Urunfrm()
        {
            InitializeComponent();
        }

        private void btnekleado_Click(object sender, EventArgs e)
        {
            // baglanti stringi oluştur
            string constr = "Server=10.10.89.4;Database=Northwind;User Id=sa;Password=sanane;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string strkomut = "insert into Urunler(UrunAdi,BirimFiyati) values(@vurunad,@fiyat)";

            SqlCommand komutekle = new SqlCommand(strkomut,conn);
            komutekle.Parameters.AddWithValue("@vurunad",txturunad.Text);
            komutekle.Parameters.AddWithValue("@fiyat", nbirimfiyat.Value);
            komutekle.ExecuteNonQuery();
            // kayıt ekleme bitti tablodaki son durum gride aktarılıyor

            grdtazele();
           

            conn.Close();
        }

        private void btnekleadosp_Click(object sender, EventArgs e)
        {
         

        }


        void grdtazele()
        {
              // baglanti stringi oluştur
            string constr = "Server=10.10.89.4;Database=Northwind;User Id=sa;Password=sanane;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string sondurum = "select * from Urunler order by UrunID desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum, conn);
            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgurun.DataSource = dt;
            conn.Close();

        }


    }
}
