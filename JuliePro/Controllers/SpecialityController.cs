using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.ViewModels;

namespace JuliePro.Controllers
{
    public class SpecialityController : Controller
    {
        private ApplicationDbContext _baseDonnees { get; set; }

        public SpecialityController(ApplicationDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            List<Speciality> specialitiesList = _baseDonnees.Specialities.OrderBy(z => z.Name).ToList();
            return View(specialitiesList);
        }


        public IActionResult Create()
        {
            SpecialityVM SpecialityVM = new SpecialityVM();
            SpecialityVM.SpecialityTypeSelectList = _baseDonnees.Specialities.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(SpecialityVM);
        }

        [HttpPost]
        public IActionResult Create(SpecialityVM specialityVM)
        {
            //Si le modèle est valide le zombie est ajouté et nous sommes redirigé vers index.
            if (ModelState.IsValid)
            {
                _baseDonnees.Specialities.Add(specialityVM.Speciality);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Speciality {specialityVM.Speciality.Name} added";
                return this.RedirectToAction("Index");
            }
            specialityVM.SpecialityTypeSelectList = _baseDonnees.Specialities.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(specialityVM);
        }

        public IActionResult Edit(int id)
        {
            SpecialityVM specialityVM = new SpecialityVM();
            specialityVM.Speciality = _baseDonnees.Specialities.Find(id);
            specialityVM.SpecialityTypeSelectList = _baseDonnees.Specialities.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(specialityVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SpecialityVM specialityVM)
        {
            //Si le modèle est valide le zombie est modifié et nous sommes redirigé vers index.
            if (ModelState.IsValid)
            {
                _baseDonnees.Specialities.Update(specialityVM.Speciality);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Speciality {specialityVM.Speciality.Name} has been modified";
                return this.RedirectToAction("Index");
            }
            specialityVM.SpecialityTypeSelectList = _baseDonnees.Specialities.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(specialityVM);
        }

        public IActionResult Delete(int id)
        {
            Speciality? speciality = _baseDonnees.Specialities.Include(z => z.Specialities).FirstOrDefault(z => z.Id == id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            Speciality? speciality = _baseDonnees.Specialities.Find(id);
            if (speciality == null)
            {
                return NotFound();
            }

            _baseDonnees.Specialities.Remove(speciality);
            _baseDonnees.SaveChanges();
            TempData["Success"] = $"Speciality {speciality.Name} terminated";
            return RedirectToAction("Index");
        }
    }
}
