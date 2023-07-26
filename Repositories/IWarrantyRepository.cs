namespace WebApi.Repositories;

using WebApi.Entities;

public interface IWarrantyRepository{
    void Add(Warranty warranty);
    void Update(Warranty warranty);
    void Delete(long warrantyId);
}