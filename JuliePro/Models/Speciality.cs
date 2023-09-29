using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ValidateNever]
        public List<Speciality>? Specialities { get; set; }

    }
}
