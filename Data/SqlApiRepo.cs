using System.Collections.Generic;
using System.Linq;
using CoreApi.Models;

namespace CoreApi.Data
{
    public class SqlApiRepo : IApiRepo
    {
        private readonly ApiContext _context;

        public SqlApiRepo(ApiContext context)
        {
            _context = context;
        }
        public IEnumerable<Api> GetAllCommands()
        {
            return _context.Apis.ToList();
        }

        public Api GetApibyId(int id)
        {
            return _context.Apis.FirstOrDefault(p => p.Id == id);
        }
    }
}