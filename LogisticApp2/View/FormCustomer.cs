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
    public partial class FormCustomer : Form
    {
        private List<Customer> listOfCustomer = new List<Customer>();

        private CustomerController controller;

        public FormCustomer()
        {
            InitializeComponent();
            controller = new CustomerController();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwCust1.View = System.Windows.Forms.View.Details;
            lvwCust1.FullRowSelect = true;
            lvwCust1.GridLines = true;

            lvwCust1.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwCust1.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwCust1.Columns.Add("Nama Customer", 150, HorizontalAlignment.Center);
            lvwCust1.Columns.Add("Kota ", 150, HorizontalAlignment.Center);
            lvwCust1.Columns.Add("Kode Pos", 75, HorizontalAlignment.Center);
            lvwCust1.Columns.Add("No Telp", 110, HorizontalAlignment.Center);

            lvwCust2.View = System.Windows.Forms.View.Details;
            lvwCust2.FullRowSelect = true;
            lvwCust2.GridLines = true;

            lvwCust2.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwCust2.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwCust2.Columns.Add("Nama Customer", 150, HorizontalAlignment.Center);
            lvwCust2.Columns.Add("Kota ", 150, HorizontalAlignment.Center);
            lvwCust2.Columns.Add("Kode Pos", 75, HorizontalAlignment.Center);
            lvwCust2.Columns.Add("No Telp", 110, HorizontalAlignment.Center);

            lvwCust3.View = System.Windows.Forms.View.Details;
            lvwCust3.FullRowSelect = true;
            lvwCust3.GridLines = true;

            lvwCust3.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwCust3.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwCust3.Columns.Add("Nama Customer", 150, HorizontalAlignment.Center);
            lvwCust3.Columns.Add("Kota ", 150, HorizontalAlignment.Center);
            lvwCust3.Columns.Add("Kode Pos", 75, HorizontalAlignment.Center);
            lvwCust3.Columns.Add("No Telp", 110, HorizontalAlignment.Center);
        }

        private void btnCustSupp_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
            this.Hide();
        }

        private void btnCustBar_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
            this.Hide();
        }

        private void btnCustAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnInsertCust_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.IdCustomer = txtIdCustInsert.Text;
            customer.NamaCustomer = txtNamaCustInsert.Text;
            customer.City = txtKotaCustInsert.Text;
            customer.PostCode = txtPosCustInsert.Text;
            customer.NoTelp = txtTelpCustInsert.Text;

            var result = controller.Create(customer);

            txtIdCustInsert.Clear();
            txtNamaCustInsert.Clear();
            txtPosCustInsert.Clear();
            txtKotaCustInsert.Clear();
            txtTelpCustInsert.Clear();

            txtIdCustInsert.Focus();
        }

        private void btnTampilkanCust1_Click(object sender, EventArgs e)
        {
            lvwCust1.Items.Clear();

            listOfCustomer = controller.ReadAll();

            foreach(var customer in listOfCustomer)
            {
                var noUrut = lvwCust1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(customer.IdCustomer);
                item.SubItems.Add(customer.NamaCustomer);
                item.SubItems.Add(customer.City);
                item.SubItems.Add(customer.PostCode);
                item.SubItems.Add(customer.NoTelp);

                lvwCust1.Items.Add(item);

            }
        }

        private void btnCariCustUpdate_Click(object sender, EventArgs e)
        {
            string cariId = txtIdCustUpdate.Text;

            listOfCustomer = controller.ReadById(cariId);

            foreach(var customer in listOfCustomer)
            {
                txtIdCustUpdate.Text = customer.IdCustomer.ToString();
                txtNamaCustUpdate.Text = customer.NamaCustomer.ToString();
                txtKotaCustUpdate.Text = customer.City.ToString();
                txtPosCustUpdate.Text = customer.PostCode.ToString();
                txtTelpCustUpdate.Text = customer.NoTelp.ToString();
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.IdCustomer = txtIdCustUpdate.Text;
            customer.NamaCustomer = txtNamaCustUpdate.Text;
            customer.City = txtKotaCustUpdate.Text;
            customer.PostCode = txtPosCustUpdate.Text;
            customer.NoTelp = txtTelpCustUpdate.Text;

            var result = controller.Update(customer);

            txtIdCustUpdate.Clear();
            txtNamaCustUpdate.Clear();
            txtKotaCustUpdate.Clear();
            txtPosCustUpdate.Clear();
            txtTelpCustUpdate.Clear();

            txtIdCustUpdate.Focus();

        }

        private void btnTampilkanCust2_Click(object sender, EventArgs e)
        {
            lvwCust2.Items.Clear();

            listOfCustomer = controller.ReadAll();

            foreach (var customer in listOfCustomer)
            {
                var noUrut = lvwCust2.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(customer.IdCustomer);
                item.SubItems.Add(customer.NamaCustomer);
                item.SubItems.Add(customer.City);
                item.SubItems.Add(customer.PostCode);
                item.SubItems.Add(customer.NoTelp);

                lvwCust2.Items.Add(item);

            }
        }

        private void btnCariCustDelete_Click(object sender, EventArgs e)
        {
            string cariId = txtIdCustDelete.Text;

            listOfCustomer = controller.ReadById(cariId);

            foreach (var customer in listOfCustomer)
            {
                txtIdCustDelete.Text = customer.IdCustomer.ToString();
                txtNamaCustDelete.Text = customer.NamaCustomer.ToString();
                txtKotaCustDelete.Text = customer.City.ToString();
                txtPosCustDelete.Text = customer.PostCode.ToString();
                txtTelpCustDelete.Text = customer.NoTelp.ToString();
            }
        }

        private void btnHapusCust_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.IdCustomer = txtIdCustDelete.Text;

            var konfirmasi = MessageBox.Show("Apakah data customer ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (konfirmasi == DialogResult.Yes)
            {
                var result = controller.Delete(customer);

                txtIdCustDelete.Clear();
                txtNamaCustDelete.Clear();
                txtKotaCustDelete.Clear();
                txtPosCustDelete.Clear();
                txtTelpCustDelete.Clear();

            }
        }

        private void btnTampilkanCust3_Click(object sender, EventArgs e)
        {
            lvwCust3.Items.Clear();

            listOfCustomer = controller.ReadAll();

            foreach (var customer in listOfCustomer)
            {
                var noUrut = lvwCust3.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(customer.IdCustomer);
                item.SubItems.Add(customer.NamaCustomer);
                item.SubItems.Add(customer.City);
                item.SubItems.Add(customer.PostCode);
                item.SubItems.Add(customer.NoTelp);

                lvwCust3.Items.Add(item);

            }
        }

        private void btnCustMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }

        private void btnCustTgh_Click(object sender, EventArgs e)
        {
            FormTagihan formTagihan = new FormTagihan();
            formTagihan.Show();
            this.Hide();
        }
    }
}
