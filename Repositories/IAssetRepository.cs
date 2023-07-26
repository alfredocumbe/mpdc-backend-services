namespace WebApi.Repositories;

using WebApi.Entities;

public interface IAssetRepository{
    void Add(Asset asset);
    void Update(Asset asset);
    void Delete(long assetId);
    IEnumerable<Asset> GetAll();
    Asset GetById(int id);
}