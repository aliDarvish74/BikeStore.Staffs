using BikeStore.DataAccess;
using BikeStore.Staffs.Models;
using BikeStore.Staffs.Services.Staffs.Commands;
using BikeStore.Staffs.Services.Staffs.Results;
using System.Linq;

namespace BikeStore.Staffs.Services.Staffs;

public class StaffService : IStaffService
{
    private readonly IDataAccess<Staff> _dataAccess;
    public StaffService(IDataAccess<Staff> dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public void AddStaff(AddStaffCommand command)
    {
        var newStaff = new Staff() {
            First_Name = command.First_Name,
            Last_Name = command.Last_Name,
            Active = command.Active,
            Email = command.Email,
            Manager_Id = command.Manager_Id,
            Phone = command.Phone,
            Store_Id = command.Store_Id,
        };
        var query = $"INSERT INTO sales.staffs (first_name, last_name,active,email,manager_id,phone,store_id)" +
            $" VALUES(@first_name, @last_name,@active,@email,@manager_id,@phone,@store_id)";

        _dataAccess.AddOrModifyData(query, newStaff);
    }

    public List<StaffResult> GetAllStaffs()
    {
        var staffs = _dataAccess.GetAll("sales.staffs");
        return staffs.Select(s => s.MapStaffToStaffResult()).ToList();
    }

    public StaffResult? GetStaffById(int id)
    {
        return _dataAccess.Search("sales.staffs", $"staff_id = {id}")?.MapStaffToStaffResult();
    }

    public List<StaffResult> GetStaffByManagerId(int managerId)
    {
        throw new NotImplementedException();
    }
}
