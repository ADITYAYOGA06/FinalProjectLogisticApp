using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using LogisticApp2.Model.Entity;
using LogisticApp2.Model.Repository;
using LogisticApp2.Model.Context;

namespace LogisticApp2.Controller
{
    public class AdminController
    {
        //deklarasi objek Repository untuk menjalankan operasi CRUD
        private AdminRepository _repository;

        public List<Admin> ReadAll()
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AdminRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<Admin> ReadById(string cariId)
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();

            Admin cariData = new Admin();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AdminRepository(context);

                // panggil method GetById yang ada di dalam class repository
                list = _repository.ReadById(cariId);
            }

            return list;
        }

        /*public int ReadLogin(Admin admin)
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
                _repository = new AdminRepository(context);

                // panggil method ReadLogin class repository untuk menghapus data
                result = _repository.ReadLogin(admin);
            }

            if (result > 0)
            {
                FormSupplier formSupplier = new FormSupplier();
                formSupplier.Show();

            }
            else
                MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return result;
        } */

        public int Create(Admin admin)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.IdAdmin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek password yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.Password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek idOffice yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.idOffice))
            {
                MessageBox.Show("Id Office harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(admin);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Admin admin)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.IdAdmin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek password yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.Password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek idOffice yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.idOffice))
            {
                MessageBox.Show("Id Office harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);

                // panggil method Create update repository untuk mengupdate data
                result = _repository.Update(admin);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Admin admin)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(admin.IdAdmin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);

                // panggil method delete class repository untuk menghapus data
                result = _repository.Delete(admin);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

    }
}
