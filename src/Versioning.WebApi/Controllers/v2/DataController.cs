﻿using Microsoft.AspNetCore.Mvc;

namespace Versioning.WebApi.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "data from api v2";
        }
    }
}
