using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonkeyAPI7;

namespace MonkeyAPI7.Data
{
    public class MonkeyAPI7Context : DbContext
    {
        public MonkeyAPI7Context (DbContextOptions<MonkeyAPI7Context> options)
            : base(options)
        {
        }

        public DbSet<MonkeyAPI7.Monkey> Monkey { get; set; } = default!;
    }
}
