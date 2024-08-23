using BikeStore.Staffs.Services.Customer.Commands;
using BikeStore.Staffs.Services.Customer.Results;

namespace BikeStore.Staffs.Services.Customer
{
    public interface ICustomerService : IGenericService<CustomerResult,AddCustomerCommand>
    {
    }
}
