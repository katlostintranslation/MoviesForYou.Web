using Microsoft.EntityFrameworkCore;
using MoviesForYou.Data.Interfaces;
using MoviesForYou.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesForYou.Data
{
    public class DataRepository : IDataRepository
    {
        public IEnumerable<Keyword> GetOwners(string query)
        {
            var options = new DbContextOptions<ApplicationDbContext>();


            using (var context = new ApplicationDbContext(options))
            {
                return context.Keywords.Where(o => o.Value.Contains(query, StringComparison.InvariantCultureIgnoreCase)).ToArray();

            }
        }
    }
}
