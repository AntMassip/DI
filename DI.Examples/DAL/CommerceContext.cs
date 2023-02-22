using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommerceContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var config = new ConfigurationBuilder()
                             .SetBasePath(
                             Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json")
                             .Build();

            string connectionString = config.GetConnectionString("CommerceConnectionString");

            builder.UseSqlServer(connectionString);
        }
    }
}