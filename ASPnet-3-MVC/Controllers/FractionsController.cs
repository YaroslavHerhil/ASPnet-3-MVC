using ASPnet_3_MVC.Abstractor;
using ASPnet_3_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPnet_3_MVC.Controllers
{
    public class FractionsController : Controller
    {
        private readonly IFractionService _fractionService;

        public FractionsController(IFractionService fractionService)
        {
            _fractionService = fractionService;
        }


        public IActionResult FractionsView()
        {
            return View("FractionsView", new FractionOperationViewModel());
        }

        [HttpPost]
        public IActionResult Calculate(FractionOperationViewModel model) 
        {
            var result = _fractionService.Calculate(model);
            return View("FractionsView", model);
        }
    }
}
