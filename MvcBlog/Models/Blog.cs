using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBlog.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Post { get; set; }
       
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}