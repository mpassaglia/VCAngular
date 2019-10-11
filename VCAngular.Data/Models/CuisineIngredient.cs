using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VCAngular.Data
{
    public class CuisineIngredient
    {
        //[Key, Column(Order = 0)]
        public int CuisineId { get; set; }
        //[Key, Column(Order = 1)]
        public int IngredientId { get; set; }
    }
}
