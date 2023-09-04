using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAss17.Models;

namespace WebAppAss17.Data
{
    public class WebAppAss17DbContext : DbContext
    {
        public WebAppAss17DbContext (DbContextOptions<WebAppAss17DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAss17.Models.Movie> Movie { get; set; } = default!;
    }
}
