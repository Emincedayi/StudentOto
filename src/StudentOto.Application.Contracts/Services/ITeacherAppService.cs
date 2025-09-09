
using StudentOto.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentOto.Application.Contracts.Services
{
    public interface ITeacherAppService
    {
        Task<List<TeacherDto>> GetListAsync();
        Task<TeacherDto> GetAsync(Guid id);
        Task<TeacherDto> CreateAsync(TeacherDto input);
        Task<TeacherDto> UpdateAsync(Guid id, TeacherDto input);
        Task DeleteAsync(Guid id);
    }
}
