using AutoMapper;
using SchoolManagar.Data;
using SchoolManagar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Course, CourseVM>().ReverseMap();
            CreateMap<Department, DepartmentVM>().ReverseMap();
            CreateMap<Level, LevelVM>().ReverseMap();
            CreateMap<School, SchoolVM>().ReverseMap();
            CreateMap<User, StudentVM>().ReverseMap();
            
        }
    }
}
