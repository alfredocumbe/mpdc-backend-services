namespace WebApi.Entities;

using System.Text.Json.Serialization;
public class Warranty
{
    public int Id  { get; set; }
    public string Dealer { get; set; }
    public int SerialNumber { get; set; }
    public DateTime DateOfPurchasing { get; set; }
    public DateTime ExiparationDate { get; set; }
    public double CostOfPurchasing { get; set; }
    public double CurrentValue { get; set; }
    [JsonIgnore]
    public virtual  Asset asset { get; set; }
}