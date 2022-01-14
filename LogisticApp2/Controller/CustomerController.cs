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
    public class CustomerController
    {
        private CustomerRepository _repository;

        public List<Customer> ReadAll()
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new CustomerRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }

        public List<Customer> ReadById(string cariId)
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();

            Supplier cariData = new Supplier();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new CustomerRepository(context);

                // panggil method GetById yang ada di dalam class repository
                list = _repository.ReadById(cariId);
            }
            return list;
        }

        public int Create(Customer customer)
        {
            int result = 0;

            // cek idSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.IdCustomer))
            {
                MessageBox.Show("Id Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek namaSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.NamaCustomer))
            {
                MessageBox.Show("Nama Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek kota yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.City))
            {
                MessageBox.Show("Kota Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(customer.PostCode))
            {
                MessageBox.Show("Kode Pos Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(customer.NoTelp))
            {
                MessageBox.Show("No Telpon Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new CustomerRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(customer);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Customer berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Customer gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Customer customer)
        {
            int result = 0;

            // cek idSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.IdCustomer))
            {
                MessageBox.Show("Id Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek namaSupplier yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.NamaCustomer))
            {
                MessageBox.Show("Nama Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek kota yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.City))
            {
                MessageBox.Show("Kota Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(customer.PostCode))
            {
                MessageBox.Show("Kode Pos Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(customer.NoTelp))
            {
                MessageBox.Show("No Telpon Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new CustomerRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(customer);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Customer berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Customer gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Customer customer)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(customer.IdCustomer))
            {
                MessageBox.Show("Id Customer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new CustomerRepository(context);

                // panggil method delete class repository untuk menghapus data
                result = _repository.Delete(customer);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Customer berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Customer gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }


    }
}
