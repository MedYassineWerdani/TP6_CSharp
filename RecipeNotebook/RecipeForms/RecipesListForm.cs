using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeNotebook.RecipeForms
{
    public partial class RecipesListForm: Form
    {
        private RecipeDetailsForm _recipeDetailsForm;
        public RecipesListForm(RecipeDetailsForm recipeDetailsForm)
        {
            _recipeDetailsForm = recipeDetailsForm;
            InitializeComponent();
        }
    }
}
