using StudentOto.Domain.Entities;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace StudentOto.Domain.Entities
{
    public class Course : AggregateRoot<Guid>
    {
        public string Title { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
