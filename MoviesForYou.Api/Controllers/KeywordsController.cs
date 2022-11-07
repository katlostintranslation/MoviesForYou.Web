using Microsoft.AspNetCore.Mvc;
using MoviesForYou.Api.Models;
using MoviesForYou.Data;

namespace MoviesForYou.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeywordsController : ControllerBase
    {
        

        private readonly ILogger<KeywordsController> _logger;
        private readonly ApplicationDbContext _context;

        public KeywordsController(ILogger<KeywordsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<KeywordDto> Get(string? query)

        {   
            if(string.IsNullOrEmpty(query))
            {
                return new List<KeywordDto>();
            }

            return _context.Keywords.Where(o => o.Value.Contains(query, StringComparison.InvariantCultureIgnoreCase)).ToArray()
            .Select(o => new KeywordDto()
            {
                Id = o.Id,
                Value = o.Value
            });
            
        }
    }
}