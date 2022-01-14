using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using LogisticApp2.Model.Context;
using LogisticApp2.Model.Entity;
using LogisticApp2.Controller;

namespace LogisticApp2
{
    public partial class FormLogin : Form
    {
        private UserController controller;

        public FormLogin()
        {
            InitializeComponent();
            controller = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //kode login pakai MVC Pattern
            Admin admin = new Admin();

            admin.IdAdmin = txtIdAdminLogin.Text;
            admin.Password = txtPasswordLogin.Text;

            var result = controller.ReadLogin(admin);

            txtIdAdminLogin.Text = "";
            txtPasswordLogin.Text = "";

            if(result > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }

        }

    }
}

