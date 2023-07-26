namespace WebApi.Repositories;

using WebApi.Helpers;
using WebApi.Entities;

public class AssetImageRepository : IAssetImageRepository{

    private readonly DataContext _context;

    public AssetImageRepository(DataContext context)
    {
        _context = context;
    }

    public void AddRange(List<Image> assetImages)
    {
        _context.AssetImages.AddRange(assetImages);
    }

    public void UpdateRange(List<Image> assetImages)
    {
        _context.AssetImages.UpdateRange(assetImages);
    }

    public void Delete(long assetImageId)
    {
        var assetImage = _context.AssetImages.Find(assetImageId);
        if (assetImage != null)
            _context.AssetImages.Remove(assetImage);
    }
}
