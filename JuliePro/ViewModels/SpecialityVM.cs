using Microsoft.AspNetCore.Mvc.Rendering;
using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class SpecialityVM
    {
        public Speciality Speciality { get; set; }
        public IEnumerable<SelectListItem>? SpecialityTypeSelectList { get; set; }
    }
}
