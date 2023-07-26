namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models.Assets;
using WebApi.Repositories;

[ApiController]
[Route("api/v1/[controller]")]
public class AssetsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public AssetsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_unitOfWork.AssetRepository.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
       return Ok(_unitOfWork.AssetRepository.GetById(id));
    }

    [HttpPost]
    public IActionResult Create(CreateAssetRequest createAssetRequest)
    {

        Asset asset = new Asset();
        asset.Capacity = createAssetRequest.createAsset.Capacity;
        asset.Category = createAssetRequest.createAsset.Category;
        asset.Description = createAssetRequest.createAsset.Description;
        asset.Location = createAssetRequest.createAsset.Location;
        asset.MaintenanceStatus = createAssetRequest.createAsset.MaintenanceStatus;
        asset.UsageStatus = createAssetRequest.createAsset.UsageStatus;
        asset.Manufacture = createAssetRequest.createAsset.Manufacture;
        asset.Model = createAssetRequest.createAsset.Model;
        asset.Name = createAssetRequest.createAsset.Name;
        _unitOfWork.AssetRepository.Add(asset);

        List<Image> images = new List<Image>();
        foreach (CreateImage item in createAssetRequest.createImages)
        {
            if (item != null)
            {
                Image assetImage = new Image();
                assetImage.FileLocation = item.FileLocation;
                assetImage.FileName = item.FileName;
                assetImage.Url = item.Url;
                assetImage.asset = asset;
                images.Add(assetImage);
            }
        }
        _unitOfWork.AssetImageRepository.AddRange(images);


        List<OtherDescription> descriptions = new List<OtherDescription>();
        foreach (CreateDescription item in createAssetRequest.createDescriptions)
        {
            if (item != null)
            {
                OtherDescription assetDescription = new OtherDescription();
                assetDescription.Description = item.Description;
                assetDescription.asset = asset;
                descriptions.Add(assetDescription);
            }

        }
        _unitOfWork.AssetDescriptionRepository.AddRange(descriptions);


        Warranty warranty = new Warranty();
        if (createAssetRequest.createWarranty != null)
        {
            warranty.CostOfPurchasing = createAssetRequest.createWarranty.CostOfPurchasing;
            warranty.CurrentValue = createAssetRequest.createWarranty.CurrentValue;
            warranty.DateOfPurchasing = createAssetRequest.createWarranty.DateOfPurchasing;
            warranty.Dealer = createAssetRequest.createWarranty.Dealer;
            warranty.ExiparationDate = createAssetRequest.createWarranty.ExiparationDate;
            warranty.SerialNumber = createAssetRequest.createWarranty.SerialNumber;
            warranty.asset = asset;
            _unitOfWork.WarrantyRepository.Add(warranty);
        }

        _unitOfWork.SaveChanges();

        CreateAssetResponse response = new CreateAssetResponse();
        response.asset = asset;
        response.assetDescriptions = descriptions;
        response.assetImages = images;
        response.warranty = warranty;

        return Ok(response);
    }

}