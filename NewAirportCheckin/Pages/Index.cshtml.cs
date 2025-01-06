using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAirportCheckin.Data;
using NewAirportCheckin.Models;

namespace NewAirportCheckin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Passenger Passenger { get; set; }

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Passengers.Add(Passenger);
            _context.SaveChanges();
            return RedirectToPage("Confirmation", new { id = Passenger.Id });
        }
    }
}