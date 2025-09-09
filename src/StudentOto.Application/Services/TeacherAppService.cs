
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
    public class TeacherAppService : ApplicationService, ITeacherAppService
    {
        private readonly IRepository<Teacher, Guid> _teacherRepository;

        public TeacherAppService(IRepository<Teacher, Guid> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<TeacherDto> CreateAsync(TeacherDto input)
        {
            var teacher = new Teacher { Name = input.Name, Email = input.Email };
            await _teacherRepository.InsertAsync(teacher);
            return ObjectMapper.Map<Teacher, TeacherDto>(teacher);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _teacherRepository.DeleteAsync(id);
        }

        public async Task<TeacherDto> GetAsync(Guid id)
        {
            var teacher = await _teacherRepository.GetAsync(id);
            return ObjectMapper.Map<Teacher, TeacherDto>(teacher);
        }

        public async Task<List<TeacherDto>> GetListAsync()
        {
            var list = await _teacherRepository.GetListAsync();
            return ObjectMapper.Map<List<Teacher>, List<TeacherDto>>(list);
        }

        public async Task<TeacherDto> UpdateAsync(Guid id, TeacherDto input)
        {
            var teacher = await _teacherRepository.GetAsync(id);
            teacher.Name = input.Name;
            teacher.Email = input.Email;

            await _teacherRepository.UpdateAsync(teacher);
            return ObjectMapper.Map<Teacher, TeacherDto>(teacher);
        }
    }
}
