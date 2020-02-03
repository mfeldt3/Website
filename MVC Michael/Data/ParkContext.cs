using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Michael.Data.Entities;

namespace MVC_Michael.Data
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options): base(options)
    {

    }

    public DbSet<ParkImage> ParkImages { get; set; }
    public DbSet<ParkList> ParkLists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<ParkList>();

    }
  }
}
