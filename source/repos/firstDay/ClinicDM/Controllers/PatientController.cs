using ClinicDM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ClinicDM.Controllers
{
    public class PatientController : Controller
    {


        public IActionResult Index()
        {
            return View(Models.Constants.Patients);
        }

        public IActionResult Details(int id)
        {

            var patient = Models.Constants.Patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }
    }
}