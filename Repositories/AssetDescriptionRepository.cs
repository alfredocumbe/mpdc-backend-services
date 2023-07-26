namespace WebApi.Repositories;

using WebApi.Entities;
using WebApi.Helpers;

public class AssetDescriptionRepository : IAssetDescriptionRepository{

    private readonly DataContext _context;

    public AssetDescriptionRepository(DataContext context)
    {
        _context = context;
    }

     public void AddRange(List<OtherDescription> assetDescriptions)
    {
        _context.AssetDescriptions.AddRange(assetDescriptions);
    }

    public void UpdateRange(List<OtherDescription> assetDescriptions)
    {
        _context.AssetDescriptions.UpdateRange(assetDescriptions);
    }

    public void Delete(long assetDescriptionId)
    {
        var assetDescription = _context.AssetDescriptions.Find(assetDescriptionId);
        if (assetDescription != null)
            _context.AssetDescriptions.Remove(assetDescription);
    }
}
