using DriverLibrary.Entities;
using DriverLibrary.Model;

namespace DriverLibrary.Service;

public interface IDriverService
{
    Task<Driver> GetDriverByIdAsync(Guid id);
    Task<List<DriverModel>> GetAllDriverAsync();
    Task<(bool IsSuccess, Exception e)> InsertDriverAsync(Driver driver);
    Task<(bool IsSuccess, Exception e)> UpdateDriverAsync(Driver driver);
    Task<(bool IsSuccess, Exception e)> DeleteDriverIdAsync(Guid id);
}