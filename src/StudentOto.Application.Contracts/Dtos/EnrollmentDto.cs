using System;

namespace StudentOto.Application.Contracts.DTOs
{
    public class EnrollmentDto
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public Guid CourseId { get; set; }
        public string CourseTitle { get; set; }
        public decimal? Grade { get; set; }
        public int Absences { get; set; }
    }
}
