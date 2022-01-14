using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using LogisticApp2.Model.Entity;
using LogisticApp2.Model.Repository;
using LogisticApp2.Model.Context;
using LogisticApp2.View;

namespace LogisticApp2.Controller
{
    public class UserController
    {
        private UserRepository _repository;

        public int ReadLogin(Admin admin)
        {
            int result = 0;

            if (string.IsNullOrEmpty(admin.IdAdmin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(admin.Password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new UserRepository(context);

                // panggil method ReadLogin class repository untuk menghapus data
                result = _repository.ReadLogin(admin);
            }

            if (result > 0)
            {
                FormUtama formUtama = new FormUtama();
                formUtama.Show();
                FormLogin formLogin = new FormLogin();
                formLogin.Close();
            }
            else
                MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return result;
        }

    }
}
