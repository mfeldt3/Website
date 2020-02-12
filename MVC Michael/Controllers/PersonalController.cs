using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Michael.Data;
using MVC_Michael.Data.Entities;
using MVC_Michael.Models;

namespace MVC_Michael.Controllers
{
  public class PersonalController : Controller
  {
    private readonly ILogger<PersonalController> _logger;
    private readonly IParkRepository _repository;

    public PersonalController(ILogger<PersonalController> logger, IParkRepository repository)
    {
      _logger = logger;
      this._repository = repository;
    }

    [Route("Parks")]
    public IActionResult Personal()
    {
      var results = _repository.GetAllParks();
      return View(results);
    }

    [HttpPost]
    public IActionResult SaveImage(IFormFile Image, ParkImage ParkImageDetails, string ParkName)
    {
      if (ParkImageDetails == null)
      {
        return View("Details were not filled out");
      }
      var results = _repository.SaveParkImage(Image, ParkImageDetails.ParkId, ParkImageDetails.Title, ParkImageDetails.Description);
      return RedirectToAction("ParkImages", new { parkListId = ParkImageDetails.ParkId, parkName = ParkName });

    }
    [Route("Images")]
    public IActionResult ParkImages(int parkListId, string parkName)
    {
      if (parkListId > 0 && parkListId < 60)
      {
        dynamic ParkImagesAndDetails = new ExpandoObject();
        var ParkList = new ParkList();
        ParkList.ParkListId = parkListId;
        ParkList.ParkName = parkName;
        ParkImagesAndDetails.ParkDetails = ParkList;
        var parkImages = _repository.GetParkImages(parkListId);
        ParkImagesAndDetails.ParkImages = parkImages;
        return View(ParkImagesAndDetails);
      }
      else
      {
        return View();
      }
    }

    public IActionResult GetImageById(int ImageId)
    {
      var ParkImage = _repository.GetImageById(ImageId);
      FileContentResult ImageFile=null;
      foreach (ParkImage park in ParkImage)
      {
        if (park.Image == null)
        { 
          ImageFile = null;
          break;
        }
        ImageFile= File(park.Image, "image/jpg");
        break;
      }
      return ImageFile;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult DeleteImageById(int ImageId, string Parkname, string ParkId)
    {
      var result = _repository.DeleteImageById(ImageId);
      if (result == "successful")
      {
        return RedirectToAction("ParkImages", new { parkListId = ParkId, parkName = Parkname });
      }
      else
      {
        return View(result);
      }
    }
  }
}
