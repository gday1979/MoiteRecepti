namespace MoiteRecepti.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RecipeIngredientInputModel
    {
        [Required]
        [MinLength(3)]
        public string IngredientName { get; set; }

        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
