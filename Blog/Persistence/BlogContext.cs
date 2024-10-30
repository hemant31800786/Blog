

using Blog.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistence
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
#if DEBUG   
            optionsBuilder.LogTo(Console.WriteLine);
#endif


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasData(

                    new User
                    {
                        Id = 1,
                        Email = "hem7246@gmail.com",
                        FirstName = "HemantKumar",
                        LastName = "Babaria",
                        Salt = "FakeDataenterabcded",
                        Hash = "asdfsasfsadfsdfsdafasdfsdafsdfsdf"

                    }
                );


        }


    }
}
