using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class Reportz
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Statue of report")]
        public int StatuezId { get; set; }
        public Statuez Statuez { get; set; }
        [ScaffoldColumn(false)]
        public String UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Subject")]
        public string Topicz { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Textz { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        

    }
}
