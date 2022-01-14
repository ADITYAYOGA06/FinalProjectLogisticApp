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
    public class BarangController
    {
        private BarangRepository _repository;

        public List<Barang> ReadAll()
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<Barang> ReadTerkirim()
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadTerkirim();
            }
            return list;
        }
        public List<Barang> ReadTersimpan()
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadTersimpan();
            }
            return list;
        }

        public List<Barang> ReadById(string cariId)
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            Barang cariData = new Barang();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetById yang ada di dalam class repository
                list = _repository.ReadById(cariId);
            }
            return list;
        }
        public List<Barang> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            Barang cariData = new Barang();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetById yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }
            return list;
        }

        public int Create(Barang barang)
        {
            int result = 0;

            if (string.IsNullOrEmpty(barang.IdBarang))
            {
                MessageBox.Show("Id Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.NamaBarang))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.JenisBarang))
            {
                MessageBox.Show("Jenis Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.IdSupplier))
            {
                MessageBox.Show("Id Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.IdCustomer))
            {
                MessageBox.Show("Id Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.IdAdmin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.Status))
            {
                MessageBox.Show("Status Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new BarangRepository(context);

                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Create(barang);
                }

                if (result > 0)
                {
                    MessageBox.Show("Data Barang berhasil disimpan !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Barang gagal disimpan !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return result;
        }

        public int Update(Barang barang)
        {
            int result = 0;

            if (string.IsNullOrEmpty(barang.IdBarang))
            {
                MessageBox.Show("Id Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.NamaBarang))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.JenisBarang))
            {
                MessageBox.Show("Jenis Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.IdSupplier))
            {
                MessageBox.Show("Id Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.IdCustomer))
            {
                MessageBox.Show("Id Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.IdAdmin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(barang.Status))
            {
                MessageBox.Show("Status Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new BarangRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Barang gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Barang barang)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(barang.IdBarang))
            {
                MessageBox.Show("Id Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new BarangRepository(context);

                // panggil method delete class repository untuk menghapus data
                result = _repository.Delete(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Barang gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }


    }
}

