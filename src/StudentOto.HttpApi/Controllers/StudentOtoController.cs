using Microsoft.AspNetCore.Mvc;

using StudentOto.Application.Contracts;
using StudentOto.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentOto.HttpApi.Controllers
{
    [Route("api/students")]
    public class StudentController : AbpControllerBase
    {
        private readonly IStudentAppService _studentAppService;

        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        [HttpGet]
        public Task<List<StudentDto>> GetList() => _studentAppService.GetListAsync();

        [HttpGet("{id}")]
        public Task<StudentDto> Get(Guid id) => _studentAppService.GetAsync(id);

        [HttpPost]
        public Task<StudentDto> Create(StudentDto input) => _studentAppService.CreateAsync(input);

        [HttpPut("{id}")]
        public Task<StudentDto> Update(Guid id, StudentDto input) => _studentAppService.UpdateAsync(id, input);

        [HttpDelete("{id}")]
        public Task Delete(Guid id) => _studentAppService.DeleteAsync(id);
    }
}




















/*using StudentOto.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentOto.Controllers;

// Inherit your controllers from this class.
 
public abstract class StudentOtoController : AbpControllerBase
{
    protected StudentOtoController()
    {
        LocalizationResource = typeof(StudentOtoResource);
    }
}
*/
