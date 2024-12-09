using Core.Persistance.Repositories;

namespace Domain.Entities;

public class Model:Entity<Guid>
{
    public int BrandId { get; set; }
    public string Name { get; set; }
    public Decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }
}