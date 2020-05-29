using forum.core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core
{
    public class ForumContext : DbContext
    {
        public ForumContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}
