using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace muzik_vt_815
{
    public partial class FormTumSarkilar : Form
    {
        string baglantimetin = "Server=localhost;Database=muzik;Uid=root;Pwd='';";
        public FormTumSarkilar()
        {
            InitializeComponent();
        }

        private void FormTumSarkilar_Load(object sender, EventArgs e)
        {
            DgwDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwTumSarkilar.SelectedRows[0];

            int satirId =Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Şarkıyı silmek istediğinizden emin misiniz?",
                                                 "Şarkıyı sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Error);

            if (cevap == DialogResult.Yes)
            {
   
                using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
                {
                    baglan.Open();
                    string sorgu = "DELETE FROM sarkilar WHERE id=@satirId;";                  
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@satirId", satirId);
                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }
            }
        }

        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM sarkilar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwTumSarkilar.DataSource = dt;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
            {
                baglan.Open();
                string sorgu = "UPDATE sarkilar SET ad=@sarkiad, sanatci = @sanatciad, yil = @yil, tur=@tur, sure= @sure, eklenme_tarihi = @tarih, favori= @favori WHERE id =@satirid;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@sarkiad", txtAd.Text);
                cmd.Parameters.AddWithValue("@sanatciad", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                cmd.Parameters.AddWithValue("@tarih", dtTarih.Value);
                cmd.Parameters.AddWithValue("@favori", cbFavori.Checked);

            }
        }
    }
}



