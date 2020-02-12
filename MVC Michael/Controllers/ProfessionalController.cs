using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Michael.Models;

namespace MVC_Michael.Controllers
{
  public class ProfessionalController : Controller
  {
    private readonly ILogger<ProfessionalController> _logger;

    public ProfessionalController(ILogger<ProfessionalController> logger)
    {
      _logger = logger;
    }

    [Route("Professional")]
    public IActionResult Professional()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
