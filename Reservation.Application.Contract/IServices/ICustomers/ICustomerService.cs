using Reservation.Application.Contract.Dtos.Customers;

namespace Reservation.Application.Contract.IServices.ICustomers
{
    public interface ICustomerService
    {
        void Add(CustomerAddDto dto);
        int Update(int customerId, CustomerDto dto);
        List<CustomerDto> GetAll();
        CustomerDto GetById(int id);
        int Delete(int customerId);
    }
}
