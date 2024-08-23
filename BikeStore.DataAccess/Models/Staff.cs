namespace BikeStore.Staffs.Models;

public class Staff
{
    public int Staff_Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool Active { get; set; }
    public int Store_Id { get; set; }
    public int Manager_Id { get; set; }
}
