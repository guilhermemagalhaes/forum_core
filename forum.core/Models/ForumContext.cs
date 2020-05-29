using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Models
{
    public class ForumContext : DbContext
    {

        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        {

        }


        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Blog;Integrated Security=True;Pooling=False");
        }
    }
}
