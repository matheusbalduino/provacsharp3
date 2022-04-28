using Microsoft.EntityFrameworkCore;
using provacsharp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace provacsharp3.context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
