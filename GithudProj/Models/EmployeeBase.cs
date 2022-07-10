using System.ComponentModel.DataAnnotations;

namespace GithudProj.Models
{
    public class EmployeeBase
    {
        [Key]
        public int EmpId { get; set; }
    }
}