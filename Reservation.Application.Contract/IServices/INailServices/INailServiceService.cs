using Reservation.Application.Contract.Dtos.NailServices;
using Reservation.Model.Models;

namespace Reservation.Application.Contract.IServices.INailServices
{
    public interface INailServiceService
    {
        void Add(NailServiceAddDto dto);
        int Update(int nailServiceId, NailServiceDto dto);
        List<NailServiceDto> GetAll();
        NailServiceDto GetById(int nailServiceId);
        NailServiceDto GetByName(SearchNailServiceRequestDto dto);
        int Delete(int nailServiceId);
        List<NailServiceDto> GetTop(int take);
        
    }
}
