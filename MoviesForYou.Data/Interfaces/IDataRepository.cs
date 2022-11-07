using MoviesForYou.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesForYou.Data.Interfaces
{
   public interface IDataRepository
    {
        IEnumerable<Keyword> GetOwners(string query);
    }
}
