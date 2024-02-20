using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessWebsite.Data.Models.Enums;

namespace ChessWebsite.Data.Models
{
    public class ChessGame
    {
        [Key]
        public int GameId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public GameResult? GameResult { get; set; }

        [Required]
        public GameStatus Status { get; set; }

        public string PGN { get; set; } = "";

        [ForeignKey("WhitePlayer")]
        [Required]
        public Guid WhitePlayerId { get; set; }
        public virtual ApplicationUser WhitePlayer { get; set; }


        [ForeignKey("BlackPlayer")]
        [Required]
        public Guid BlackPlayerId { get; set; }
        public virtual ApplicationUser BlackPlayer { get; set; }
    }
}
