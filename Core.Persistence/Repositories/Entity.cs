namespace Core.Persistance.Repositories;

public class Entity<TId>:IEntityTimestamps
{
    public TId Id { get; set; }
    public Entity()
    {
        Id = default!;
    }

    public Entity(TId id)
    {
        Id = id;
    }

    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}