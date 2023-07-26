using WebApi.Entities;

public interface IAssetDescriptionRepository{
    void AddRange(List<OtherDescription> assetDescriptions);
    void UpdateRange(List<OtherDescription> assetDescriptions);
    void Delete(long assetDescriptionId);
}