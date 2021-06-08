using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster4.Models;

namespace RazorPagesMonster4.Data
{
    public class RazorPagesMonster4Context : DbContext
    {
        public RazorPagesMonster4Context (DbContextOptions<RazorPagesMonster4Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMonster4.Models.Monster> Monster { get; set; }
    }
}
