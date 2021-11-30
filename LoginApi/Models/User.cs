using System;
using System.ComponentModel.DataAnnotations;
namespace LoginApi.Models
{
    public class User
    {
        [Key]
        public Guid UId { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UPassword { get; set; } 
    }
}