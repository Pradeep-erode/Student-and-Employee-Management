﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Studentmanagement.Entities
{
    public partial class DepartmentDetail
    {
        [Key]
        [Column("Department_Id")]
        public int DepartmentId { get; set; }
        [Required]
        [Column("Department_Name")]
        [StringLength(5)]
        public string DepartmentName { get; set; }
    }
}