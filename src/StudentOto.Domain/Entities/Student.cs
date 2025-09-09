using StudentOto.Domain.Entities;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace StudentOto.Domain.Entities
{
    public class Student : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
