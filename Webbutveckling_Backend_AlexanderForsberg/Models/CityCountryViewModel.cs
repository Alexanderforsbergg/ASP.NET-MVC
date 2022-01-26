namespace Webbutveckling_Backend_AlexanderForsberg.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    public class CityCountryViewModel
    {
        public List<City>? Cities { get; set; }
        public SelectList? Country { get; set; }
        public string? CityCountry { get; set; }
        public string? SearchString { get; set; }
    }
}
