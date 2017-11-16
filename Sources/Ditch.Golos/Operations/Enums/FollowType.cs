﻿using Ditch.Core.Helpers;
using Newtonsoft.Json;
namespace Ditch.Golos.Operations.Enums
{
    [JsonConverter(typeof(EnumConverter))]
    public enum FollowType
    {
        Undefined,
        Blog,
        Ignore
    }
}