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
    public partial class FormInfoAplikasi : Form
    {
        public FormInfoAplikasi()
        {
            InitializeComponent();
        }

        private void btnInfoAppMenu_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            this.Hide();
        }
    }
}
