using Core.Persistance.Repositories;

namespace Domain.Entities;

public class Fuel:Entity<Guid>
{
    public string Name { get; set; }
}