using ems.data.entities;
using Microsoft.EntityFrameworkCore;

namespace ems.db.context{

    public class EmsContext :DbContext
    {

         public DbSet<Employee> Employees {get ; set;}

        public DbSet<Address> Addresses {get; set;}

        public DbSet<Department> Departments { get; set;}


        public EmsContext(DbContextOptions options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
           // var connString = Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString("");
            //optionsBuilder.UseSqlServer();
            
            //);
         }

       
    }
}