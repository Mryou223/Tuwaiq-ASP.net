using ClinicDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicDemo.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View(Seeding.clients);
        }
        public IActionResult Details(int Id)
        {
            var client = Seeding.clients.First(c=> c.Id == Id);
            return View(client);
        }
    }
}
