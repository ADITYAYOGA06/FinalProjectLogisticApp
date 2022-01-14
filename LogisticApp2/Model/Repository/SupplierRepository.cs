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
    public class SupplierRepository
    {
        //deklarasi objek connection
        private OleDbConnection _conn;

        //constructor
        public SupplierRepository(DbContext context)
        {
            //inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Supplier supplier)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"insert into supplier values (@idSupplier, @namaSupplier, @city, @postCode, @noTelp)";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idSupplier", supplier.IdSupplier);
                cmd.Parameters.AddWithValue("@namaSupplier", supplier.NamaSupplier);
                cmd.Parameters.AddWithValue("@city", supplier.City);
                cmd.Parameters.AddWithValue("@postCode", supplier.PostCode);
                cmd.Parameters.AddWithValue("@noTelp", supplier.NoTelp);

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

        public int Update(Supplier supplier)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"update supplier set namaSupplier = @namaSupplier, city = @city,  postCode = @postCode, noTelp = @noTelp where idSupplier = @idSupplier";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@namaSupplier", supplier.NamaSupplier);
                cmd.Parameters.AddWithValue("@city", supplier.City);
                cmd.Parameters.AddWithValue("@postCode", supplier.PostCode);
                cmd.Parameters.AddWithValue("@noTelp", supplier.NoTelp);
                cmd.Parameters.AddWithValue("@idSupplier", supplier.IdSupplier);

                result = cmd.ExecuteNonQuery(); //eksekusi perintah UPDATE
            }
            return result;
        }

        public int Delete(Supplier supplier)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"delete from supplier where idSupplier = @idSupplier";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idSupplier", supplier.IdSupplier);

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

        public List<Supplier> ReadAll()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Supplier> list = new List<Supplier>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idSupplier, namaSupplier, city, postCode, noTelp from supplier order by idSupplier";

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
                            Supplier supplier = new Supplier();
                            supplier.IdSupplier = dtr["idSupplier"].ToString();
                            supplier.NamaSupplier = dtr["namaSupplier"].ToString();
                            supplier.City = dtr["city"].ToString();
                            supplier.PostCode = dtr["postCode"].ToString();
                            supplier.NoTelp = dtr["noTelp"].ToString();


                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(supplier);
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

        public List<Supplier> ReadById(string id)
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Supplier> list = new List<Supplier>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idSupplier, namaSupplier, city, postCode, noTelp from supplier where idSupplier = @idSupplier order by idSupplier";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@idSupplier", id);
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Supplier supplier = new Supplier();
                            supplier.IdSupplier = dtr["idSupplier"].ToString();
                            supplier.NamaSupplier = dtr["namaSupplier"].ToString();
                            supplier.City = dtr["city"].ToString();
                            supplier.PostCode = dtr["postCode"].ToString();
                            supplier.NoTelp = dtr["noTelp"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(supplier);
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

