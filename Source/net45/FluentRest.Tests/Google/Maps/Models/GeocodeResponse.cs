﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FluentRest.Tests.Google.Maps.Models
{

    public class GeocodeResponse
    {

        [JsonProperty("results")]
        public GeocodeResult[] Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

}