using AutoMapper;
using CoreIdentitySample6.DTO;
using CoreIdentitySample6.DAL;

namespace HarrisVotes2022.BLL 
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            // CreateMap<EntityName, DTO.EntityNameDTO>().ReverseMap();
            /*
             * DO NOT CHANGE THE FOLLOWING TEMPLATE CODE. 
             * ProjectBuilder31.ps1 DOES SOME HACKY str.IndexOf() AND str.Substring() 
             * CIRCUS ACROBATICS THAT COULD BREAK IF EXTRA WHITESPACE IS ADDED OR REMOVED.
             *
             * YOU HAVE BEEN WARNED.
             *
             * However, if your project has already been generated, feel free to customize your mappings here.
             *
             */
          
            // {{INSERT AFTER}}
            CreateMap<AspNetUser1, AspNetUserDTO>().ReverseMap();
            CreateMap<AspnetMembership, AspnetMembershipDTO>().ReverseMap();
            // ...

            // In the event your DTOs are modified, consider customizing the mapping process here.
            // This documentation will help: https://docs.automapper.org/en/stable/Projection.html

            // Also consider using the [MapTo(string)] attribute in your Entities class file.
            // See: https://docs.automapper.org/en/stable/Conventions.html#attribute-support
        }
    }
}


























