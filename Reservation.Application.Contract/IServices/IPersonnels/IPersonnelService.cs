using Reservation.Application.Contract.Dtos.Personnels;

namespace Reservation.Application.Contract.IServices.IPersonnels
{
    public interface IPersonnelService
    {
        void Add(PersonnelAddDto dto);
        int Update(int personnelId , PersonnelDto dto);
        List<PersonnelDto> GetAll();
        PersonnelDto GetById(int id);
        int Delete(int personnelId);
    }
}
