using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Data
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server = . ; database = efcoreTest ; integrated security = true; trust server certificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>()
                .HasData(new Post { PostId = 1, Content = "" } , new Post { PostId = 2, Content = "" });
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

    }
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<PostTag> PostTags { get; set; }

    }
    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
