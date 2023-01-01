using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2.entity
{
    class sanatcilar
    {
        [Key]
        public int MENUID { get; set; }
        public string MENUAD { get; set; }
        public string MENUICERIK { get; set; }
        public int MENUFIYAT { get; set; }
    }
}
