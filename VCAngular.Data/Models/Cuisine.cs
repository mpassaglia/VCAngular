using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VCAngular.Data
{
    public class Cuisine
    {
        [Key]
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public string FormattedName { get; set; }
    }
}
