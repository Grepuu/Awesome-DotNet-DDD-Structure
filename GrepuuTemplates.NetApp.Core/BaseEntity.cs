namespace GrepuuTemplates.NetApp.Core;

public class BaseEntity
{
    public Guid Id { get; set; }
    public EntityStatusEnum Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        Status = EntityStatusEnum.Active;
        CreatedAt = DateTime.UtcNow;
        CreatedBy = null;
        UpdatedAt = DateTime.UtcNow;
        UpdatedBy = null;
    }
}