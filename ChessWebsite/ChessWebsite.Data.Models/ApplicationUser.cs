using ChessWebsite.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWebsite.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            
        }

        public ICollection<ChessGame> WhiteGames { get; set; }

        public ICollection<ChessGame> BlackGames { get; set; }

        [Required]
        public int ELO { get; set; } = 100;
    }
}
