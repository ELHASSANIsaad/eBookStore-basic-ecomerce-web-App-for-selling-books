using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksStore.Models;

namespace BooksStore.Data
{
    public class BooksStoreContext : DbContext
    {
        public BooksStoreContext (DbContextOptions<BooksStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BooksStore.Models.book> book { get; set; } = default!;

        public DbSet<BooksStore.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<BooksStore.Models.orders> orders { get; set; }

        public DbSet<BooksStore.Models.report> report { get; set; }
    }
}
