﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Studentmanagement.Entities
{
    public partial class Studentmark
    {
        [Key]
        public int StudentId { get; set; }
        public int Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int? Total { get; set; }
        [Column("Created_Time_stamp", TypeName = "datetime")]
        public DateTime CreatedTimeStamp { get; set; }
        [Column("Updated_Time_stamp", TypeName = "datetime")]
        public DateTime UpdatedTimeStamp { get; set; }
        [Column("Is_deleted")]
        public bool IsDeleted { get; set; }
    }
}