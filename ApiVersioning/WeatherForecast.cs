using System.ComponentModel.DataAnnotations;

namespace DotNet8ApiDemo
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        //[Range(0, 50, MinimumIsExclusive = true, MaximumIsExclusive = true)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //[AllowedValues("", "", "")]
        //[DeniedValues("", "", ErrorMessage = "")]
        //[Length(1, 20, ErrorMessage = "")]
        public string? Summary { get; set; }
    }
}
