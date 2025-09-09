using System;
using Volo.Abp.Application.Dtos;

namespace StudentOto.Dtos
{
    public class CourseDto : EntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}
