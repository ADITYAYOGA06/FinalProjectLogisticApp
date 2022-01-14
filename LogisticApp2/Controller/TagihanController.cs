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
    public class TagihanController
    {
        private TagihanRepository _repository;

        public List<Tagihan> ReadAll()
        {
            // membuat objek collection
            List<Tagihan> list = new List<Tagihan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TagihanRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<Tagihan> ReadLunas()
        {
            // membuat objek collection
            List<Tagihan> list = new List<Tagihan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TagihanRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadLunas();
            }
            return list;
        }
        public List<Tagihan> ReadBelumLunas()
        {
            // membuat objek collection
            List<Tagihan> list = new List<Tagihan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TagihanRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadBelumLunas();
            }
            return list;
        }

        public List<Tagihan> ReadById(string cariId)
        {
            // membuat objek collection
            List<Tagihan> list = new List<Tagihan>();


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TagihanRepository(context);

                // panggil method GetById yang ada di dalam class repository
                list = _repository.ReadById(cariId);
            }
            return list;
        }

        public int Create(Tagihan tagihan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(tagihan.IdTagihan))
            {
                MessageBox.Show("Id Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tagihan.IdBarang))
            {
                MessageBox.Show("Id Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tagihan.Biaya))
            {
                MessageBox.Show("Biaya Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tagihan.StatusTagihan))
            {
                MessageBox.Show("Status Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TagihanRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(tagihan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tagihan berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tagihan gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }


        public int Update(Tagihan tagihan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(tagihan.IdTagihan))
            {
                MessageBox.Show("Id Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tagihan.IdBarang))
            {
                MessageBox.Show("Id Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tagihan.Biaya))
            {
                MessageBox.Show("Biaya Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tagihan.StatusTagihan))
            {
                MessageBox.Show("Status Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TagihanRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(tagihan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tagihan berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tagihan gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Tagihan tagihan)
        {
            int result = 0;

            // cek idAdmin yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(tagihan.IdTagihan))
            {
                MessageBox.Show("Id Tagihan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TagihanRepository(context);

                // panggil method delete class repository untuk menghapus data
                result = _repository.Delete(tagihan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tagihan berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tagihan gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

    }
}
