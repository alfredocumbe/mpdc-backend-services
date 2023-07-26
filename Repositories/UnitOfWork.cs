namespace WebApi.Repositories;

using WebApi.Helpers;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly WebApi.Helpers.DataContext _context;

    public UnitOfWork(DataContext context)
    {
        _context = context;
        AssetRepository = new AssetRepository(_context);
        WarrantyRepository = new WarrantyRepository(_context);
        AssetDescriptionRepository = new AssetDescriptionRepository(_context);
        AssetImageRepository = new AssetImageRepository(_context);
    }

    public IAssetRepository AssetRepository { get; private set; }
    public IWarrantyRepository WarrantyRepository { get; private set; }
    public IAssetDescriptionRepository AssetDescriptionRepository { get; private set; }
    public IAssetImageRepository AssetImageRepository { get; private set; }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}