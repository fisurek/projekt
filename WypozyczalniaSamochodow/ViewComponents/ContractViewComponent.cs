using Microsoft.AspNetCore.Mvc;
using WypozyczalniaSamochodow.Models;

namespace WypozyczalniaSamochodow.ViewComponents
{
    public class ContractViewComponent : ViewComponent
    {
        private readonly pContext _context;

        public ContractViewComponent(pContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contracts = _context.Contract.Count();
            ViewData["contracts"] = contracts;
            return View();
        }
    }
}
