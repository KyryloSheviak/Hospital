using AutoMapper;
using Hospital.BL.DTO;
using Hospital.DAL.Entities;
using Hospital.WEB.ViewModels;

namespace Hospital.WEB.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<UserDTO, ApplicationUser>();

            CreateMap<UserViewModel, ApplicationUser>()
                .ForMember(x => x.UserName, x => x.MapFrom(x => x.Email));

            CreateMap<UserDTO, UserViewModel>();

            CreateMap<DoctorViewModel, Doctor>();
            CreateMap<DoctorViewModel, ApplicationUser>()
                .ForMember(x => x.Fio, x => x.MapFrom(x => x.UserViewModel.Fio))
                .ForMember(x => x.UserName, x => x.MapFrom(x => x.UserViewModel.Email))
                .ForMember(x => x.Email, x => x.MapFrom(x => x.UserViewModel.Email))
                .ForMember(x => x.PasswordHash, x => x.MapFrom(x => x.UserViewModel.Password))
                .ForMember(x => x.Doctor, x => x.MapFrom(x => x));

            CreateMap<Doctor, DoctorDTO>()
                .ForMember(x => x.UserDTO, x => x.MapFrom(x => x.ApplicationUser));
        }
    }
}