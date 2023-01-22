using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using WypozyczalniaSamochodow.Models;

namespace WypozyczalniaSamochodow.ViewComponents
{
    public class CarViewComponent : ViewComponent
    {
        private readonly pContext _context;

        public CarViewComponent(pContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cars = _context.Car.Count();
            ViewData["cars"] = cars;
            return View();
        }
    }
}
