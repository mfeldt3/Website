namespace MVC_Michael.Data.Entities
{
  public class ParkImage
  {
    public int Id { get; set; }
    public int ParkId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public byte[] Image { get; set; }
  }
}
