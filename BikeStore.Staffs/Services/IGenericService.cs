namespace BikeStore.Staffs.Services;

public interface IGenericService<TResult,TCommand>
{
    List<TResult> GetAllStaffs();
    TResult GetStaffById(int id);
    void AddStaff(TCommand command);
}
