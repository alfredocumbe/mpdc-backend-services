namespace WebApi.Repositories;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Helpers;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class AssetRepository : IAssetRepository
{

    private readonly DataContext _context;

    public AssetRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(Asset asset)
    {
        _context.Assets.Add(asset);
    }

    public void Update(Asset asset)
    {
        _context.Assets.Update(asset);
    }

    public void Delete(long assetId)
    {
        var asset = _context.Assets.Find(assetId);
        if (asset != null)
            _context.Assets.Remove(asset);
    }

    public IEnumerable<Asset> GetAll()
    {
        var assets = _context.Assets.Include(c => c.images).
        Include(c => c.otherDescription).
        Include(c => c.warranty).ToList();
        return assets;
    }

    public Asset GetById(int id)
    {
        var asset = _context.Assets.
        Include(c => c.images).
        Include(c => c.otherDescription).
        Include(c => c.warranty).SingleOrDefault(c => c.Id == id);
        return asset;
    }
}