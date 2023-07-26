namespace WebApi.Models.Assets;

using WebApi.Entities;

public class CreateAssetResponse
{
    public Asset asset { get; set; }
    public List<Image> assetImages { get; set; }
    public List<OtherDescription> assetDescriptions { get; set; }
    public Warranty warranty { get; set; }
}