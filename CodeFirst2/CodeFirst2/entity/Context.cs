using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst2.entity
{
    class Context:DbContext
    {
        public DbSet<menuler> menulers { get; set; }
        public DbSet<menuler> sanatcilars { get; set; }
        public DbSet<menuler> mekanlars { get; set; }
    }
}
