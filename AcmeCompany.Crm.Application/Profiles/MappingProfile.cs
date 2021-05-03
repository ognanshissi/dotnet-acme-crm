using AcmeCompany.Crm.Application.Features.Clients.Queries.GetClients;
using AcmeCompany.Crm.Domain.Entities;
using AutoMapper;

namespace AcmeCompany.Crm.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<Client, GetClientVm>().ReverseMap();

        }
    }
}