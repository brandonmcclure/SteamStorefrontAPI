using Newtonsoft.Json.Linq;
using SteamStorefrontAPI.Classes;
using SteamStorefrontAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SteamStorefrontAPI.Classes.userdetails
{
    /// <summary>
    /// Endpoint returning details for an user in the steam stre.</summary>  
    public static class UserDetails
    {
        private static HttpClient client = new HttpClient();
        private const string steamBaseUri = " http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/";

        /// <summary>
        /// Retrieves the user's games</summary>  
        /// <param name="steamID">The user's Steam ID</param>
        /// <param name="include_played_free_games">By default, free games like Team Fortress 2 are excluded (as technically everyone owns them). If include_played_free_games is set, they will be returned if the player has played them at some point. This is the same behavior as the games list on the Steam Community.</param>
        public static async Task<GamesSummary> GetAsync(string APIKey, long steamID, bool include_played_free_games,bool GetGameDetail)
        {
            if (string.IsNullOrEmpty(APIKey))
            {
                throw new InvalidApiKeyException();
            }
            string steamUri = $"{steamBaseUri}?key={APIKey}&steamid={steamID}";
            steamUri = include_played_free_games ? steamUri : $"{steamUri}&include_played_free_games={include_played_free_games.ToString()}";
            steamUri = $"{steamUri}&format=json";
            var response = await client.GetAsync(steamUri);
            if (!response.IsSuccessStatusCode) { return null; }

            var result = await response.Content.ReadAsStringAsync();

            var jsonData = JToken.Parse(result).First.First;

            return jsonData.ToObject<GamesSummary>();
        }

        public static Task<GamesSummary> GetAsync(string APIKey, long steamID, bool include_played_free_games)
        {
            return GetAsync(APIKey, steamID, include_played_free_games, false);
        }
    }
}
