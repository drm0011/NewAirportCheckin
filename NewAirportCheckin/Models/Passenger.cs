using System.ComponentModel.DataAnnotations;

namespace NewAirportCheckin.Models
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PassengerName { get; set; }

        [Required]
        public string FlightNumber { get; set; }
    }
}
