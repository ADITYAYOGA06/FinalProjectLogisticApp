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
    public class CustomerRepository
    {
        //deklarasi objek connection
        private OleDbConnection _conn;

        public CustomerRepository(DbContext context)
        {
            //inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Customer customer)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"insert into customer values (@idCustomer, @namaCUstomer, @city, @postCode, @noTelp)";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idCustomer", customer.IdCustomer);
                cmd.Parameters.AddWithValue("@namaSupplier", customer.NamaCustomer);
                cmd.Parameters.AddWithValue("@city", customer.City);
                cmd.Parameters.AddWithValue("@postCode", customer.PostCode);
                cmd.Parameters.AddWithValue("@noTelp", customer.NoTelp);

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

        public int Update(Customer customer)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"update customer set namaCustomer = @namaCustomer, city = @city,  postCode = @postCode, noTelp = @noTelp where idCustomer = @idCustomer";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@namaSupplier", customer.NamaCustomer);
                cmd.Parameters.AddWithValue("@city", customer.City);
                cmd.Parameters.AddWithValue("@postCode", customer.PostCode);
                cmd.Parameters.AddWithValue("@noTelp", customer.NoTelp);
                cmd.Parameters.AddWithValue("@idCustomer", customer.IdCustomer);

                result = cmd.ExecuteNonQuery(); //eksekusi perintah UPDATE
            }
            return result;
        }

        public int Delete(Customer customer)
        {
            int result = 0;

            //deklarasi perintah SQL
            string sql = @"delete from customer where idCustomer = @idCustomer";

            //membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@idCustomer", customer.IdCustomer);

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

        public List<Customer> ReadAll()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Customer> list = new List<Customer>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idCustomer, namaCustomer, city, postCode, noTelp from customer order by idCustomer";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            Customer customer = new Customer();
                            customer.IdCustomer = dtr["idCustomer"].ToString();
                            customer.NamaCustomer = dtr["namaCUstomer"].ToString();
                            customer.City = dtr["city"].ToString();
                            customer.PostCode = dtr["postCode"].ToString();
                            customer.NoTelp = dtr["noTelp"].ToString();


                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(customer);
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

        public List<Customer> ReadById(string id)
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Customer> list = new List<Customer>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idCustomer, namaCustomer, city, postCode, noTelp from customer where idCustomer = @idCustomer order by idCustomer";

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
                            Customer customer = new Customer();
                            customer.IdCustomer = dtr["idCustomer"].ToString();
                            customer.NamaCustomer = dtr["namaCUstomer"].ToString();
                            customer.City = dtr["city"].ToString();
                            customer.PostCode = dtr["postCode"].ToString();
                            customer.NoTelp = dtr["noTelp"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(customer);
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
