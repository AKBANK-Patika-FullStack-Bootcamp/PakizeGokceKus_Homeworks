using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_DemoBank_Entities.Concrete;

namespace Week4_DemoBank_DataAccess.EntityFramework
{
    public class BankContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = LAPTOP-TTEO03UG; Database = HBankDemoDb; Trusted_Connection = True; MultipleActiveResultSets = true");
            }
        }

        //Table bu 
        public DbSet<BankAccount> HBankAccounts { get; set; }
        public DbSet<User> HUsers { get; set; }
    }
}
