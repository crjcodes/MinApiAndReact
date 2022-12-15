using LabAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LabAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LabNamesController : Controller
    {
        // FUTURE: once data access layer is there, then shift to asynchronous calls
        // this little demo is okay on the performance front without going asynchronous

        private readonly List<string> _labNames;

        public LabNamesController(IOptions<List<FlattenedLabRecord>> recordsOptions)
        {
            // FUTURE: a better practice would be to have a data access layer and call it from here
            // whether a dbContext, service, db repository...
            // for now, with mock data, keeping it simple
            _labNames = recordsOptions.Value.Select(r => r.Name).Distinct().ToList();
        }

        [HttpGet(Name = "GetLabNames")]
        // GET: LabworkController
        public IEnumerable<string> Get()
        {
            return _labNames;
        }

    }
}
