using System.ComponentModel.DataAnnotations.Schema;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;
public abstract class Entity<T> : IEntity<T>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public bool IsDeleted { get; protected set; }
}

/*public abstract class Entity : Entity<Guid>
{
    protected Entity()
    {
        Id = Guid.NewGuid();
    }
}*/