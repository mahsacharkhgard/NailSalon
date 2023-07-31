using AutoMapper;
using Reservation.Application.Contract.Dtos.DesignNails;
using Reservation.Application.Contract.IServices.IDesignNails;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Application.Services.DesignNails
{
    public class DesignNailService : IDesignNailService
    {
        private readonly IDesignNailRepository repository;
        private readonly IMapper mapper;

        public DesignNailService(IDesignNailRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void Add(DesignNailAddDto dto)
        {
            var designNail = mapper.Map<DesignNail>(dto);
            repository.Add(designNail);
        }

        public int Delete(int designNailId)
        {
            return repository.Delete(designNailId);
        }

        public List<DesignNailDto> GetAll()
        {
            var designNails = repository.GetAll().ToList();
            return mapper.Map<List<DesignNailDto>>(designNails);
        }

        public DesignNailDto GetById(int designNailId)
        {
            var designNail = repository.GetById(designNailId);
            return mapper.Map<DesignNailDto>(designNail);
        }

        public int Update(int designNailId, DesignNailDto dto)
        {
            var design = mapper.Map<DesignNail>(dto);
            return repository.Update(designNailId, design);
        }
    }
}
