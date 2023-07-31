using Reservation.Application.Contract.Dtos.DesignNails;

namespace Reservation.Application.Contract.IServices.IDesignNails
{
    public interface IDesignNailService
    {
        void Add(DesignNailAddDto dto);
        int Update(int designNailId, DesignNailDto dto);
        List<DesignNailDto> GetAll();
        DesignNailDto GetById(int designNailId);
        int Delete(int designNailId);
    }
}
