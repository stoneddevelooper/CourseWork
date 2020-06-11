using Parts.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPart.Controllers
{
    [Route("html/[controller]")]
    public class HtmlSelectionController : Controller
    {
        private ISelectionRepository _selectionRepository { get; set; }

        public HtmlSelectionController(ISelectionRepository selectionRepository)
        {
            _selectionRepository = selectionRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_selectionRepository.GetAllSets());
        }


        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_selectionRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Selection selection)
        {
            try
            {
                _selectionRepository.Add(selection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("update/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_selectionRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Selection selection)
        {
            try
            {
                _selectionRepository.Update(selection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("remove/{id}")]
        public ActionResult Delete(int id)
        {
            return View(_selectionRepository.Get(id));
        }

        [HttpDelete("remove/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [FromForm] Selection selection)
        {
            try
            {
                _selectionRepository.Remove(selection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

 /*       [HttpGet("remove/{id}")]
        public ActionResult DeletePart(int id)
        {
            return View(_selectionRepository.Get(id));
        }
        public ActionResult DeletePart(int id, Selection selection)
        {
            try
            {
               
            }
            catch
            {
                return View();
            }
        }*/
    }
}