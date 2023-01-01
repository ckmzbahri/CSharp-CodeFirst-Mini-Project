using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2.entity
{
    class menuler
    {
        [Key]
        public int SANATCIID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public int UCRET { get; set; }
    }
}
