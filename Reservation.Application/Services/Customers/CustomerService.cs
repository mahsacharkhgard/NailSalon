using AutoMapper;
using Reservation.Application.Contract.Dtos.Customers;
using Reservation.Application.Contract.IServices.ICustomers;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Application.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;
        private readonly IMapper mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void Add(CustomerAddDto dto)
        {
            var customer = mapper.Map<Customer>(dto);
            repository.Add(customer);
        }

        public int Delete(int customerId)
        {
            return repository.Delete(customerId);
        }

        public List<CustomerDto> GetAll()
        {
            var customers = repository.GetAll().ToList();
            return mapper.Map<List<CustomerDto>>(customers);
        }

        public CustomerDto GetById(int customerId)
        {
            var customer = repository.GetById(customerId);
            return mapper.Map<CustomerDto>(customer);
        }

        public int Update(int customerId, CustomerDto dto)
        {
            var customer = mapper.Map<Customer>(dto);
            return repository.Update(customerId,customer);
        }
    }
}
