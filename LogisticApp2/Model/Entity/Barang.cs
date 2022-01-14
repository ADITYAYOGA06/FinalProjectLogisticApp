using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticApp2.Model.Entity
{
    public class Barang
    {
        public string IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string JenisBarang { get; set; }
        public string IdSupplier { get; set; }
        public string IdCustomer { get; set; }
        public string IdAdmin { get; set; }
        public string Status { get; set; }



    }
}
