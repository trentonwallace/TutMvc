using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movie { get; set; }
      
    }
}
