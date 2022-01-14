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
    public class SupplierController
    {
        //deklarasi objek Repository untuk menjalankan operasi CRUD
        private SupplierRepository _repository;

        public List<Supplier> ReadAll()
        {
            // membuat objek collection
            List<Supplier> list = new List<Supplier>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new SupplierRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }

        public List<Supplier> ReadById(string cariId)
        {
            // membuat objek collection
            List<Supplier> list = new List<Supplier>();

            Supplier cariData = new Supplier();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new SupplierRepository(context);

                // panggil method GetById yang ada di dalam class repository
                list = _repository.ReadById(cariId);
            }
            return list;
        }

        public int Create(Supplier supplier)
        {
            int result = 0;

            // cek idSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.IdSupplier))
            {
                MessageBox.Show("Id Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek namaSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.NamaSupplier))
            {
                MessageBox.Show("Nama Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek kota yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.City))
            {
                MessageBox.Show("Kota Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.PostCode))
            {
                MessageBox.Show("Kode Pos Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.NoTelp))
            {
                MessageBox.Show("Nomor Telpon Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new SupplierRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(supplier);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Supplier berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Supplier gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Supplier supplier)
        {
            int result = 0;

            // cek idSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.IdSupplier))
            {
                MessageBox.Show("Id Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek namaSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.NamaSupplier))
            {
                MessageBox.Show("Nama Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek kota yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.City))
            {
                MessageBox.Show("Kota Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.PostCode))
            {
                MessageBox.Show("Kode Pos Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.NoTelp))
            {
                MessageBox.Show("No Telpon Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new SupplierRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(supplier);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Supplier berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Supplier gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Supplier supplier)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(supplier.IdSupplier))
            {
                MessageBox.Show("Id Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new SupplierRepository(context);

                // panggil method delete class repository untuk menghapus data
                result = _repository.Delete(supplier);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Supplier berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Supplier gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }


    }
}
