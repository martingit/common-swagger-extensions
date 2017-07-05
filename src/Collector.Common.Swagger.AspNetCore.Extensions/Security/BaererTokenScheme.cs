﻿using Swashbuckle.AspNetCore.Swagger;

namespace Collector.Common.Swagger.AspNetCore.Extensions.Security
{
    public class BaererTokenScheme : SecurityScheme
    {
        public BaererTokenScheme()
        {
            Description = "Baerer Token";
            Type = "apiKey";
            Extensions.Add("in", "header");
            Extensions.Add("name", "Authorization");
        }
    }
}