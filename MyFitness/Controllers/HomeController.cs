using Microsoft.AspNetCore.Mvc;
using MyFitness.Models.Data;
using MyFitness.Models.Domain;

namespace MyFitness.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyFitnessContext _context;

        public HomeController(MyFitnessContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                MembersCount = _context.Members.Count(),
                TrainersCount = _context.Trainers.Count(),
                MembershipsCount = _context.Memberships.Count(),
                MembershipTypesCount = _context.MembershipTypes.Count(),
                EquipmentCount = _context.Equipment.Count()
            };

            return View(viewModel);
        }
    }
}
