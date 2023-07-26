namespace WebApi.Repositories;

public interface IUnitOfWork
{
    IAssetRepository AssetRepository { get; }
    IWarrantyRepository WarrantyRepository {get;}
    IAssetDescriptionRepository AssetDescriptionRepository {get;}
    IAssetImageRepository AssetImageRepository {get;}
    void SaveChanges();
}