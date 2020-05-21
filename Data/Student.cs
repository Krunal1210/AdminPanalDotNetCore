using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNC6.Data
{
    [Table("Student", Schema = "dbo")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

    }
}