/*using System.Collections.Generic;
using Parts.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private IPartRepository _partRepository { get; set; }

        public PartController(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        [HttpGet]
        public IEnumerable<Part> Get()
        {
            return _partRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Part Get(int id)
        {
            return _partRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Part part)
        {
            _partRepository.Add(part);
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Part part)
        {
            _partRepository.Update(part);
            return Ok();
        }

    }
}*/