using Microsoft.AspNetCore.Mvc;
using WypozyczalniaSamochodow.Models;

namespace WypozyczalniaSamochodow.ViewComponents
{
    public class CustomerViewComponent : ViewComponent
    {
        private readonly pContext _context;

        public CustomerViewComponent(pContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var customers = _context.Customer.Count();
            ViewData["customers"] = customers;
            return View();
        }
    }
}
