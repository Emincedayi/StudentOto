// File: src/MySchool.Domain/Entities/Attendance.cs
using StudentOto.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentOto.Domain.Entities
{
    public class Attendance
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid CourseId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public bool IsPresent { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }
    }
}
