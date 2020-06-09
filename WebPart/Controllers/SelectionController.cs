using System.Collections.Generic;
using Parts.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectionController : ControllerBase
    {
        private ISelectionRepository _selectionRepository { get; set; }

        public SelectionController(ISelectionRepository selectionRepository)
        {
            _selectionRepository = selectionRepository;
        }

        [HttpGet]
        public IEnumerable<Selection> Get()
        {
            return _selectionRepository.GetAllSets();
        }


        [HttpGet("{id}")]
        public Selection Get(int id)
        {
            return _selectionRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Selection selection)
        {
            _selectionRepository.Add(selection);
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Selection selection)
        {
            _selectionRepository.Update(selection);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id, [FromBody] Selection selection)
        {
            _selectionRepository.Remove(selection);
            return Ok();
        }

    }
}