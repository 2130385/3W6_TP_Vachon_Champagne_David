using Microsoft.EntityFrameworkCore;
using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JuliePro.Controllers
{
    public class ObjectiveController : Controller
    {
        private ApplicationDbContext _baseDonnees { get; set; }

        public ObjectiveController(ApplicationDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            List<Trainer> objectivesList = _baseDonnees.Trainers.Include(t => t.Customers).ThenInclude(o =>o.Objectives).Include(s =>s.Speciality).ToList();
            return View(objectivesList);
        }
    }
}
