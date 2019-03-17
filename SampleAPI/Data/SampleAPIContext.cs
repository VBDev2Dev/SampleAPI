using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Models
{
    public class SampleAPIContext : DbContext
    {
        public SampleAPIContext (DbContextOptions<SampleAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SampleAPI.Models.Movie> Movie { get; set; }
    }
}
