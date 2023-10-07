using Microsoft.AspNetCore.Mvc.Rendering;
using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class TrainerVM
    {
        public Trainer Trainer { get; set; }
        public IEnumerable<SelectListItem>? TrainerTypeSelectList { get; set; }
    }
}
