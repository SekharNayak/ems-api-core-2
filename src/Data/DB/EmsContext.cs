using ems.data.entities;
using Microsoft.EntityFrameworkCore;

namespace ems.db.context{

    public class EmsContext :DbContext
    {

        public EmsContext(DbContextOptions options)
        {
            
        }


        public DbSet<Employee> Employees {get ; set;}

        public DbSet<Address> Addresses {get; set;}

        public DbSet<Department> Departments { get; set;}
    }
}