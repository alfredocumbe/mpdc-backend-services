namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class OtherDescription
{
    public int Id { get; set; }
    public string Description { get; set; }
     [JsonIgnore]
    public virtual Asset asset { get; set; }
}