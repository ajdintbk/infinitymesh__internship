using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Praksa.DAL.Repositories;

namespace praksa_rent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ColorController : Controller
    {
        private readonly ColorRepository _colorRepository;

        public ColorController(ColorRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var colors = await _colorRepository.Get();
            return Ok(colors);
            
        }
    }
}
