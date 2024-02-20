using ChessWebsite.Data.Configurations;
using ChessWebsite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ChessWebsite.Data
{
    public class ChessDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ChessDbContext(DbContextOptions<ChessDbContext> options)
            : base(options)
        {
        }

        public DbSet<ChessGame> ChessGames { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ChessGameEntityConfiguration());

            base.OnModelCreating(builder);
        }
    }
}