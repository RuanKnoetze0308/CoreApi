

using System.Collections.Generic;
using CoreApi.Models;

namespace CoreApi.Data
{
    public interface IApiRepo
    {
        IEnumerable<Api> GetAllCommands();
        Api GetApibyId(int id);
    }
}