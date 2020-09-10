/*using System.Collections.Generic;
using CoreApi.Models;

namespace CoreApi.Data
{
    public class MockCoreRepo : IApiRepo
    {
        public Api GetApibyId(int id)
        {
           return new Api{Id=0, HowTo="Boil and egg", Line="Boil Water", Platform="Kettle & Pan"};
           
        }

        public IEnumerable<Api> GetAllCommands()
        {
            var api = new List<Api>
            {
                 new Api{Id=0, HowTo="Boil and egg", Line="Boil Water", Platform="Kettle & Pan"},
                 new Api{Id=1, HowTo="Cut Bread", Line="Get a Knife", Platform="Knife & Chopping Board"},
                 new Api{Id=2, HowTo="Make a Cup of Tea", Line="Place teabag in cup", Platform="Kettle & Cup"}
            };

            return api;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreateApi(Api ap)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateApi(Api update)
        {
            throw new System.NotImplementedException();
        }
    }
}*/