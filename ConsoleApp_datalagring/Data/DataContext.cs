using ConsoleApp_datalagring.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Data
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options)
        {
        }
        public DbSet<AdressEntity> Adresses { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }   
        public DbSet<CustomerEntity> Customers { get; set; }   
        public DbSet<ProductEntity> products { get; set; }  
        public DbSet<RolesEntity> roles { get; set; }   
    }
}
