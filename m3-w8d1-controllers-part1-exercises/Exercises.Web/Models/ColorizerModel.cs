using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class ColorizerModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiscellaneousColor { get; set; }

        [Display(Name = "Red")]
        public bool IsRed { get; set; }
        public bool IsBlue { get; set; }
        public bool IsGreen { get; set; }
    }
}