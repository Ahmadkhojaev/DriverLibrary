using DriverLibrary.Entities;
using DriverLibrary.Model;

namespace DriverLibrary.Mapper;

public static class NewBaseType
{
    public static Driver ToEntity (this DriverModel model)
    => new Driver()
    {
        Id = Guid.NewGuid(),
        Username = model.Username,
        LastName = model.LastName,
        FirstName = model.LastName
    };

    public static DriverModel ToModel (this Driver driver)
    => new DriverModel()
    {
        Username = driver.Username,
        LastName = driver.LastName,
        FirstName = driver.FirstName
    };
}