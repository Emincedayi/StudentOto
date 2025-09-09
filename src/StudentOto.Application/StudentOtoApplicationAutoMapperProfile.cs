using AutoMapper;
using StudentOto.Application.Contracts.Dtos;
using StudentOto.Application.Contracts.DTOs;
using StudentOto.Domain.Entities;
using StudentOto.Dtos;

namespace StudentOto;

public class StudentOtoApplicationAutoMapperProfile : Profile
{
    public StudentOtoApplicationAutoMapperProfile()
    {
        CreateMap<Teacher, TeacherDto>();
        CreateMap<TeacherDto, Teacher>();

        CreateMap<Student, StudentDto>();
        CreateMap<StudentDto, Student>();

        CreateMap<Course, CourseDto>();
        CreateMap<CourseDto, Course>();

        CreateMap<Enrollment, EnrollmentDto>();
        CreateMap<EnrollmentDto, Enrollment>(); /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
