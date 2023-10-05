using Microsoft.AspNetCore.Mvc.Rendering;
using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class SpecialityVM
    {
        public Speciality Speciality { get; set; }
        public List<Trainer> TrainersList { get; set; } = new List<Trainer>();
        public IEnumerable<SelectListItem>? SpecialityTypeSelectList { get; set; }
    }
}
