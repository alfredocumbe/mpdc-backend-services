namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Image
{
    public int Id { get; set; }
    public string FileName { get; set; }
    public string FileLocation { get; set; }
    public string Url { get; set; }
    [JsonIgnore]
    public virtual  Asset asset { get; set; }
}