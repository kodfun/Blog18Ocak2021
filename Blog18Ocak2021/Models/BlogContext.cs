using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog18Ocak2021.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {

        }

        public DbSet<Yazi> Yazilar { get; set; }
    }
}