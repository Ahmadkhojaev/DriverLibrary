using DriverLibrary.Data;
using DriverLibrary.Entities;
using DriverLibrary.Mapper;
using DriverLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace DriverLibrary.Service;

public class DriverService : IDriverService
{
    private readonly ILogger<DriverService> _logger;
    private readonly DriverDbContext _context;

    public DriverService (ILogger<DriverService> logger, DriverDbContext context)
    {
        _logger = logger;
        _context= context;
    }

    public Task<(bool IsSuccess, Exception e)> DeleteDriverIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<DriverModel>> GetAllDriverAsync()
    => await _context.Drivers.Select(a => a.ToModel()).ToListAsync();

    public Task<Driver> GetDriverByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<(bool IsSuccess, Exception e)> InsertDriverAsync(Driver driver)
    {
        try
        {
            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"New Driver successfully added!");
            return (true, null);
        }
        catch (Exception e)
        {
             _logger.LogError($"New Driver was not added!");
             return(false, e);
        }
    }

    public Task<(bool IsSuccess, Exception e)> UpdateDriverAsync(Driver driver)
    {
        throw new NotImplementedException();
    }
}