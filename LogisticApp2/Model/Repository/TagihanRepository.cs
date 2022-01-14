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
    public class TagihanRepository
    {
        //deklarasi objek connection
        private OleDbConnection _conn;

        public TagihanRepository(DbContext context)
        {
            //inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Tagihan tagihan)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"insert into tagihan values (@idTagihan, @idBarang, @biaya, @status)";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idTagihan", tagihan.IdTagihan);
                cmd.Parameters.AddWithValue("@idBarang", tagihan.IdBarang);
                cmd.Parameters.AddWithValue("@biaya", tagihan.Biaya);
                cmd.Parameters.AddWithValue("@status", tagihan.StatusTagihan);

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

        public int Update(Tagihan tagihan)
        {
            int result = 0;

            //deklarasi perintah SQL     
            string sql = @"update tagihan set idTagihan = @idTagihan, idBarang = @idBarang, biaya = @biaya, status = @status where idTagihan = @idTagihan";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idTagihan", tagihan.IdTagihan);
                cmd.Parameters.AddWithValue("@idBarang", tagihan.IdBarang);
                cmd.Parameters.AddWithValue("@biaya", tagihan.Biaya);
                cmd.Parameters.AddWithValue("@status", tagihan.StatusTagihan);

                result = cmd.ExecuteNonQuery(); //eksekusi perintah UPDATE
            }
            return result;
        }

        public int Delete(Tagihan tagihan)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"delete from tagihan where idTagihan = @idTagihan";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idTagihan", tagihan.IdTagihan);

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

        public List<Tagihan> ReadAll()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Tagihan> list = new List<Tagihan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idTagihan, idBarang, biaya, status from tagihan order by idTagihan";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            Tagihan tagihan = new Tagihan();
                            tagihan.IdTagihan = dtr["idTagihan"].ToString();
                            tagihan.IdBarang = dtr["idBarang"].ToString();
                            tagihan.Biaya = dtr["biaya"].ToString();
                            tagihan.StatusTagihan = dtr["status"].ToString();


                            // tambahkan objek tagihan ke dalam collection
                            list.Add(tagihan);
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
        public List<Tagihan> ReadLunas()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Tagihan> list = new List<Tagihan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idTagihan, idBarang, biaya, status from tagihan where status = 'Lunas' order by idTagihan";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Tagihan tagihan = new Tagihan();
                            tagihan.IdTagihan = dtr["idTagihan"].ToString();
                            tagihan.IdBarang = dtr["idBarang"].ToString();
                            tagihan.Biaya = dtr["biaya"].ToString();
                            tagihan.StatusTagihan = dtr["status"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(tagihan);
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
        public List<Tagihan> ReadBelumLunas()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Tagihan> list = new List<Tagihan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idTagihan, idBarang, biaya, status from tagihan where status = 'Belum Lunas' order by idTagihan";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Tagihan tagihan = new Tagihan();
                            tagihan.IdTagihan = dtr["idTagihan"].ToString();
                            tagihan.IdBarang = dtr["idBarang"].ToString();
                            tagihan.Biaya = dtr["biaya"].ToString();
                            tagihan.StatusTagihan = dtr["status"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(tagihan);
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

        public List<Tagihan> ReadById(string id)
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Tagihan> list = new List<Tagihan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idTagihan, idBarang, biaya, status from tagihan where idTagihan = @idTagihan order by idTagihan";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@idTagihan", id);
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Tagihan tagihan = new Tagihan();
                            tagihan.IdTagihan = dtr["idTagihan"].ToString();
                            tagihan.IdBarang = dtr["idBarang"].ToString();
                            tagihan.Biaya = dtr["biaya"].ToString();
                            tagihan.StatusTagihan = dtr["status"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(tagihan);
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

    }
}
