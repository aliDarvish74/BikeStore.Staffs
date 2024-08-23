using BikeStore.Staffs.Services.Staffs.Commands;
using BikeStore.Staffs.Services.Staffs.Results;

namespace BikeStore.Staffs.Services.Staffs;

public interface IStaffService : IGenericService<StaffResult,AddStaffCommand>
{
    List<StaffResult> GetStaffByManagerId(int managerId);
}
