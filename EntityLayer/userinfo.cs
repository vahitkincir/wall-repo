using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class userinfo : basemodel
    {
        public string firstname { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string age { get; set; }

        public user user { get; set; }

    }
}
