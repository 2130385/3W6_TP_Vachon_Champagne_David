using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15, MinimumLength = 5, ErrorMessage = "{0} must contains {2} to {1} characters.")]
        public string Name { get; set; }
        private double lostWeightKg;
        public double LostWeightKg
        {
            get { return lostWeightKg; }
            set
            {
                if (value < 2 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("LostWeightKg must be between 2 and 10.");
                }
                lostWeightKg = value;
            }
        }
        private double distanceKm;
        public double DistanceKm
        {
            get { return distanceKm; }
            set
            {
                if (value < 2 || value > 45)
                {
                    throw new ArgumentOutOfRangeException("DistanceKm must be between 2 and 10.");
                }
                distanceKm = value;
            }
        }
        public DateTime? AchievedDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
