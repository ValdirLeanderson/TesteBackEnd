using TesteBackEnd.Domain.Enums;
namespace TesteBackEnd.Domain.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string Name { get; set; }
        public string AcademicRecord { get; set; }
        public string Period { get; set; }
        public CourseEntity Course { get; set; }
        public Guid CourseId { get; set; }
        public Status Status { get; set; }
        public string Photo { get; set; }
        
    }
}