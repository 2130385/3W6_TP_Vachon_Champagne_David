using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Speciality Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} must contains {2} to {1} characters.")]
        public string Name { get; set; }

        [ValidateNever]
        public List<Trainer> Trainers { get; set; }
    }
}
