using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using LogisticApp2.Model.Entity;
using LogisticApp2.Model.Context;

namespace LogisticApp2.Model.Repository
{
    public class BarangRepository
    {
        //deklarasi objek connection
        private OleDbConnection _conn;

        public BarangRepository(DbContext context)
        {
            //inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Barang barang)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"insert into barang values (@idBarang, @namaBarang, @jenisBarang, @idSupplier, @idCustomer, @idAdmin, @status)";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idBarang", barang.IdBarang);
                cmd.Parameters.AddWithValue("@namaBarang", barang.NamaBarang);
                cmd.Parameters.AddWithValue("@jenisBarang", barang.JenisBarang);
                cmd.Parameters.AddWithValue("@idSupplier", barang.IdSupplier);
                cmd.Parameters.AddWithValue("@idCustomer", barang.IdCustomer);
                cmd.Parameters.AddWithValue("@idAdmin", barang.IdAdmin);
                cmd.Parameters.AddWithValue("@status", barang.Status);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Barang barang)
        {
            int result = 0;

            //deklarasi perintah SQL     
            string sql = @"update barang set namaBarang = @namaBarang, jenisBarang = @jenisBarang, idSupplier = @idSupplier, idCustomer = @idCustomer, idAdmin = @idAdmin, status = @status where idBarang = @idBarang";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@namaBarang", barang.NamaBarang);
                cmd.Parameters.AddWithValue("@jenisBarang", barang.JenisBarang);
                cmd.Parameters.AddWithValue("@idSupplier", barang.IdSupplier);
                cmd.Parameters.AddWithValue("@idCustomer", barang.IdCustomer); 
                cmd.Parameters.AddWithValue("@idAdmin", barang.IdAdmin);
                cmd.Parameters.AddWithValue("@status", barang.Status);
                cmd.Parameters.AddWithValue("@idBarang", barang.IdBarang);

                result = cmd.ExecuteNonQuery(); //eksekusi perintah UPDATE
            }
            return result;
        }

        public int Delete(Barang barang)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"delete from barang where idBarang = @idBarang";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idBarang", barang.IdBarang);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Barang> ReadAll()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idBarang, namaBarang, jenisBarang, idSupplier, idCustomer, idAdmin, status from barang order by idBarang";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            Barang barang = new Barang();
                            barang.IdBarang = dtr["idBarang"].ToString();
                            barang.NamaBarang = dtr["namaBarang"].ToString();
                            barang.JenisBarang = dtr["jenisBarang"].ToString();
                            barang.IdSupplier = dtr["idSupplier"].ToString();
                            barang.IdCustomer = dtr["idCustomer"].ToString();
                            barang.IdAdmin = dtr["idAdmin"].ToString();
                            barang.Status = dtr["status"].ToString();

                            // tambahkan objek barang ke dalam collection
                            list.Add(barang);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<Barang> ReadTerkirim()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idBarang, namaBarang, jenisBarang, idSupplier, idCustomer, idAdmin, status from barang where status = 'Terkirim' order by idBarang";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            Barang barang = new Barang();
                            barang.IdBarang = dtr["idBarang"].ToString();
                            barang.NamaBarang = dtr["namaBarang"].ToString();
                            barang.JenisBarang = dtr["jenisBarang"].ToString();
                            barang.IdSupplier = dtr["idSupplier"].ToString();
                            barang.IdCustomer = dtr["idCustomer"].ToString();
                            barang.IdAdmin = dtr["idAdmin"].ToString();
                            barang.Status = dtr["status"].ToString();

                            // tambahkan objek barang ke dalam collection
                            list.Add(barang);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
        public List<Barang> ReadTersimpan()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idBarang, namaBarang, jenisBarang, idSupplier, idCustomer, idAdmin, status from barang where status = 'Tersimpan' order by idBarang";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            Barang barang = new Barang();
                            barang.IdBarang = dtr["idBarang"].ToString();
                            barang.NamaBarang = dtr["namaBarang"].ToString();
                            barang.JenisBarang = dtr["jenisBarang"].ToString();
                            barang.IdSupplier = dtr["idSupplier"].ToString();
                            barang.IdCustomer = dtr["idCustomer"].ToString();
                            barang.IdAdmin = dtr["idAdmin"].ToString();
                            barang.Status = dtr["status"].ToString();

                            // tambahkan objek barang ke dalam collection
                            list.Add(barang);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<Barang> ReadById(string id)
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idBarang, namaBarang, jenisBarang, idSupplier, idCustomer, idAdmin, status from barang where idBarang = @idBarang order by idBarang";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@idBarang", id);
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Barang barang = new Barang();
                            barang.IdBarang = dtr["idBarang"].ToString();
                            barang.NamaBarang = dtr["namaBarang"].ToString();
                            barang.JenisBarang = dtr["jenisBarang"].ToString();
                            barang.IdSupplier = dtr["idSupplier"].ToString();
                            barang.IdCustomer = dtr["idCustomer"].ToString();
                            barang.IdAdmin = dtr["idAdmin"].ToString();
                            barang.Status = dtr["status"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(barang);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadById error: {0}", ex.Message);
            }

            return list;
        }

        public List<Barang> ReadByNama(string namaBarang)
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idBarang, namaBarang, jenisBarang, idSupplier, idCustomer, idAdmin, status from barang where namaBarang like @namaBarang order by idBarang";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@namaBarang", "%" + namaBarang + "%");
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Barang barang = new Barang();
                            barang.IdBarang = dtr["idBarang"].ToString();
                            barang.NamaBarang = dtr["namaBarang"].ToString();
                            barang.JenisBarang = dtr["jenisBarang"].ToString();
                            barang.IdSupplier = dtr["idSupplier"].ToString();
                            barang.IdCustomer = dtr["idCustomer"].ToString();
                            barang.IdAdmin = dtr["idAdmin"].ToString();
                            barang.Status = dtr["status"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(barang);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

    }
}
