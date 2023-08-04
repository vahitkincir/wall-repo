using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public abstract class baseentity
    {
        public int id { get; set; }
        public Boolean isactive { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
}
