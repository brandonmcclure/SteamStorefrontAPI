﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SteamStorefrontAPI.Classes
{
    public class Recommendations
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        public override string ToString() => Total.ToString();
    }
}
