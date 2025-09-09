
using StudentOto.Application.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentOto.Application.Contracts.Services
{
    public interface IEnrollmentAppService
    {
        Task<List<EnrollmentDto>> GetListAsync();
        Task<EnrollmentDto> GetAsync(Guid id);
        Task<EnrollmentDto> UpdateAsync(Guid id, EnrollmentDto input);
    }
}
