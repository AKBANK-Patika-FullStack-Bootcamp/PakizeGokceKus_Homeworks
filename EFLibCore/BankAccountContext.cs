using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibCore
{
    public class BankAccountContext : DbContext
    {
        //protected readonly IConfiguration configuration;
        public BankAccountContext(DbContextOptions<BankAccountContext> options) : base(options)
        { }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server = LAPTOP-TTEO03UG; Database = BankDemoDb; integrated security = True;");

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().ToTable("BankAccounts");
        }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}


