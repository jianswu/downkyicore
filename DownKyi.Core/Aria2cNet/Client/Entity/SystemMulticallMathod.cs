﻿using Newtonsoft.Json;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

[JsonObject]
public class SystemMulticallMathod
{
    [JsonProperty("method")] public string Method { get; set; }

    [JsonProperty("params")] public List<object> Params { get; set; }
}