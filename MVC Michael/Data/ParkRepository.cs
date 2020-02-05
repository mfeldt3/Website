using MVC_Michael.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace MVC_Michael.Data
{
  public class ParkRepository : IParkRepository
  {
    private readonly ParkContext _ctx;

    public ParkRepository(ParkContext ctx)
    {
      _ctx = ctx;
    }

    public IEnumerable<ParkList> GetAllParks()
    {
      return _ctx.ParkLists
                  .OrderBy(p => p.ParkListId)
                  .ToList();
    }

    public string SaveParkImage(IFormFile Image, int ParkId, string Title, string Description)
    {
      if (Image == null)
      {
        return "The file was not found";
      }
      var NewImage = new ParkImage()
      {
        Image = ImageToByteArray(Image),
        ParkId = ParkId,
        Title = Title,
        Description = Description
      };
        _ctx.ParkImages.Add(NewImage);
        _ctx.SaveChanges();
        return "The file was saved";
      
    }

    //Used to convert new image to byte array of image
    public byte[] ImageToByteArray(IFormFile Image)
    {

      if (Image != null)
      {
        if (Image.ContentType.ToLower().StartsWith("image/"))
        {
          byte[] byteImage;
          using (BinaryReader reader = new BinaryReader(Image.OpenReadStream()))
          {
            byteImage = reader.ReadBytes((int)Image.OpenReadStream().Length);
          }
          return byteImage;
        }
      }
      return null;

    }

    public IEnumerable<ParkImage> GetParkImages(int Park)
    {
      return _ctx.ParkImages
                .Where(pi => pi.ParkId == Park)
                .OrderBy(p => p.Id)
                .ToList();
    }

    public IEnumerable<ParkImage> GetImageById(int ImageID)
    {
      return _ctx.ParkImages
                .Where(pi => pi.Id == ImageID);
    }

    //Used to convert ByteArray Image to image from database
    public Image byteArrayToImage(byte[] databaseImage)
    {
      using MemoryStream imgStream = new MemoryStream(databaseImage);
      return Image.FromStream(imgStream);
    }
  }
}
