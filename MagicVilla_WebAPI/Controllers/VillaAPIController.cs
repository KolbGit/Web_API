using MagicVilla_WebAPI.Models;
using MagicVilla_WebAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_WebAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO> {
                new VillaDTO{Id=1,Name="Pool View" },
                new VillaDTO{Id=2,Name="Beach View" }
            };
        }
    }
}
