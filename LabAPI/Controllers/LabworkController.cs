﻿using LabAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LabAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LabworkController : Controller
    {

        // FUTURE: once data access layer is there, then shift to asynchronous calls
        // this little demo is okay on the performance front without going asynchronous

        private readonly List<FlattenedLabRecord> _records;

        public LabworkController(IOptions<List<FlattenedLabRecord>> recordsOptions)
        {
            // FUTURE: a better practice would be to have a data access layer and call it from here
            // whether a dbContext, service, db repository...
            // for now, with mock data, keeping it simple
            _records = recordsOptions.Value;
        }

        [HttpGet(Name = "GetLabwork")]
        // GET: LabworkController
        public IEnumerable<FlattenedLabRecord> Get()
        {
            return _records;
        }
    }
}
