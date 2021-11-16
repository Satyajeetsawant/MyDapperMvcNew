using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDapperMvc.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        public string Address { get; set; }
        
    }
}