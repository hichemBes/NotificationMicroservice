using AutoMapper;
using Domain.Dtos;

namespace Notification.Mapper
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<Domain.Model.Notification, NotificationDto>().ReverseMap();

        }
    }
}
