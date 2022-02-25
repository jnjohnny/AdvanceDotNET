using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practice17._02._22.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Id { get; set; }

        [Required]
        public string Dob { get; set; }
        [Required]
        public string Email { get; set; }
        

    }
}