using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scaffolding.Models;

namespace Scaffolding.Data
{
    public class AccountsContext : DbContext
    {
        public AccountsContext (DbContextOptions<AccountsContext> options)
            : base(options)
        {
        }

        public DbSet<Scaffolding.Models.Account> Account { get; set; }
    }
}
