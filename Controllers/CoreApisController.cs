using System.Collections.Generic;
using AutoMapper;
using CoreApi.Data;
using CoreApi.Dtos;
using CoreApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/coreapis")]
    [ApiController]
    public class CoreApisController : ControllerBase
    {
        private readonly IApiRepo _repo;
        private readonly IMapper _mapper;

        public CoreApisController(IApiRepo repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }
       

        [HttpGet]
       public ActionResult<IEnumerable<ApiReadDto>> GetAllCommands()
       {
           var apiItems = _repo.GetAllCommands();

           return Ok(_mapper.Map<ApiReadDto>(apiItems));
       }
       
       [HttpGet("{id}", Name = "GetApiById")]
       public ActionResult<ApiReadDto> GetApiById(int id)
       {
            var apiItem = _repo.GetApibyId(id);
            if(apiItem != null)
            {
                return Ok(_mapper.Map<ApiReadDto>(apiItem));
            }
            
            return NotFound();
       }

       [HttpPost]
       public ActionResult <ApiReadDto> CreateApi(ApiCreateDto apiCreateDto)
       {
           var apiModel = _mapper.Map<Api>(apiCreateDto);
           _repo.CreateApi(apiModel);
           _repo.SaveChanges();


           var apiReadDto = _mapper.Map<ApiReadDto>(apiModel);

           return CreatedAtRoute(nameof(GetApiById), new {Id = apiReadDto.Id}, apiReadDto);

           //return Ok(apiReadDto);
       }

       [HttpPut("{id}")]
       public ActionResult UpdateApi(int id, ApiUpdateDto apiUpdateDto)
       {
          var apiModelFromRepo = _repo.GetApibyId(id);
          if(apiModelFromRepo == null)
          {
              return NotFound();
          }

          _mapper.Map(apiUpdateDto, apiModelFromRepo);

          _repo.UpdateApi(apiModelFromRepo);
          _repo.SaveChanges();
          return NoContent(); 
       }

       [HttpPatch("{id}")]
       public ActionResult PartialApiUpdate(int id, JsonPatchDocument<ApiUpdateDto> patchDoc)
       {
          var apiModelFromRepo = _repo.GetApibyId(id);
          if(apiModelFromRepo == null)
          {
              return NotFound();
          }

          var apiToPatch = _mapper.Map<ApiUpdateDto>(apiModelFromRepo);
          patchDoc.ApplyTo(apiToPatch, ModelState);

          if(!TryValidateModel(apiToPatch))
          {
              return ValidationProblem(ModelState);
          }
          
          _mapper.Map(apiToPatch, apiModelFromRepo);

           _repo.UpdateApi(apiModelFromRepo);
           
           _repo.SaveChanges();

           return NoContent(); 
       }
    
        [HttpDelete("{id}")]
        public ActionResult DeleteApi(int id)
        {
          var apiModelFromRepo = _repo.GetApibyId(id);
          if(apiModelFromRepo == null)
          {
              return NotFound();
          }
           _repo.DeleteApi(apiModelFromRepo); 
           _repo.SaveChanges();

           return NoContent();
        }

   }
}