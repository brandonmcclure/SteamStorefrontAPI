using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamStorefrontAPI.Classes.userdetails
{

    public class GamesSummary
    {
        public int game_count { get; set; }
        public UserGameStat[] games { get; set; }

    }

}
