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
    public class AdminRepository
    {
        //deklarasi objek connection
        private OleDbConnection _conn;

        //constructor
        public AdminRepository(DbContext context)
        {
            //inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Admin admin)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"insert into admin values (@idAdmin, @password, @idOffice)";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idAdmin", admin.IdAdmin);
                cmd.Parameters.AddWithValue("@password", admin.Password);
                cmd.Parameters.AddWithValue("@idOffice", admin.idOffice);

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

        public int Update(Admin admin)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"update admin set password = @password, idOffice = @idOffice where idAdmin = @idAdmin";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idAdmin", admin.IdAdmin);
                cmd.Parameters.AddWithValue("@password", admin.Password);
                cmd.Parameters.AddWithValue("@idOffice", admin.idOffice);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Admin admin)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"delete from admin where idAdmin = @idAdmin";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idAdmin", admin.IdAdmin);
              
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


        public List<Admin> ReadAll()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Admin> list = new List<Admin>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idAdmin, password, idOffice from admin order by idAdmin";

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
                            Admin admin = new Admin();
                            admin.IdAdmin = dtr["idAdmin"].ToString();
                            admin.Password = dtr["password"].ToString();
                            admin.idOffice = dtr["idOffice"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(admin);
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

        public List<Admin> ReadById(string id)
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Admin> list = new List<Admin>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idAdmin, password, idOffice from admin where idAdmin = @idAdmin order by idAdmin";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@idAdmin", id);
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Admin admin = new Admin();
                            admin.IdAdmin = dtr["idAdmin"].ToString();
                            admin.Password = dtr["password"].ToString();
                            admin.idOffice = dtr["idOffice"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(admin);
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

        /*public int ReadLogin(Admin admin)
        {

            int result = 0;

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from admin where idAdmin = @idAdmin and password = @password";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@idAdmin", admin.IdAdmin);
                    cmd.Parameters.AddWithValue("@password", admin.Password);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        if (dtr.Read())
                        {
                            result = 1;
 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadLogin error: {0}", ex.Message);
            }
            return result;
        } */

    }
}
