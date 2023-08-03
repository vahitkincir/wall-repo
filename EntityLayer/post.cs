using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class post : basemodel
    {
        public int userid { get; set; }
        public string context { get; set; }

        public user user { get; set; }
    }
}
