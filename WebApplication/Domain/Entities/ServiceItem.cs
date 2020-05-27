using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Domain.Entities
{
    public class ServiceItem:EntityBase
    {
        [Required(ErrorMessage ="Fill name of service")]
        [Display(Name = "Name of service")]
        public override string Title { get; set; }


        [Display(Name = "Full description")]
        public override string Text { get; set; }

        [Display(Name = "Short description")]
        public override string Subtitle { get; set; }
    }
}
