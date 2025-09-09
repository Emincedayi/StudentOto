
using StudentOto.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentOto.Application.Contracts.Services
{
    public interface ICourseAppService
    {
        Task<List<CourseDto>> GetListAsync();
        Task<CourseDto> GetAsync(Guid id);
        Task<CourseDto> CreateAsync(CourseDto input);
        Task<CourseDto> UpdateAsync(Guid id, CourseDto input);
        Task DeleteAsync(Guid id);
    }
}
