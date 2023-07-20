using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.EmployeeVMs;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ProjectVMs;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ServiceVMs;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.ViewModel;

namespace AVRO_CONSTRUKTİON_MMC.Profiles
{
    public class AdminMapper :Profile
    {
        public AdminMapper()
        {
            // Slider
            CreateMap<Slider, SliderPutVM>();

            // Contact Us
            CreateMap<ContactPostViewModel, ContactMessage>();

            // Employee
            CreateMap<EmployeePostVM, Employee>();
            CreateMap<EmployeePutVM, Employee>().ReverseMap();

            // Project
            CreateMap<ProjectPostVM, Project>();
            CreateMap<Project, ProjectPutVM>();

            // Service 
            CreateMap<ServicePostVM, Service>();
            CreateMap<ServicePutVM, Service>().ReverseMap();


        }
    }
}
