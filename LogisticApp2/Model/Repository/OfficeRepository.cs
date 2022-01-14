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
    public class OfficeRepository
    {
        //deklarasi objek connection
        private OleDbConnection _conn;

        //constructor
        public OfficeRepository(DbContext context)
        {
            //inisialisasi objek connection
            _conn = context.Conn;
        }

        public List<Office> ReadAll()
        {
            //membuat objek collection untuk menampung objek mahasiswwa
            List<Office> list = new List<Office>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select idOffice, city, postCode, kecamatan from office order by idOffice";

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
                            Office office = new Office();
                            office.IdOffice = dtr["idOffice"].ToString();
                            office.City = dtr["city"].ToString();
                            office.PostCode = dtr["postCode"].ToString();
                            office.Kecamatan = dtr["kecamatan"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(office);
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


    }
}
