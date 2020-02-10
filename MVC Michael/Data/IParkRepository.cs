using System.Collections.Generic;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using MVC_Michael.Data.Entities;

namespace MVC_Michael.Data
{
  public interface IParkRepository
  {
    IEnumerable<ParkList> GetAllParks();

    string SaveParkImage(IFormFile Image, int ParkId, string Title, string Description);

    Image byteArrayToImage(byte[] databaseImage);

    byte[] ImageToByteArray(IFormFile Image);

    IEnumerable<ParkImage> GetParkImages(int Park);

    IEnumerable<ParkImage> GetImageById(int ImageID);

    string DeleteImageById(int ImageID);
  }
}