using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticApp2.Model.Entity;
using LogisticApp2.View;
using LogisticApp2.Controller;

namespace LogisticApp2
{
    public partial class FormSupplier : Form
    {
        private List<Supplier> listOfSupplier = new List<Supplier>();

        private SupplierController  controller;
        public FormSupplier()
        {
            InitializeComponent();

            controller = new SupplierController();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwSupp1.View = System.Windows.Forms.View.Details;
            lvwSupp1.FullRowSelect = true;
            lvwSupp1.GridLines = true;

            lvwSupp1.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwSupp1.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwSupp1.Columns.Add("Nama Supplier", 150, HorizontalAlignment.Center);
            lvwSupp1.Columns.Add("Kota ", 150, HorizontalAlignment.Center);
            lvwSupp1.Columns.Add("Kode Pos", 75, HorizontalAlignment.Center);
            lvwSupp1.Columns.Add("No Telp", 110, HorizontalAlignment.Center);

            lvwSupp2.View = System.Windows.Forms.View.Details;
            lvwSupp2.FullRowSelect = true;
            lvwSupp2.GridLines = true;

            lvwSupp2.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwSupp2.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwSupp2.Columns.Add("Nama Supplier", 150, HorizontalAlignment.Center);
            lvwSupp2.Columns.Add("Kota ", 150, HorizontalAlignment.Center);
            lvwSupp2.Columns.Add("Kode Pos", 75, HorizontalAlignment.Center);
            lvwSupp2.Columns.Add("No Telp", 110, HorizontalAlignment.Center);

            lvwSupp3.View = System.Windows.Forms.View.Details;
            lvwSupp3.FullRowSelect = true;
            lvwSupp3.GridLines = true;

            lvwSupp3.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwSupp3.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwSupp3.Columns.Add("Nama Supplier", 150, HorizontalAlignment.Center);
            lvwSupp3.Columns.Add("Kota ", 150, HorizontalAlignment.Center);
            lvwSupp3.Columns.Add("Kode Pos", 75, HorizontalAlignment.Center);
            lvwSupp3.Columns.Add("No Telp", 110, HorizontalAlignment.Center);
        }

        private void btnSuppCust_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }

        private void btnSuppBar_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
            this.Hide();
        }

        private void btnSuppAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnInsertSupp_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            supplier.IdSupplier = txtIdSuppInsert.Text;
            supplier.NamaSupplier = txtNamaSuppInsert.Text;
            supplier.City = txtKotaSuppInsert.Text;
            supplier.PostCode = txtPosSuppInsert.Text;
            supplier.NoTelp = txtTelpSuppInsert.Text;

            var result = controller.Create(supplier);

            txtIdSuppInsert.Clear();
            txtNamaSuppInsert.Clear();
            txtKotaSuppInsert.Clear();
            txtPosSuppInsert.Clear();
            txtTelpSuppInsert.Clear();

            txtIdSuppInsert.Focus();
        }

        private void btnTampilkanSupp1_Click(object sender, EventArgs e)
        {
            lvwSupp1.Items.Clear();

            listOfSupplier = controller.ReadAll();

            foreach (var supplier in listOfSupplier)
            {
                var noUrut = lvwSupp1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(supplier.IdSupplier);
                item.SubItems.Add(supplier.NamaSupplier);
                item.SubItems.Add(supplier.City);
                item.SubItems.Add(supplier.PostCode);
                item.SubItems.Add(supplier.NoTelp);

                lvwSupp1.Items.Add(item);
            }
        }

        private void btnCariSuppUpdate_Click(object sender, EventArgs e)
        {
            string cariId = txtIdSuppUpdate.Text;

            listOfSupplier = controller.ReadById(cariId);

            foreach(var supplier in listOfSupplier)
            {
                txtIdSuppUpdate.Text = supplier.IdSupplier.ToString();
                txtNamaSuppUpdate.Text = supplier.NamaSupplier.ToString();
                txtKotaSuppUpdate.Text = supplier.City.ToString();
                txtPosSuppUpdate.Text = supplier.PostCode.ToString();
                txtTelpSuppUpdate.Text = supplier.NoTelp.ToString();
            }
        }

        private void btnUpdateSupp_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            supplier.IdSupplier = txtIdSuppUpdate.Text;
            supplier.NamaSupplier = txtNamaSuppUpdate.Text;
            supplier.City = txtKotaSuppUpdate.Text;
            supplier.PostCode = txtPosSuppUpdate.Text;
            supplier.NoTelp = txtTelpSuppUpdate.Text;

            var result = controller.Update(supplier);

            txtIdSuppUpdate.Clear();
            txtNamaSuppUpdate.Clear();
            txtKotaSuppUpdate.Clear();
            txtPosSuppUpdate.Clear();
            txtTelpSuppUpdate.Clear();

            txtIdSuppUpdate.Focus();
        }

        private void btnTampilkanSupp2_Click(object sender, EventArgs e)
        {
            lvwSupp2.Items.Clear();

            listOfSupplier = controller.ReadAll();

            foreach (var supplier in listOfSupplier)
            {
                var noUrut = lvwSupp2.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(supplier.IdSupplier);
                item.SubItems.Add(supplier.NamaSupplier);
                item.SubItems.Add(supplier.City);
                item.SubItems.Add(supplier.PostCode);
                item.SubItems.Add(supplier.NoTelp);

                lvwSupp2.Items.Add(item);
            }
        }

        private void btnCariSuppDelete_Click(object sender, EventArgs e)
        {
            string cariId = txtIdSuppDelete.Text;

            listOfSupplier = controller.ReadById(cariId);

            foreach (var supplier in listOfSupplier)
            {
                txtIdSuppDelete.Text = supplier.IdSupplier.ToString();
                txtNamaSuppDelete.Text = supplier.NamaSupplier.ToString();
                txtKotaSuppDelete.Text = supplier.City.ToString();
                txtPosSuppDelete.Text = supplier.PostCode.ToString();
                txtTelpSuppDelete.Text = supplier.NoTelp.ToString();
            }
        }

        private void btnHapusSupp_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            supplier.IdSupplier = txtIdSuppDelete.Text;

            var konfirmasi = MessageBox.Show("Apakah data supplier ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (konfirmasi == DialogResult.Yes)
            {
                var result = controller.Delete(supplier);

                txtIdSuppDelete.Clear();
                txtNamaSuppDelete.Clear();
                txtKotaSuppDelete.Clear();
                txtPosSuppDelete.Clear();
                txtTelpSuppDelete.Clear();

            }

        }

        private void btnTampilkanSupp3_Click(object sender, EventArgs e)
        {
            lvwSupp3.Items.Clear();

            listOfSupplier = controller.ReadAll();

            foreach (var supplier in listOfSupplier)
            {
                var noUrut = lvwSupp3.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(supplier.IdSupplier);
                item.SubItems.Add(supplier.NamaSupplier);
                item.SubItems.Add(supplier.City);
                item.SubItems.Add(supplier.PostCode);
                item.SubItems.Add(supplier.NoTelp);

                lvwSupp3.Items.Add(item);
            }
        }

        private void btnSuppMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }

        private void btnSuppTgh_Click(object sender, EventArgs e)
        {
            FormTagihan formTagihan = new FormTagihan();
            formTagihan.Show();
            this.Hide();
        }
    }
}
