﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUDapp.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [Display(Name="Employee Name")]
        [MaxLength(50)]
        [MinLength(2)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Mobile { get; set; }

        [Required]
        //[MaxLength(40)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        //[MaxLength(40)]
        public string? City { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public double Salary { get; set; }
        
        
    }
}
