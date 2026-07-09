using System;
using Microsoft.AspNetCore.Mvc;

namespace BasitBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class YonlendirmeController : ControllerBase
    {
        [HttpGet]
        public IActionResult AdresVer()
        {
            // Sadece YouTube linkini React'e gönderiyoruz
            return Ok(new { url = "https://www.youtube.com/" });
        }
    }
}

public class Class1
{
	public Class1()
	{
	}
}
