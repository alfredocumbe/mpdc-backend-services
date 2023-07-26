namespace WebApi.Models.Assets;

using System.Text.Json.Serialization;

public class CreateImage
{
    public string FileName { get; set; }
    public string FileLocation { get; set; }
    public string Url { get; set; }
}