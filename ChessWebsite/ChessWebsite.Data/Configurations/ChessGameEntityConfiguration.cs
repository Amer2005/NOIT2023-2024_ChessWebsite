using ChessWebsite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ChessWebsite.Data.Configurations
{
    public class ChessGameEntityConfiguration : IEntityTypeConfiguration<ChessGame>
    {
        public void Configure(EntityTypeBuilder<ChessGame> builder)
        {
            

            builder
                .HasOne(g => g.WhitePlayer)
                .WithMany(u => u.WhiteGames)
                .HasForeignKey(g => g.WhitePlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(g => g.BlackPlayer)
                .WithMany(u => u.BlackGames)
                .HasForeignKey(g => g.BlackPlayerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
