using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWebsite.Web.ViewModels.Game
{
    public class ChessViewModel
    {
        public string? WhiteUserName { get; set; }

        public int? WhiteElo { get; set; }

        public string? BlackUserName { get; set; }

        public int? BlackElo { get; set; }

        public string PGN { get; set; } = "";

    }
}
