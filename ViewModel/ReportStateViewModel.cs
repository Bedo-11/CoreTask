using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModel
{
    public class ReportStateViewModel
    {
        public int ReportId { get; set; }
        public String Topicz { get; set; }
        public String Textz { get; set; }
        public IFormFile ImageUz { get; set; }
        public List<Statuez> Statuezs { get; set; }
    }
}
