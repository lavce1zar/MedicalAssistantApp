using AutoMapper;
using MedicalAssiastant.Core.DataTransferObjects;
using MedicalAssistant.DataBase.Entities;
using MedicalAssistant.MvcApp.Models;

namespace MedicalAssistant.MvcApp.MappingProfiles
{
    public class VaccinationProfile : Profile
    {
        public VaccinationProfile()
        {
            CreateMap<Vaccination, VaccinationDto>();
            CreateMap<VaccinationDto, Vaccination>();

            CreateMap<VaccinationModel, VaccinationDto>();
            CreateMap<VaccinationDto, VaccinationModel>();
        }
    }
}
