namespace BikeStore.Staffs.Controllers.Models.Requests;

public class AddStaffRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool? Active { get; set; }
    public int StoreId { get; set; }
    public int ManagerId { get; set; }
}
