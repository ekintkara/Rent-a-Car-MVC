using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class AContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\EKIN;Database=RentACar;Trusted_Connection=true");
        }

        public DbSet<Product> products { get; set; }    
        public DbSet<Model> models { get; set; }
        
        public DbSet<Category> categories { get; set; }

        public DbSet<User> users { get; set; }  
    }
}
