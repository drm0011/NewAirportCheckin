using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAirportCheckin.Data;
using NewAirportCheckin.Models;

namespace NewAirportCheckin.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly AppDbContext _context;

        public Passenger Passenger { get; set; }

        public ConfirmationModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Passenger = _context.Passengers.Find(id);
        }
    }
}
