namespace Webbutveckling_Backend_AlexanderForsberg.Models
{
    using System.ComponentModel.DataAnnotations;
    public class City
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "City Name")]
        [RegularExpression(@"^[A-Ö]+[a-öA-Ö0-9""'\s-]*$")]
        [StringLength(85, MinimumLength = 1)]
        public string? CityName { get; set; }

        [Display(Name = "Moved To")]
        [DataType(DataType.Date)]
        public DateTime MovedTo { get; set; }

        [Display(Name = "Moved From")]
        [DataType(DataType.Date)]
        public DateTime MovedFrom { get; set; }

        [Required]
        [RegularExpression(@"^[A-Ö]+[a-öA-Ö0-9""'\s-]*$")]
        [StringLength(60, MinimumLength = 1)]
        public string? Country { get; set; }
    }
}
