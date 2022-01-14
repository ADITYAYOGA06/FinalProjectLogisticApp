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
    public partial class FormLaporan : Form
    {
        private List<Barang> listOfLaporanBarang = new List<Barang>();

        private BarangController controller;

        public FormLaporan()
        {
            InitializeComponent();
            controller = new BarangController();
            InisialisasiListView();
        }

        public void InisialisasiListView()
        {
            lvwLapBar.View = System.Windows.Forms.View.Details;
            lvwLapBar.FullRowSelect = true;
            lvwLapBar.GridLines = true;

            lvwLapBar.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Id", 45, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Nama Barang", 135, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Jenis Barang", 135, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Id Supplier", 75, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Id Customer", 75, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Id Admin", 75, HorizontalAlignment.Center);
            lvwLapBar.Columns.Add("Status", 75, HorizontalAlignment.Center);

        }

        private void btnTerkirimMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }

        private void btnTampilkanBarTerkirim_Click(object sender, EventArgs e)
        {
            if (rdoBarangTerkirim.Checked)
            {
                lvwLapBar.Items.Clear();

                listOfLaporanBarang = controller.ReadTerkirim();

                foreach (var barang in listOfLaporanBarang)
                {
                    var noUrut = lvwLapBar.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(barang.IdBarang);
                    item.SubItems.Add(barang.NamaBarang);
                    item.SubItems.Add(barang.JenisBarang);
                    item.SubItems.Add(barang.IdSupplier);
                    item.SubItems.Add(barang.IdCustomer);
                    item.SubItems.Add(barang.IdAdmin);
                    item.SubItems.Add(barang.Status);

                    lvwLapBar.Items.Add(item);
                }
            }
            if (rdoBarangTersimpan.Checked)
            {
                lvwLapBar.Items.Clear();

                listOfLaporanBarang = controller.ReadTersimpan();

                foreach (var barang in listOfLaporanBarang)
                {
                    var noUrut = lvwLapBar.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(barang.IdBarang);
                    item.SubItems.Add(barang.NamaBarang);
                    item.SubItems.Add(barang.JenisBarang);
                    item.SubItems.Add(barang.IdSupplier);
                    item.SubItems.Add(barang.IdCustomer);
                    item.SubItems.Add(barang.IdAdmin);
                    item.SubItems.Add(barang.Status);

                    lvwLapBar.Items.Add(item);
                }
            }
            if (rdoBerdasarNama.Checked)
            {
                lvwLapBar.Items.Clear();

                listOfLaporanBarang = controller.ReadByNama(txtTampilNamaBar.Text);

                foreach (var barang in listOfLaporanBarang)
                {
                    var noUrut = lvwLapBar.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(barang.IdBarang);
                    item.SubItems.Add(barang.NamaBarang);
                    item.SubItems.Add(barang.JenisBarang);
                    item.SubItems.Add(barang.IdSupplier);
                    item.SubItems.Add(barang.IdCustomer);
                    item.SubItems.Add(barang.IdAdmin);
                    item.SubItems.Add(barang.Status);

                    lvwLapBar.Items.Add(item);
                }
            }

        }
    }
}
