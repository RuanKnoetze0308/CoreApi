using System;
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

        public void CreateApi(Api ap)
        {
            if(ap == null)
            {
                throw new ArgumentNullException(nameof(ap));
            }

            _context.Apis.Add(ap);
        }

        public void DeleteApi(Api delete)
        {
            
            if(delete == null)
            {
                throw new ArgumentNullException(nameof(delete));
            }
            _context.Apis.Remove(delete);
        }

        public IEnumerable<Api> GetAllCommands()
        {
            return _context.Apis.ToList();
        }

        public Api GetApibyId(int id)
        {
            return _context.Apis.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return( _context.SaveChanges() >= 0);
        }

        public void UpdateApi(Api update)
        {
            
        }
    }
}