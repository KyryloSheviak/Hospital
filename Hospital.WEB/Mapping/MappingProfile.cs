using AutoMapper;
using Hospital.BL.DTO;
using Hospital.DAL.Entities;
using Hospital.WEB.Models;
using Hospital.WEB.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.WEB.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ApplicationUser, AboutUserDTO>();
            CreateMap<AboutUserDTO, AboutUserViewModel>();

            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<UserDTO, ApplicationUser>();

            CreateMap<UserViewModel, ApplicationUser>()
                .ForMember(x => x.Sex, x => x.MapFrom(x => x.Sex.ToString()))
                .ForMember(x => x.UserName, x => x.MapFrom(x => x.Email));

            CreateMap<UserDTO, UserViewModel>();

            CreateMap<DoctorViewModel, Doctor>();
            CreateMap<DoctorViewModel, ApplicationUser>()
                .ForMember(x => x.Sex, x => x.MapFrom(x => x.UserViewModel.Sex.ToString()))
                .ForMember(x => x.Fio, x => x.MapFrom(x => x.UserViewModel.Fio))
                .ForMember(x => x.UserName, x => x.MapFrom(x => x.UserViewModel.Email))
                .ForMember(x => x.Email, x => x.MapFrom(x => x.UserViewModel.Email))
                .ForMember(x => x.PasswordHash, x => x.MapFrom(x => x.UserViewModel.Password))
                .ForMember(x => x.Doctor, x => x.MapFrom(x => x));

            CreateMap<Doctor, DoctorDTO>()
                .ForMember(x => x.UserDTO, x => x.MapFrom(x => x.ApplicationUser));

            CreateMap<RegisterViewModel, ApplicationUser>()
               .ForMember(x => x.UserName, x => x.MapFrom(x => x.Email))
               .ForMember(x => x.Sex, x => x.MapFrom(x => x.Sex.ToString()));

            CreateMap<Doctor, ReceptionDoctorDTO>()
               .ForMember(x => x.Fio, x => x.MapFrom(x => x.ApplicationUser.Fio));

            CreateMap<ReceptionViewModel, ReceptionWorkDayDTO>()
               .ForMember(x => x.ReceptionTime, x => x.MapFrom(x => new DateTime(x.WorkDay.Year, x.WorkDay.Month, x.WorkDay.Day, x.Time.Hour, x.Time.Minute, x.Time.Second)));
            //CreateMap<WorkDay, DateTime>()
            //    .ConvertUsing(x => x.ReceptionTime);


        }
    }
}