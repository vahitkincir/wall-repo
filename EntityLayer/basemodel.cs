using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public abstract class basemodel
    {
        public int id { get; set; }
        public bool isactive { get; set; } = true;
        public DateTime created { get; set; } = DateTime.Now;
        public DateTime? updated { get; set; }

    }
}
