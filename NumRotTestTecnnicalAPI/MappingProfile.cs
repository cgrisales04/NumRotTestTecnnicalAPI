using AutoMapper;
using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects;

namespace NumRotTestTecnnicalAPI {
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<InfoUsers, InfoUserDto>();
            CreateMap<Genders, InfoUserDto>();
            CreateMap<TypeUsers, InfoUserDto>();
            CreateMap<InfoUsersForCreationDto, InfoUsers>();
            CreateMap<InvoiceForCreationDto, Invoices>();
        }
    }
}
