using StudentOto.Domain.Entities;
using System;
using Volo.Abp.Domain.Entities;

namespace StudentOto.Domain.Entities
{
    public class Enrollment : AggregateRoot<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int? Grade { get; set; }
        public int Absences { get; set; }

        public  Student Student { get; set; }
        public  Course Course { get; set; }
    }
}
