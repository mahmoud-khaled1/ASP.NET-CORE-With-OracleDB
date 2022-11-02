using System;
using System.Collections.Generic;

namespace CoreCRUDWithOracle.Models
{
    public partial class Student
    {
        public decimal Id { get; set; }
        public string Fullname { get; set; } = null!;
        public string? Email { get; set; }
        public decimal DepartmentId { get; set; }
    }
}
