#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Midmester.Models;

namespace Midmester.Data
{
    public class MidmesterContext : DbContext
    {
        public MidmesterContext (DbContextOptions<MidmesterContext> options)
            : base(options)
        {
        }

        public DbSet<Midmester.Models.Student> Student { get; set; }
    }
}
