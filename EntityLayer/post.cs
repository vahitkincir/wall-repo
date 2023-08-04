using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class post : baseentity
    {
        public string userid { get; set; }
        public string context { get; set; }
        public string media { get; set; }
    }
}
