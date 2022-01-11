using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _065_Manan.Models
{
    public class StoreDB: DbContext
    {
        public StoreDB(DbContextOptions<StoreDB> options) : base(options) { }
        public DbSet<order> Orders { get; set; }
    }
}
