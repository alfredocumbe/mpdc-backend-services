namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Manufacture { get; set; }
    public string Model { get; set; }
    public string Capacity { get; set; }
    public string Category { get; set; }
    public string Location { get; set; }
    public string UsageStatus { get; set; }
    public string Description { get; set; }
    public string MaintenanceStatus { get; set; }
    
    public virtual  ICollection<OtherDescription> otherDescription { get; set; }
    public virtual  ICollection<Image> images { get; set; }
    public virtual  ICollection<Warranty> warranty { get; set; }
}