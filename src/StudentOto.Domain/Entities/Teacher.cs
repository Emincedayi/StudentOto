using StudentOto.Domain.Entities;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace StudentOto.Domain.Entities
{
    public class Teacher : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation
        public virtual ICollection<Course> Courses { get; set; }
    }
}
