using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class userprofile : basemodel
    {
        public string profilepic { get; set; }
        public string profilemessage { get; set; }

        public user user { get; set; }

    }
}
