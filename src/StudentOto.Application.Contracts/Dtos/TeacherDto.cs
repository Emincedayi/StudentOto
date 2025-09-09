using System;
using Volo.Abp.Application.Dtos;

namespace StudentOto.Dtos
{
    public class TeacherDto : EntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
