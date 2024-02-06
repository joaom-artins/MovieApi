using Microsoft.EntityFrameworkCore;
using MovieApi.Model;
using System.Reflection.Emit;

namespace MovieApi.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Movie>().HasKey(x => x.Id);
            mb.Entity<Movie>().Property(x => x.Title).HasMaxLength(256);
            mb.Entity<Movie>().Property(x=>x.Description).HasMaxLength(512);
            mb.Entity<Movie>().Property(x => x.ImageUrl).HasMaxLength(256);
            mb.Entity<Movie>().Property(m => m.Gender).HasConversion<string>();
            mb.Entity<Movie>().Property(m => m.Review).HasConversion<int>();

            mb.Entity<Author>().HasKey(x => x.Id);
            mb.Entity<Author>().Property(x=>x.Name).HasMaxLength(256);

            mb.Entity<Movie>()
            .HasOne(m => m.Author)
            .WithMany(a => a.Movies)
            .HasForeignKey(m => m.AuthorId)
            .IsRequired();
            base.OnModelCreating(mb);
        }
    }
}
