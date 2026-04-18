namespace PustokAppMvc.Models.Common;

public class BaseEntity
{
    public Guid Id { get; init; }
    
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }
}

// public class AuditEntity: BaseEntity
// {
//     public DateTime CreatedOn { get; set; }
//     public DateTime ModifiedOn { get; set; }
//     public bool IsDeleted { get; set; }
// }