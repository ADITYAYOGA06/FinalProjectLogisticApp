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

namespace LogisticApp2
{
    public partial class FormBarang : Form
    {
        private List<Barang> listOfBarang = new List<Barang>();

        private BarangController controller;

        public FormBarang()
        {
            InitializeComponent();
            controller = new BarangController();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {

            lvwBarang1.View = System.Windows.Forms.View.Details;
            lvwBarang1.FullRowSelect = true;
            lvwBarang1.GridLines = true;

            lvwBarang1.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Nama Barang", 135, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Jenis Barang", 135, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Id Supplier", 75, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Id Customer", 75, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Id Admin", 75, HorizontalAlignment.Center);
            lvwBarang1.Columns.Add("Status", 75, HorizontalAlignment.Center);

            lvwBarang2.View = System.Windows.Forms.View.Details;
            lvwBarang2.FullRowSelect = true;
            lvwBarang2.GridLines = true;

            lvwBarang2.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Nama Barang", 135, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Jenis Barang", 135, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Id Supplier", 75, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Id Customer", 75, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Id Admin", 75, HorizontalAlignment.Center);
            lvwBarang2.Columns.Add("Status", 75, HorizontalAlignment.Center);

        }


        private void btnBarSupp_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
            this.Hide();
        }

        private void btnBarCust_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }

        private void btnBarAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnBarMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }

        private void btnInsertBarang_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();

            barang.IdBarang = txtIdBarangInsert.Text;
            barang.NamaBarang = txtNamaBarangInsert.Text;
            barang.JenisBarang = txtJenisBarangInsert.Text;
            barang.IdSupplier = txtIdSuppInsert.Text;
            barang.IdCustomer = txtIdCustInsert.Text;
            barang.IdAdmin = txtIdAdminInsert.Text;
            barang.Status = cmbStatusInsert.Text;

            var result = controller.Create(barang);

            txtIdBarangInsert.Clear();
            txtNamaBarangInsert.Clear();
            txtJenisBarangInsert.Clear();
            txtIdSuppInsert.Clear();
            txtIdCustInsert.Clear();
            txtIdAdminInsert.Clear();

            txtIdBarangInsert.Focus();
        }

        private void btnTampilkanBar1_Click(object sender, EventArgs e)
        {   
            
            lvwBarang1.Items.Clear();

            listOfBarang = controller.ReadAll();

            foreach(var barang in listOfBarang)
            {
                var noUrut = lvwBarang1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(barang.IdBarang);
                item.SubItems.Add(barang.NamaBarang);
                item.SubItems.Add(barang.JenisBarang);
                item.SubItems.Add(barang.IdSupplier);
                item.SubItems.Add(barang.IdCustomer);
                item.SubItems.Add(barang.IdAdmin);
                item.SubItems.Add(barang.Status);

                lvwBarang1.Items.Add(item);
            } 
        }

        private void btnTampilkanBar2_Click(object sender, EventArgs e)
        {
            lvwBarang2.Items.Clear();

            listOfBarang = controller.ReadAll();

            foreach (var barang in listOfBarang)
            {
                var noUrut = lvwBarang2.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(barang.IdBarang);
                item.SubItems.Add(barang.NamaBarang);
                item.SubItems.Add(barang.JenisBarang);
                item.SubItems.Add(barang.IdSupplier);
                item.SubItems.Add(barang.IdCustomer);
                item.SubItems.Add(barang.IdAdmin);
                item.SubItems.Add(barang.Status);

                lvwBarang2.Items.Add(item);
            }
        }

        private void btnCariBarUpdate_Click(object sender, EventArgs e)
        {
            string cariId = txtIdBarangUpdate.Text;

            listOfBarang = controller.ReadById(cariId);

            foreach(var barang in listOfBarang)
            {
                txtIdBarangUpdate.Text = barang.IdBarang.ToString();
                txtNamaBarangUpdate.Text = barang.NamaBarang.ToString();
                txtJenisBarangUpdate.Text = barang.JenisBarang.ToString();
                txtIdSuppUpdate.Text = barang.IdSupplier.ToString();
                txtIdCustUpdate.Text = barang.IdCustomer.ToString();
                txtIdAdminUpdate.Text = barang.IdAdmin.ToString();
                //txtStatusUpdate.Text = barang.Status.ToString();
            }

        }

        private void btnUpdateBarang_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();

            barang.IdBarang = txtIdBarangUpdate.Text;
            barang.NamaBarang = txtNamaBarangUpdate.Text;
            barang.JenisBarang = txtJenisBarangUpdate.Text;
            barang.IdSupplier = txtIdSuppUpdate.Text;
            barang.IdCustomer = txtIdCustUpdate.Text;
            barang.IdAdmin = txtIdAdminUpdate.Text;
            barang.Status = cmbStatusUpdate.Text;

            var result = controller.Update(barang);

            txtIdBarangUpdate.Clear();
            txtNamaBarangUpdate.Clear();
            txtJenisBarangUpdate.Clear();
            txtIdSuppUpdate.Clear();
            txtIdCustUpdate.Clear();
            txtIdAdminUpdate.Clear();

            txtIdBarangUpdate.Focus();

        }

        private void btnBarTgh_Click(object sender, EventArgs e)
        {
            FormTagihan formTagihan = new FormTagihan();
            formTagihan.Show();
            this.Hide();
        }
    }
}
