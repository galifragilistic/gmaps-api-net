﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace Google.Api.Maps.Service.Direction
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionResponse
    {
        [JsonProperty("status")]
        public ServiceResponseStatus Status { get; set; }

        [JsonProperty("routes" )]
        public DirectionRoute[] Routes { get; set; }
    }
}