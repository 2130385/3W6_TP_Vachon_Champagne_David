using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 4, ErrorMessage = "{0} must contains {2} to {1} characters.")]
        public string FirstName { get; set; }
        [StringLength(25, MinimumLength = 4, ErrorMessage = "{0} must contains {2} to {1} characters.")]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        private double startWeight;
        public double StartWeight
        {
            get { return startWeight; }
            set
            {
                if (value < 100 || value > 400)
                {
                    throw new ArgumentOutOfRangeException("StartWeight must be between 100 and 400.");
                }
                startWeight = value;
            }
        }

        public int TrainerId { get; set; }

        public ICollection<Objective> Objectives { get; set; }
    }
}
