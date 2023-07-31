using AutoMapper;
using Reservation.Application.Contract.Dtos.Personnels;
using Reservation.Application.Contract.IServices.IPersonnels;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Application.Services.Personnels
{
    public class PersonnelService : IPersonnelService
    {
        private readonly IPersonnelRepository repository;
        private readonly IMapper mapper;

        public PersonnelService(IPersonnelRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void Add(PersonnelAddDto dto)
        {
            var personnel = mapper.Map<Personnel>(dto);
            repository.Add(personnel);
        }

        public int Delete(int parsonnelId)
        {
            return repository.Delete(parsonnelId);
        }

        public List<PersonnelDto> GetAll()
        {
            var personnels = repository.GetAll().ToList();
            return mapper.Map<List<PersonnelDto>>(personnels);
        }

        public PersonnelDto GetById(int personnelId)
        {
            var personnel = repository.GetById(personnelId);
            return mapper.Map<PersonnelDto>(personnel);
        }

        public int Update(int personnelId, PersonnelDto dto)
        {
            var personnel = mapper.Map<Personnel>(dto);
            return repository.Update(personnelId, personnel);
        }
    }
}
