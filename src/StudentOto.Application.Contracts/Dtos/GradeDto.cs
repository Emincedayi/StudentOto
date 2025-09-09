using System;
using Volo.Abp.Application.Dtos;

namespace StudentOto.Dtos
{
    public class GradeDto : EntityDto<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int Score { get; set; }
    }
}
