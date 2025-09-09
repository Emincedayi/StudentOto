

using StudentOto.Application.Contracts.DTOs;
using StudentOto.Application.Contracts.Services;
using StudentOto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StudentOto.Application.Services
{
    public class EnrollmentAppService : ApplicationService, IEnrollmentAppService
    {
        private readonly IRepository<Enrollment, Guid> _enrollmentRepository;

        public EnrollmentAppService(IRepository<Enrollment, Guid> enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<List<EnrollmentDto>> GetListAsync()
        {
            var enrollments = await _enrollmentRepository.GetListAsync(); // EF Core Include yok

            var dtoList = new List<EnrollmentDto>();

            foreach (var e in enrollments)
            {
                // Öğrenci ve dersi ayrı repository’den çek
                var student = await LazyGetStudent(e.StudentId);
                var course = await LazyGetCourse(e.CourseId);

                dtoList.Add(new EnrollmentDto
                {
                    Id = e.Id,
                    StudentId = e.StudentId,
                    StudentName = student?.Name,
                    CourseId = e.CourseId,
                    CourseTitle = course?.Title,
                    Grade = e.Grade,
                    Absences = e.Absences
                });
            }

            return dtoList;
        }
        private async Task<Student> LazyGetStudent(Guid id)
    => await LazyServiceProvider.LazyGetRequiredService<IRepository<Student, Guid>>().GetAsync(id);

        private async Task<Course> LazyGetCourse(Guid id)
            => await LazyServiceProvider.LazyGetRequiredService<IRepository<Course, Guid>>().GetAsync(id);


        public async Task<EnrollmentDto> GetAsync(Guid id)
        {
            var e = await _enrollmentRepository.GetAsync(id);
            return ObjectMapper.Map<Enrollment, EnrollmentDto>(e);
        }

        public async Task<EnrollmentDto> UpdateAsync(Guid id, EnrollmentDto input)
        {
            var e = await _enrollmentRepository.GetAsync(id);
            e.Grade = (int?)input.Grade;
            e.Absences = input.Absences;
            await _enrollmentRepository.UpdateAsync(e);
            return ObjectMapper.Map<Enrollment, EnrollmentDto>(e);
        }
    }
}
