using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Data;  

namespace WebApp1.Pages
{
    [Authorize]
    public class RoomHandler : PageModel
    {
        private readonly ApplicationDbContext _context; 

        public RoomHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Room Room { get; set; }
      
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Rooms.Add(Room);
                await _context.SaveChangesAsync();
                Console.WriteLine(Room.Id + " " + Room.RoomName + " " + Room.Capacity + " has been added successfully!");
                return RedirectToPage("./ListRooms");
            }
            else{
                Console.WriteLine("Room can not add to DB!");
                return RedirectToPage("./Index");
            }
        }
    }
}

