using System;
using System.ComponentModel.DataAnnotations;

namespace GithudProj.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EName { get; set; }
        public string EDesign { get; set; }
        public DateTime EDoj { get; set; }
    }
}
