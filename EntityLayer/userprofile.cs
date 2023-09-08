using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class userprofile : baseentity
    {
        public string username { get; set; }
        public string? profilepic { get; set; }
        public string? profiledescrip { get; set; }
    }
}
