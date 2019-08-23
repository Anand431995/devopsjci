using DevopsProject1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsProject1.Data
{
    public class DataContext:DbContext
    {
        public DataContext(/*DbContextOptions<DataContext> options*/) :base(/*options*/)
        {

        }
       /* public DataContext()
        {

        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=M4726121\SQLEXPRESS;database=Devops;trusted_connection=true;Integrated Security=True");
            }
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        
    }
}
