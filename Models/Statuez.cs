using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Statuez
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        public String Name { get; set; }
        public String description { get; set; }
    }
}
