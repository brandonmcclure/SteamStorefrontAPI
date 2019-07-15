﻿using SteamStorefrontAPI;
using SteamStorefrontAPI.Classes;
using SteamStorefrontAPI.Classes.userdetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SteamStorefrontConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => await Examples()).Wait();
        }

        static async Task Examples()
        {
            try
            {
                // Get details for SteamApp with ID 443790
                SteamApp steamApp1 = await AppDetails.GetAsync(460810);

                // Get details for SteamApp with ID 443790 for region US
                SteamApp steamApp2 = await AppDetails.GetAsync(322330, "US");

                // Get details for SteamApp with ID 443790 for region US with strings localized in german
                SteamApp steamApp3 = await AppDetails.GetAsync(322330, "US", "german");

                // Get details for Package with ID 68179 for region
                PackageInfo package1 = await PackageDetails.GetAsync(68179);

                // Get details for Package with ID 68179 for region JP
                PackageInfo package2 = await PackageDetails.GetAsync(68179, "JP");

                // Get a list of featured games
                FeaturedApps featured = await Featured.GetAsync();

                // Get a list of featured games for region DE
                FeaturedApps featured2 = await Featured.GetAsync("DE");

                // Get a list of featured games for region DE localized in english
                FeaturedApps featured3 = await Featured.GetAsync("DE", "english");

                // Get a list of featured games grouped by category
                List<FeaturedCategory> featuredCategories = (await FeaturedCategories.GetAsync()).ToList();

                // Get a list of featured games grouped by category for region US
                List<FeaturedCategory> featuredCategories2 = (await FeaturedCategories.GetAsync("DE")).ToList();

                var userDetails = (await UserDetails.GetAsync("ApiKeyHere", 76561198022184722, true));

                int a = 0;
                int b = a;
            }
            catch(Exception ex)
            {
                int x = 0;
                int y = x;
            }
  
        }
    }
}
