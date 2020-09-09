using System.Collections.Generic;
using CoreApi.Data;
using CoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/coreapis")]
    [ApiController]
    public class CoreApisController : ControllerBase
    {
        private readonly IApiRepo _repo;

        public CoreApisController(IApiRepo repository)
        {
            _repo = repository;
        }
       

        [HttpGet]
       public ActionResult<IEnumerable<Api>> GetAllCommands()
       {
           var apiItems = _repo.GetAllCommands();

           return Ok(apiItems);
       }
       
       [HttpGet("{id}")]
       public ActionResult<Api> GetApiById(int id)
       {
            var apiItem = _repo.GetApibyId(id);
            return Ok(apiItem);
       }


    }
}