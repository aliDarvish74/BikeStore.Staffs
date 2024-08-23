using BikeStore.Staffs.Models;

namespace BikeStore.Staffs.Services.Staffs.Results;

public class StaffResult
{
    public StaffResult(Staff staff)
    {
        Staff_Id = staff.Staff_Id;
        First_Name = staff.First_Name;
        Last_Name = staff.Last_Name;
        Email = staff.Email;
        Phone = staff.Phone;
        Store_Id = staff.Store_Id;
        Manager_Id = staff.Manager_Id;
    }
    public int Staff_Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Store_Id { get; set; }
    public int Manager_Id { get; set; }
}
public static class StaffMappers
{
    public static StaffResult MapStaffToStaffResult(this Staff staff)
    {
        return new StaffResult(staff);
    }
}