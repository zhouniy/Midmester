using System.ComponentModel.DataAnnotations;

namespace Midmester.Models
{
    public class Student
    {
        [Display(Name = "姓名")]
        [StringLength(300)]
        public string? Name { get; set; }

        [Display(Name = "性别")]
        [StringLength(1)]
        public string? Sex { get; set; }

        [Display(Name = "年龄")]
        [Range(0, 200)]
        public string? Age { get; set; }

        [Display(Name = "出生日期")]
        public DateTime Birth { get; set; }

        [Display(Name = "手机")]
        [StringLength(13)]
        public string? Phone { get; set; }

        [Display(Name = "体温")]
        [Range(30, 50)]
        public decimal Temperature { get; set; }

        [Display(Name = "填表日期")]
        public DateTime Date { get; set; }
    }
}
