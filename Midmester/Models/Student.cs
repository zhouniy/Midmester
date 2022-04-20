using System.ComponentModel.DataAnnotations;

namespace Midmester.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string? Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        public string? phone { get; set; }
        public string? Temp { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }
}
