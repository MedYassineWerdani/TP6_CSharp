using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook.Data.Entities;
using RecipeNotebook.Data.Repositories;

namespace RecipeNotebook.RecipeForms
{
    public partial class RecipeDetailsForm : Form
    {
        public RecipeDetailsForm(Data.Entities.Recipe recipe , IEnumerable<Category> categories)
        {
            InitializeComponent();
            recipeBindingSource.DataSource = recipe;
            categoryBindingSource.DataSource = categories;
        }

    }
}
