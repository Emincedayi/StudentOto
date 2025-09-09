
using StudentOto.Application.Contracts.Services;
using StudentOto.Domain.Entities;
using StudentOto.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StudentOto.Application.Services
{
    public class CourseAppService : ApplicationService, ICourseAppService
    {
        private readonly IRepository<Course, Guid> _courseRepository;

        public CourseAppService(IRepository<Course, Guid> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<CourseDto> CreateAsync(CourseDto input)
        {
            var course = new Course
            {
                Title = input.Title,
                TeacherId = input.TeacherId
            };

            await _courseRepository.InsertAsync(course);
            return ObjectMapper.Map<Course, CourseDto>(course);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _courseRepository.DeleteAsync(id);
        }

        public async Task<CourseDto> GetAsync(Guid id)
        {
            var course = await _courseRepository.GetAsync(id);
            return ObjectMapper.Map<Course, CourseDto>(course);
        }

        public async Task<List<CourseDto>> GetListAsync()
        {
            var list = await _courseRepository.GetListAsync();
            return ObjectMapper.Map<List<Course>, List<CourseDto>>(list);
        }

        public async Task<CourseDto> UpdateAsync(Guid id, CourseDto input)
        {
            var course = await _courseRepository.GetAsync(id);
            course.Title = input.Title;
            course.TeacherId = input.TeacherId;

            await _courseRepository.UpdateAsync(course);
            return ObjectMapper.Map<Course, CourseDto>(course);
        }
    }
}
