using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MVC_Michael.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MVC_Michael.Data
{
  public class ParkListSeeder
  {
    private readonly ParkContext _ctx;
    private readonly IWebHostEnvironment _hosting;

      public ParkListSeeder(ParkContext ctx, IWebHostEnvironment hosting)
    {
      _ctx = ctx;
      _hosting = hosting;
    }

    public void Seed()
    {
      _ctx.Database.EnsureCreated();

      if (!_ctx.ParkLists.Any())
      {
        //create park list data
        var filepath = Path.Combine(_hosting.ContentRootPath, "Data/parklistinfo.json");
        var json = File.ReadAllText(filepath);
        var parklist = JsonConvert.DeserializeObject<IEnumerable<ParkList>>(json);
        _ctx.ParkLists.AddRange(parklist);
        _ctx.SaveChanges();
      }
    }
  }
}
