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

namespace LogisticApp2.View
{
    public partial class FormKantor : Form
    {
        private List<Office> listOfOffice = new List<Office>();

        private OfficeController controller;

        public FormKantor()
        {
            InitializeComponent();
            controller = new OfficeController();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwOffice.View = System.Windows.Forms.View.Details;
            lvwOffice.FullRowSelect = true;
            lvwOffice.GridLines = true;

            lvwOffice.Columns.Add("No", 45, HorizontalAlignment.Center);
            lvwOffice.Columns.Add("Id Kantor", 55, HorizontalAlignment.Center);
            lvwOffice.Columns.Add("Kota", 75, HorizontalAlignment.Center);
            lvwOffice.Columns.Add("Kode Pos", 65, HorizontalAlignment.Center);
            lvwOffice.Columns.Add("Kecamatan", 95, HorizontalAlignment.Center);
        }

        private void btnBarMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }

        private void btnTampilkanKantor_Click(object sender, EventArgs e)
        {
            lvwOffice.Items.Clear();

            listOfOffice = controller.ReadAll();

            foreach (var office in listOfOffice)
            {
                var noUrut = lvwOffice.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(office.IdOffice);
                item.SubItems.Add(office.City);
                item.SubItems.Add(office.PostCode);
                item.SubItems.Add(office.Kecamatan);

                lvwOffice.Items.Add(item);
            }
        }
    }
}
