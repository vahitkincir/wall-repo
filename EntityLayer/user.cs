using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class user : basemodel
    {
        public string username { get; set; }
        public string password { get; set; }

        public userinfo userinfo { get; set; }
        public userprofile userprofile { get; set; }
        public IEnumerable<post> posts { get; set; }
    }
}
