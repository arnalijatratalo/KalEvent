using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorbaru
{
    public partial class FormKalkulatorOperasi : Form
    {
        public delegate void CreateUpdateEventHandler(Kalkulator klk);
        public event FormKalkulatorOperasi.CreateUpdateEventHandler OnCreate;
        private Kalkulator kalkulatorHmm;


        public FormKalkulatorOperasi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            kalkulatorHmm = new Kalkulator();
            kalkulatorHmm.nama = this.cmbOperasi.Text.ToLower();
            kalkulatorHmm.operasi = string.Empty;
            kalkulatorHmm.hasils = 0;
            kalkulatorHmm.a = Double.Parse(this.txtNilaiA.Text);
            kalkulatorHmm.b = Double.Parse(this.txtNilaiB.Text);


            if (this.cmbOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan Pilih Dulu Operasinya!!!");
            }
            else if (this.cmbOperasi.SelectedIndex == 0)
            {
                kalkulatorHmm.hasils = kalkulatorHmm.a + kalkulatorHmm.b;
                kalkulatorHmm.operasi = "+";

            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                kalkulatorHmm.hasils = kalkulatorHmm.a - kalkulatorHmm.b;
                kalkulatorHmm.operasi = "-";
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                kalkulatorHmm.hasils = kalkulatorHmm.a * kalkulatorHmm.b;
                kalkulatorHmm.operasi = "*";
            }
            else if (this.cmbOperasi.SelectedIndex == 3)
            {
                kalkulatorHmm.hasils = kalkulatorHmm.a / kalkulatorHmm.b;
                kalkulatorHmm.operasi = "/";
            }

            this.OnCreate(kalkulatorHmm);
        }
    }
}
