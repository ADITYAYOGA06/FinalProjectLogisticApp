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
    public partial class FormLaporanTagihan : Form
    {
        private List<Tagihan> listOfLaporanTagihan = new List<Tagihan>();

        private TagihanController controller;

        public FormLaporanTagihan()
        {
            InitializeComponent();
            controller = new TagihanController();
            InisialisasiListView();
        }

        public void InisialisasiListView()
        {
            lvwLapTgh.View = System.Windows.Forms.View.Details;
            lvwLapTgh.FullRowSelect = true;
            lvwLapTgh.GridLines = true;

            lvwLapTgh.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwLapTgh.Columns.Add("Id Tagihan", 85, HorizontalAlignment.Center);
            lvwLapTgh.Columns.Add("Id Barang", 85, HorizontalAlignment.Center);
            lvwLapTgh.Columns.Add("Biaya Kirim", 135, HorizontalAlignment.Center);
            lvwLapTgh.Columns.Add("Status", 75, HorizontalAlignment.Center);
        }

        private void btnLapTghMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }
        private void btnTampilLapTgh_Click(object sender, EventArgs e)
        {
            if (rdoBelumLunas.Checked)
            {
                lvwLapTgh.Items.Clear();

                listOfLaporanTagihan = controller.ReadBelumLunas();

                foreach (var tagihan in listOfLaporanTagihan)
                {
                    var noUrut = lvwLapTgh.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(tagihan.IdTagihan);
                    item.SubItems.Add(tagihan.IdBarang);
                    item.SubItems.Add(tagihan.Biaya);
                    item.SubItems.Add(tagihan.StatusTagihan);

                    lvwLapTgh.Items.Add(item);
                }
            }
            if (rdoLunas.Checked)
            {
                lvwLapTgh.Items.Clear();

                listOfLaporanTagihan = controller.ReadLunas();

                foreach (var tagihan in listOfLaporanTagihan)
                {
                    var noUrut = lvwLapTgh.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(tagihan.IdTagihan);
                    item.SubItems.Add(tagihan.IdBarang);
                    item.SubItems.Add(tagihan.Biaya);
                    item.SubItems.Add(tagihan.StatusTagihan);

                    lvwLapTgh.Items.Add(item);
                }
            }

        }
    }
}
