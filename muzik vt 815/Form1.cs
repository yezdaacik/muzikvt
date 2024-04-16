using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muzik_vt_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleForm_Click(object sender, EventArgs e)
        {
            FormSarkiEkle formSarkiEkle = new FormSarkiEkle();
            formSarkiEkle.ShowDialog();
        }

        private void btnTumSarkilar_Click(object sender, EventArgs e)
        {
            FormTumSarkilar formTumSarkilar = new FormTumSarkilar();
            formTumSarkilar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
