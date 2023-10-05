using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Trainer
    {
        [Key]
        [Display(Name = "Trainer Id")]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "{0} must contains {2} to {1} characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "{0} must contains {2} to {1} characters.")]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(40)]
        public string Photo { get; set; }

        [ForeignKey("Speciality")]
        public int SpecialityId { get; set; }
        [ValidateNever]
        public Speciality Speciality { get; set; }

    }
}
