

using System.Collections.Generic;
using CoreApi.Models;

namespace CoreApi.Data
{
    public interface IApiRepo
    {
        bool SaveChanges();


        IEnumerable<Api> GetAllCommands();
        Api GetApibyId(int id);
        void CreateApi(Api ap);
        void UpdateApi(Api update);
        void DeleteApi(Api delete);
    }
}