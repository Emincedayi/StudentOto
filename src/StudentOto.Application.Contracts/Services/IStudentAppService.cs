
using StudentOto.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace StudentOto.Application.Contracts
{
    public interface IStudentAppService : IApplicationService
    {
        Task<List<StudentDto>> GetListAsync();
        Task<StudentDto> GetAsync(Guid id);
        Task<StudentDto> CreateAsync(StudentDto input);
        Task<StudentDto> UpdateAsync(Guid id, StudentDto input);
        Task DeleteAsync(Guid id);
    }
}
