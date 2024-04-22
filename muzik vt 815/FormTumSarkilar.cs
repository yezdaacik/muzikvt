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
            CmbDoldur();
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

                int id = Convert.ToInt32(dgwTumSarkilar.SelectedRows[0].Cells["id"].Value);
                cmd.Parameters.AddWithValue("@satirid", id);

                cmd.ExecuteNonQuery();

                DgwDoldur();

            }
        }
        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT tur FROM sarkilar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbTur.DataSource = dt;

                cmbTur.DisplayMember = "tur";
                cmbTur.ValueMember = "tur";

            }
        }

        private void dgwTumSarkilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwTumSarkilar.SelectedRows.Count > 0)
            {
                txtAd.Text = dgwTumSarkilar.SelectedRows[0].Cells["ad"].Value.ToString();
                txtSanatci.Text = dgwTumSarkilar.SelectedRows[0].Cells["sanatci"].Value.ToString();
                txtSure.Text = dgwTumSarkilar.SelectedRows[0].Cells["sure"].Value.ToString();
                txtYil.Text = dgwTumSarkilar.SelectedRows[0].Cells["yil"].Value.ToString();
                dtTarih.Value = Convert.ToDateTime(dgwTumSarkilar.SelectedRows[0].Cells["eklenme_tarihi"].Value.ToString());
                cbFavori.Checked = Convert.ToBoolean(dgwTumSarkilar.SelectedRows[0].Cells["favori"].Value);
                cmbTur.SelectedValue = dgwTumSarkilar.SelectedRows[0].Cells["tur"].Value.ToString();
            }
        }

        private void dgwTumSarkilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = " SELECT * FROM sarkilar WHERE ad LIKE @aranan;";
            if (rbSanatci.Checked)
            {
                sorgu = "SELECT * FROM sarkilar WHERE sanatci LIKE @aranan;";
            }
          
            using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
            {
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@aranan","%" + txtArama.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwTumSarkilar.DataSource = dt;
            }
        }
    }
}



