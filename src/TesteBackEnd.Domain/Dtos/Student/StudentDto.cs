using TesteBackEnd.Domain.Enums;

namespace TesteBackEnd.Domain.Dtos.Student
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string AcademicRecord { get; set; }
        public string Period { get; set; }
        public Guid CourseId { get; set; }
        public Status Status { get; set; }
        public string Photo { get; set; }
    }
}