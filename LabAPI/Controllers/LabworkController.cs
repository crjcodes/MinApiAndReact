using LabAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LabAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LabworkController : Controller
    {
        private readonly List<FlattenedLabRecord> _records;

        public LabworkController(IOptions<List<FlattenedLabRecord>> recordsOptions)
        {
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
