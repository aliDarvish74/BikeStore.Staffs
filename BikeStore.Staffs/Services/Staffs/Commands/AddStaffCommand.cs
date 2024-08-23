using BikeStore.Staffs.Controllers.Models.Requests;

namespace BikeStore.Staffs.Services.Staffs.Commands;

public class AddStaffCommand
{
    public AddStaffCommand(AddStaffRequest request)
    {
        First_Name = request.FirstName;
        Last_Name = request.LastName;
        Email = request.Email;
        Phone = request.Phone;
        Active = request.Active ?? true;
        Store_Id = request.StoreId;
        Manager_Id = request.ManagerId;
    }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool Active { get; set; }
    public int Store_Id { get; set; }
    public int Manager_Id { get; set; }
}


