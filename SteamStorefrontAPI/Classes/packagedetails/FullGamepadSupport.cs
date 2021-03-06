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
    public class FullGamepadSupport
    {
        [JsonProperty("full_gamepad")]
        public bool FullGamepad { get; set; }

        public override string ToString() => FullGamepad.ToString();
    }
}
