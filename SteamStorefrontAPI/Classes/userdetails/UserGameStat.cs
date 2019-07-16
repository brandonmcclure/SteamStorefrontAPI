using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamStorefrontAPI.Classes.userdetails
{
    /// <summary>
    /// A model that contains the appID and the playtime_forever stat </summary> 
    public class UserGameStat
    {
        public int appid { get; set; }
        public int playtime_forever { get; set; }
    }

}
