﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OAuthTwitterWrapper.JsonTypes;

namespace OAuthTwitterWrapper.JsonTypes
{

    public class Entities
    {

        [JsonProperty("description")]
        public Description Description { get; set; }
    }

}
