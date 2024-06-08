using GlobalSolutionNET.Data;
using GlobalSolutionNET.Models;
using GlobalSolutionNET.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GlobalSolutionNET.Controllers
{
    public class DronesController : Controller
    {
        
        private readonly ApplicationDbContext dbContext;

        public DronesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddDroneViewModel viewModel)
        {
            var drone = new Drone
            {
                Name = viewModel.Name,
                Model = viewModel.Model,
                Manufacturer = viewModel.Manufacturer,
                OperatorId = viewModel.OperatorId,
            };

            await dbContext.Drones.AddAsync(drone);
            await dbContext.SaveChangesAsync();


            return View();
        }
    }
}
