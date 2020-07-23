using Parts.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Runtime.CompilerServices;

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
                selection.PartInSelelections.Add(new PartInSelection { SelectionId = selection.Id, PartId = selection.PartId });
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
                //selection.PartInSelelections.Find(b => b.SelectionId == selection.Id).PartId = selection.PartId;
                /*                using (AppDbContext app = new AppDbContext())
                                {
                                     List<PartInSelection> pIs = selection.PartInSelelections.FindAll(e => e.SelectionId == selection.Id);

                foreach (var e in pIs)
                {
                    selection.PartInSelelections.Remove(e);
                }
                                    pis.PartId = selection.PartId;
                                    app.SaveChanges();
                                }*/

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

        [HttpPost("remove/{id}"), ActionName("Delete")]
        //[HttpDelete("remove/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, [FromForm] Selection selection)
        {
            try
            {/*
                using AppDbContext db = new AppDbContext();
                Selection selection = db.Selections.Find(id);*/
/*                List<PartInSelection> pIs = selection.PartInSelelections.FindAll(e => e.SelectionId == selection.Id);

                foreach (var e in pIs)
                {
                    selection.PartInSelelections.Remove(e);
                }*/
                //db.Selections.Remove(selection);

                _selectionRepository.Remove(selection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}