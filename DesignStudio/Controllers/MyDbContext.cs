using System;
using System.Collections.Generic;
using System.Data.Entity;
using DesignStudio.Models;

namespace DesignStudio.Controllers
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
            :base("DbConnection")
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
