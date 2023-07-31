using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Reservation.Application.Contract.Commons;
using Reservation.Application.Contract.Dtos.NailServices;
using Reservation.Application.Contract.IServices.INailServices;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Application.Services.NailServices
{
    public class NailServiceService : INailServiceService
    {
        private readonly INailServiceRepository repository;
        private readonly IMapper mapper;
        private readonly string imagePath;

        public NailServiceService(INailServiceRepository repository, IMapper mapper, IOptions<ImagePathProvider> options)
        {
            this.repository = repository;
            this.mapper = mapper;
            imagePath = options.Value.ImagePath;
        }

        public void Add(NailServiceAddDto dto)
        {
            SaveFile(dto.Image);
        }

        public int Delete(int nailServiceId)
        {
            return repository.Delete(nailServiceId);
        }

        public List<NailServiceDto> GetAll()
        {
            var nailServices = repository.GetAll().ToList();
            var mapped = mapper.Map<List<NailServiceDto>>(nailServices);
            return mapped;
        }

        public NailServiceDto GetById(int nailServiceId)
        {
            var nailService = repository.GetById(nailServiceId);
            return mapper.Map<NailServiceDto>(nailService);
        }

        public NailServiceDto GetByName(SearchNailServiceRequestDto dto)
        {
            var nailService = repository.SearchByName(dto.ServiceName);
            return mapper.Map<NailServiceDto>(nailService);
        }

        public List<NailServiceDto> GetTop(int take)
        {
            var nailServices = repository.GetAll().Take(take).ToList();
            var mapped = mapper.Map<List<NailServiceDto>>(nailServices);
            return mapped;
        }

        public int Update(int nailServicesId, NailServiceDto dto)
        {
            var nail = mapper.Map<NailService>(dto);
            return repository.Update(nailServicesId, nail);

        }

        private void SaveFile(IFormFile file)
        {
            using var stream = file.OpenReadStream();
            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);

            File.WriteAllBytes($"{imagePath}{file.FileName}", memoryStream.ToArray());
        }
    }
}
