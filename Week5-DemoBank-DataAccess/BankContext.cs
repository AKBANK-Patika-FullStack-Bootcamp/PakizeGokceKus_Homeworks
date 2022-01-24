using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_DataAccess.EntityFramework
{
    public class BankContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = LAPTOP-TTEO03UG; Database = ABankDemoDb; Trusted_Connection = True; MultipleActiveResultSets = true");
            }
        }

        //Table bu 
        public DbSet<BankAccount> ABankAccounts { get; set; }
        public DbSet<User> AUsers { get; set; }
        public DbSet<OperationClaim> AOperationClaims { get; set; }
        public DbSet<UserOperationClaim> AUserOperationClaims { get; set; }
    }
}
