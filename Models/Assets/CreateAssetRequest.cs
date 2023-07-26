namespace WebApi.Models.Assets;

using WebApi.Entities;

public class CreateAssetRequest
{
    public CreateAsset createAsset { get; set; }
    public List<CreateImage> createImages { get; set; }
    public List<CreateDescription> createDescriptions { get; set; }
    public CreateWarranty createWarranty { get; set; }
}