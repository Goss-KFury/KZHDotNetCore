using KZHDotNetCore.ConsoleApp.Dtos;
using KZHDotNetCore.ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KZHDotNetCore.ConsoleApp.EFCoreExamples
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
        }

        internal int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<BlogDto> Blogs { get; set; }
    }
}
