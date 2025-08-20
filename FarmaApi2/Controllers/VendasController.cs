using FarmaApi2.DTOs;
using FarmaApi2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi2.Controllers
{
    public class VendasController : ControllerBase
    {
        private readonly IVendasServices _vendasServices;
        public VendasController(IVendasServices vendasServices)
        {
            _vendasServices = vendasServices;
        }

        [HttpPost(Name = "CreateVendas")]

        public IActionResult CreateVendas(VendasDTO dto)
        {
            Lis
            return View();
        }
    }
}
