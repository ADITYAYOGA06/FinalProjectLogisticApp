using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticApp2.View;
using LogisticApp2.Controller;
using LogisticApp2.Model.Entity;

namespace LogisticApp2.View
{
    public partial class FormTagihan : Form
    {
        private List<Tagihan> listOfTagihan = new List<Tagihan>();

        private TagihanController controller;

        public FormTagihan()
        {
            InitializeComponent();
            controller = new TagihanController();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {

            lvwTagihan1.View = System.Windows.Forms.View.Details;
            lvwTagihan1.FullRowSelect = true;
            lvwTagihan1.GridLines = true;

            lvwTagihan1.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwTagihan1.Columns.Add("Id Tagihan", 85, HorizontalAlignment.Center);
            lvwTagihan1.Columns.Add("Id Barang", 85, HorizontalAlignment.Center);
            lvwTagihan1.Columns.Add("Biaya Kirim", 135, HorizontalAlignment.Center);
            lvwTagihan1.Columns.Add("Status", 75, HorizontalAlignment.Center);

            lvwTagihan2.View = System.Windows.Forms.View.Details;
            lvwTagihan2.FullRowSelect = true;
            lvwTagihan2.GridLines = true;

            lvwTagihan2.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwTagihan2.Columns.Add("Id Tagihan", 85, HorizontalAlignment.Center);
            lvwTagihan2.Columns.Add("Id Barang", 85, HorizontalAlignment.Center);
            lvwTagihan2.Columns.Add("Biaya Kirim", 135, HorizontalAlignment.Center);
            lvwTagihan2.Columns.Add("Status", 75, HorizontalAlignment.Center);

        }

        private void btnInsertTagihan_Click(object sender, EventArgs e)
        {
            Tagihan tagihan = new Tagihan();

            tagihan.IdTagihan = txtIdTagihanInsert.Text;
            tagihan.IdBarang = txtIdBarangInsert.Text;
            tagihan.Biaya = txtBiayaInsert.Text;
            tagihan.StatusTagihan = cmbStatusTagihanInsert.Text;

            var result = controller.Create(tagihan);

            txtIdTagihanInsert.Clear();
            txtIdBarangInsert.Clear();
            txtBiayaInsert.Clear();

            txtIdTagihanInsert.Focus();
        }

        private void btnTghMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }

        private void btnTghSupp_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
            this.Hide();
        }

        private void btnTghCust_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }

        private void btnTghBar_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
            this.Hide();
        }

        private void btnTghAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnTampilkanTgh1_Click(object sender, EventArgs e)
        {
            lvwTagihan1.Items.Clear();

            listOfTagihan = controller.ReadAll();

            foreach (var tagihan in listOfTagihan)
            {
                var noUrut = lvwTagihan1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tagihan.IdTagihan);
                item.SubItems.Add(tagihan.IdBarang);
                item.SubItems.Add(tagihan.Biaya);
                item.SubItems.Add(tagihan.StatusTagihan);

                lvwTagihan1.Items.Add(item);
            }
        }

        private void btnTampilkanTgh2_Click(object sender, EventArgs e)
        {
            lvwTagihan2.Items.Clear();

            listOfTagihan = controller.ReadAll();

            foreach (var tagihan in listOfTagihan)
            {
                var noUrut = lvwTagihan2.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tagihan.IdTagihan);
                item.SubItems.Add(tagihan.IdBarang);
                item.SubItems.Add(tagihan.Biaya);
                item.SubItems.Add(tagihan.StatusTagihan);

                lvwTagihan2.Items.Add(item);
            }
        }

        private void btnCariTghUpdate_Click(object sender, EventArgs e)
        {
            string cariId = txtIdTagihanUpdate.Text;

            listOfTagihan = controller.ReadById(cariId);

            foreach (var tagihan in listOfTagihan)
            {
                txtIdTagihanUpdate.Text = tagihan.IdTagihan.ToString();
                txtIdBarangUpdate.Text = tagihan.IdBarang.ToString();
                txtBiayaUpdate.Text = tagihan.Biaya.ToString();            
            }
        }

        private void btnUpdateTagihan_Click(object sender, EventArgs e)
        {
            Tagihan tagihan = new Tagihan();

            tagihan.IdTagihan = txtIdTagihanUpdate.Text;
            tagihan.IdBarang = txtIdBarangUpdate.Text;
            tagihan.Biaya = txtBiayaUpdate.Text;
            tagihan.StatusTagihan = cmbStatusTagihanUpdate.Text;

            var result = controller.Update(tagihan);

            txtIdTagihanUpdate.Clear();
            txtIdBarangUpdate.Clear();
            txtBiayaUpdate.Clear();

            txtIdTagihanUpdate.Focus();
        }

        private void btnTghTgh_Click(object sender, EventArgs e)
        {

        }
    }
}
