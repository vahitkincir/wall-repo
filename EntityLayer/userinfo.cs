using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class userinfo:baseentity
    {
        public string username { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
    }
}
