using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2.entity
{
    class mekanlar
    {
        [Key]
        public int MEKANID { get; set; }
        public string MEKANAD { get; set; }
        public int MENUNO { get; set; }
        public int KAPASİTE { get; set; }
        public int UCRET { get; set; }
        public int SANATCINO { get; set; }
    }
}
