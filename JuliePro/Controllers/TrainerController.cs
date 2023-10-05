using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.ViewModels;

namespace JuliePro.Controllers
{
    public class TrainerController : Controller
    {
        private ApplicationDbContext _baseDonnees { get; set; }

        public TrainerController(ApplicationDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            var trainersList = _baseDonnees.Trainers.Include(u => u.Speciality);
            return View(trainersList);
        }


        public IActionResult Create()
        {
            TrainerVM trainerVM = new TrainerVM();
            trainerVM.TrainerTypeSelectList = _baseDonnees.Trainers.Select(t => new SelectListItem
            {
                Text = t.FirstName,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(trainerVM);
        }

        [HttpPost]
        public IActionResult Create(TrainerVM trainerVM)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Trainers.Add(trainerVM.Trainer);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Speciality {trainerVM.Trainer.FirstName} added";
                return RedirectToAction("Index");
            }
            trainerVM.TrainerTypeSelectList = _baseDonnees.Specialities.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(trainerVM);
        }

        public IActionResult Edit(int id)
        {
            TrainerVM trainerVM = new TrainerVM();
            trainerVM.Trainer = _baseDonnees.Trainers.Find(id);
            trainerVM.TrainerTypeSelectList = _baseDonnees.Trainers.Select(t => new SelectListItem
            {
                Text = t.FirstName,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(trainerVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TrainerVM trainerVM)
        {
            //Si le modèle est valide le zombie est modifié et nous sommes redirigé vers index.
            if (ModelState.IsValid)
            {
                _baseDonnees.Trainers.Update(trainerVM.Trainer);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Speciality {trainerVM.Trainer.FirstName} has been modified";
                return RedirectToAction("Index");
            }
            trainerVM.TrainerTypeSelectList = _baseDonnees.Trainers.Select(t => new SelectListItem
            {
                Text = t.FirstName,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(trainerVM);
        }

        public IActionResult Delete(int id)
        {
            var trainers = _baseDonnees.Trainers.Include(u => u.Speciality);
            var trainer = trainers.Where(i => i.Id == id).FirstOrDefault(); if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            Trainer? trainer = _baseDonnees.Trainers.Find(id);
            if (trainer == null)
            {
                return NotFound();
            }

            _baseDonnees.Trainers.Remove(trainer);
            _baseDonnees.SaveChanges();
            TempData["Success"] = $"Speciality {trainer.FirstName} terminated";
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var trainers = _baseDonnees.Trainers.Include(u => u.Speciality);
            var trainer = trainers.Where(i => i.Id == id).FirstOrDefault();
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }
    }
}
