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
    public class UserRepository
    {

        private OleDbConnection _conn;

        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int ReadLogin(Admin admin)
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
        }


    }
}
