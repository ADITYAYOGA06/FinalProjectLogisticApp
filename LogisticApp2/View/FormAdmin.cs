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
    public partial class FormAdmin : Form
    {
        private List<Admin> listOfAdmin = new List<Admin>();

        private AdminController controller;


        public FormAdmin()
        {
            InitializeComponent();

            controller = new AdminController();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwAdmin.View = System.Windows.Forms.View.Details;
            lvwAdmin.FullRowSelect = true;
            lvwAdmin.GridLines = true;

            lvwAdmin.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwAdmin.Columns.Add("Id Admin", 85, HorizontalAlignment.Center);
            lvwAdmin.Columns.Add("Password", 150, HorizontalAlignment.Center);
            lvwAdmin.Columns.Add("Id Office", 85, HorizontalAlignment.Center);
        }
        private void btnAdminSupp_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
            this.Hide();
        }

        private void btnAdminBar_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
            this.Hide();
        }

        private void btnAdminCust_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }

        private void btnInputAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.IdAdmin = txtIdAdminInput.Text;
            admin.Password = txtPassAdminInput.Text;
            admin.idOffice = txtIdOfficeInput.Text;

            var result = controller.Create(admin);

            txtIdAdminInput.Clear();
            txtPassAdminInput.Clear();
            txtIdOfficeInput.Clear();

            txtIdAdminInput.Focus();

        }

        private void btnCariHapusAdmin_Click(object sender, EventArgs e)
        {
            string cariId = txtIdAdminDel.Text;
           
            listOfAdmin = controller.ReadById(cariId);

            foreach(var admin in listOfAdmin)
            {
                txtIdAdminDel.Text = admin.IdAdmin.ToString();
                txtPassAdminDel.Text = admin.Password.ToString();
                txtIdOfficeDel.Text = admin.idOffice.ToString();
            }

        }

        private void btnDelAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.IdAdmin = txtIdAdminDel.Text;

            var konfirmasi = MessageBox.Show("Apakah data admin ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(konfirmasi == DialogResult.Yes)
            {
                var result = controller.Delete(admin);

                txtIdAdminInput.Clear();
                txtPassAdminInput.Clear();
                txtIdOfficeInput.Clear();

                txtIdAdminInput.Focus();
            }


        }

        private void btnTampilkanAdmin_Click(object sender, EventArgs e)
        {
            lvwAdmin.Items.Clear();

            listOfAdmin = controller.ReadAll();

            foreach(var admin in listOfAdmin)
            {
                var noUrut = lvwAdmin.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(admin.IdAdmin);
                item.SubItems.Add(admin.Password);
                item.SubItems.Add(admin.idOffice);

                lvwAdmin.Items.Add(item);
            }


        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }
    }
}
