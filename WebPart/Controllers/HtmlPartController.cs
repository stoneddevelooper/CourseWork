/*using Parts.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPart.Controllers
{
    [Route("html/[controller]")]
    public class HtmlPartController : Controller
    {
        private IPartRepository _partRepository { get; set; }

        public HtmlPartController(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_partRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Parts(int id)
        {
            return View(_partRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Part part)
        {
            try
            {
                _partRepository.Add(part);

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
            return View(_partRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Part part)
        {
            try
            {
                _partRepository.Update(part);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}*/