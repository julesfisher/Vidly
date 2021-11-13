using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class VidlyContext : DbContext

    {
        public VidlyContext(): base("name=VidlyContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}