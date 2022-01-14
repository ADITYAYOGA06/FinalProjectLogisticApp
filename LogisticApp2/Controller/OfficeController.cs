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
    public class OfficeController
    {
        //deklarasi objek Repository untuk menjalankan operasi CRUD
        private OfficeRepository _repository;

        public List<Office> ReadAll()
        {
            // membuat objek collection
            List<Office> list = new List<Office>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new OfficeRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }



    }
}
