using WebApi.Entities;

public interface IAssetImageRepository{
    void AddRange(List<Image> assetImages);
    void UpdateRange(List<Image> assetImages);
    void Delete(long assetImageId);
}