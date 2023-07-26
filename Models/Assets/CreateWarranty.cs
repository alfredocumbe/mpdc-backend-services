namespace WebApi.Models.Assets;

using System.Text.Json.Serialization;

public class CreateWarranty
{
    public string Dealer { get; set; }
    public int SerialNumber { get; set; }
    public DateTime DateOfPurchasing { get; set; }
    public float CostOfPurchasing { get; set; }
    public float CurrentValue { get; set; }
    public DateTime ExiparationDate { get; set; }
}