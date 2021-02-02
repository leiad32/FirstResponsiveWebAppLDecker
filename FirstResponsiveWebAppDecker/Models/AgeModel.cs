using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppDecker.Models
{
    public class AgeModel
    {
        const int BEGIN_RANGE = 1921;
        const int END_RANGE = 2021;
        int CURRENT = DateTime.Now.Year;
        [Required(ErrorMessage ="Please enter a name.")]
        [StringLength (20, ErrorMessage = "Name cannot be more than 20 letters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a year between 1921-2021.")]
        [Range (BEGIN_RANGE,END_RANGE, ErrorMessage = "Birth year must be between 1921 and 2021.")]
        public int BirthYear { get; set; }

        public int AgeThisYear()
        {
            int age = CURRENT - BirthYear;
            return age;
        }
    }
}
