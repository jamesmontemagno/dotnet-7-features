using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonkeyAPI6;

namespace MonkeyAPI6.Data
{
    public class MonkeyAPI6Context : DbContext
    {
        public MonkeyAPI6Context (DbContextOptions<MonkeyAPI6Context> options)
            : base(options)
        {
        }

        public DbSet<MonkeyAPI6.Monkey> Monkey { get; set; } = default!;
    }
}
