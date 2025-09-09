using System;
using Volo.Abp.Application.Dtos;

namespace StudentOto.Dtos
{
    public class AttendanceDto : EntityDto<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public bool IsPresent { get; set; }
    }
}
