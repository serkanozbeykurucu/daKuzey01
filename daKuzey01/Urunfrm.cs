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
        // baglanti stringi oluştur

        public string constr = "Server=10.10.89.4;Database=Northwind;User Id=sa;Password=sanane;";

        public Urunfrm()
        {
            InitializeComponent();
        }

        private void btnekleado_Click(object sender, EventArgs e)
        {
           
           
            SqlConnection conn = new SqlConnection(constr);
            
            conn.Open();

            string strkomut = "insert into Urunler(UrunAdi,BirimFiyati,TedarikciID,KategoriID) " +
                "values(@vurunad,@fiyat,@vted,@vkat)";

            SqlCommand komutekle = new SqlCommand(strkomut,conn);
            komutekle.Parameters.AddWithValue("@vurunad",txturunad.Text);
            komutekle.Parameters.AddWithValue("@fiyat", nbirimfiyat.Value);
            komutekle.Parameters.AddWithValue("@vted", cmbtedarik.SelectedValue);
            komutekle.Parameters.AddWithValue("@vkat", cmbkategori.SelectedValue);


            komutekle.ExecuteNonQuery();
            // kayıt ekleme bitti tablodaki son durum gride aktarılıyor

            grdtazele();
           

            conn.Close();
        }

        private void btnekleadosp_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "spurunekle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vurunad",txturunad.Text);
            cmd.Parameters.AddWithValue("@vfiyat", nbirimfiyat.Value);
            
            cmd.Parameters.AddWithValue("@vtedid", cmbtedarik.SelectedValue);
            cmd.Parameters.AddWithValue("@vkatid", cmbkategori.SelectedValue);

            cmd.ExecuteNonQuery();
            conn.Close();

            grdtazele();

        }


        void grdtazele()
        {
              // baglanti stringi oluştur
           
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string sondurum = "select * from Urunler order by UrunID desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum, conn);
            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgurun.DataSource = dt;
            conn.Close();

        }

        void cmbdoldur()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();


            string strted = "Select * from Tedarikciler order by SirketAdi";
            SqlDataAdapter sdp = new SqlDataAdapter(strted,conn);
            DataTable dttedarik = new DataTable();
            sdp.Fill(dttedarik);
            cmbtedarik.DisplayMember = "SirketAdi";
            cmbtedarik.ValueMember = "TedarikciID";
            cmbtedarik.DataSource = dttedarik;


            string strkat = "Select * from Kategoriler order by KategoriAdi";
            SqlDataAdapter sdpkat = new SqlDataAdapter(strkat, conn);
            DataTable dtkat = new DataTable();
            sdpkat.Fill(dtkat);
            cmbkategori.DisplayMember = "KategoriAdi";
            cmbkategori.ValueMember = "KategoriID";
            cmbkategori.DataSource = dtkat;







            conn.Close();


        }

        private void btnekleentity_Click(object sender, EventArgs e)
        {

        }

        private void Urunfrm_Load(object sender, EventArgs e)
        {
            cmbdoldur();
            grdtazele();
        }

        private void btnsilado_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(constr);
            baglan.Open();

            SqlCommand komutsil = new SqlCommand();
            komutsil.Connection = baglan;
            //int silinecek = dgurun.CurrentRow.Cells[0].Value;
            komutsil.CommandText = "delete from Urunler where UrunID="+ dgurun.CurrentRow.Cells[0].Value;

            komutsil.ExecuteNonQuery();

            baglan.Close();
            grdtazele();

            //test
//tes2
        }


    }
}
