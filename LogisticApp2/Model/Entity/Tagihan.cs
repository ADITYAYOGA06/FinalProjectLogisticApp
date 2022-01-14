using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticApp2.Model.Entity
{
    public class Tagihan
    {
        public string IdTagihan { get; set; }
        public string IdBarang { get; set; }
        public string Biaya { get; set; }
        public string StatusTagihan { get; set; }
    }
}
