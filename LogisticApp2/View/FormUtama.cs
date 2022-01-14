using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticApp2.View
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
            this.Hide();
        }

        private void dataCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
            this.Hide();
        }

        private void infoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void infoKantorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKantor formKantor = new FormKantor();
            formKantor.Show();
            this.Hide();
        }

        private void barangTerkirimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
            this.Hide();
        }

        private void infoAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoAplikasi formInfoAplikasi = new FormInfoAplikasi();
            formInfoAplikasi.Show();
            this.Hide();
        }

        private void dataTagihanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTagihan formTagihan = new FormTagihan();
            formTagihan.Show();
            this.Hide();
        }

        private void laporanTagihanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanTagihan formLaporanTagihan = new FormLaporanTagihan();
            formLaporanTagihan.Show();
            this.Hide();
        }
    }
}
