namespace WebApi.Repositories;

using WebApi.Entities;
using WebApi.Helpers;

public class WarrantyRepository : IWarrantyRepository{

    private readonly DataContext _context;

    public WarrantyRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(Warranty warranty)
    {
        _context.Warranties.Add(warranty);
    }

    public void Update(Warranty warranty)
    {
        _context.Warranties.Update(warranty);
    }

    public void Delete(long warrantyId)
    {
        var warranty = _context.Warranties.Find(warrantyId);
        if (warranty != null)
            _context.Warranties.Remove(warranty);
    }
}