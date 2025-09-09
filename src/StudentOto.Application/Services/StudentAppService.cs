
using StudentOto.Application.Contracts;
using StudentOto.Application.Contracts.Dtos;
using StudentOto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StudentOto.Application.Services
{
    public class StudentAppService : ApplicationService, IStudentAppService
    {
        private readonly IRepository<Student, Guid> _studentRepository;

        public StudentAppService(IRepository<Student, Guid> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDto>> GetListAsync()
        {
            var students = await _studentRepository.GetListAsync();
            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                Name = s.Name,
                Email = s.Email,
                DateOfBirth = s.DateOfBirth
            }).ToList();
        }

        public async Task<StudentDto> GetAsync(Guid id)
        {
            var student = await _studentRepository.GetAsync(id);
            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                DateOfBirth = student.DateOfBirth
            };
        }

        public async Task<StudentDto> CreateAsync(StudentDto input)
        {
            var student = await _studentRepository.InsertAsync(new Student
            {
                Name = input.Name,
                Email = input.Email,
                DateOfBirth = input.DateOfBirth
            });
            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                DateOfBirth = student.DateOfBirth
            };
        }

        public async Task<StudentDto> UpdateAsync(Guid id, StudentDto input)
        {
            var student = await _studentRepository.GetAsync(id);
            student.Name = input.Name;
            student.Email = input.Email;
            student.DateOfBirth = input.DateOfBirth;
            await _studentRepository.UpdateAsync(student);
            return input;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _studentRepository.DeleteAsync(id);
        }
    }
}
