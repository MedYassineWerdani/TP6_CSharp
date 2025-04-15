using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook.Data.Entities;
using RecipeNotebook.Data.Repositories;

namespace RecipeNotebook.RecipeForms
{
    public partial class RecipesListForm : Form
    {
        private readonly IServiceProvider _serviceProvider;


        public RecipesListForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void RecipesListForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var newRecipe = new Data.Entities.Recipe();
            var dialogForm = new RecipeDetailsForm(newRecipe , getCategories());
            var dialogResult = dialogForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var repo = _serviceProvider.GetRequiredService<RecipeRepository>();
                repo.Add(newRecipe);
                ReloadData();
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            var recipe = recipeBindingSource.Current as Data.Entities.Recipe;
            if (recipe != null)
            {
                var dialogForm = new RecipeDetailsForm(recipe , getCategories());
                var dialogResult = dialogForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    var repo = _serviceProvider.GetRequiredService<RecipeRepository>();
                    repo.Update(recipe);
                    ReloadData();
                }
            }
        }

        private IEnumerable<Category> getCategories()
        {
            using (var repoCategory = _serviceProvider.GetRequiredService<CategoryRepository>())
            {
                return repoCategory.GetAll();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            var recipe = recipeBindingSource.Current as Data.Entities.Recipe;
            if (recipe != null)
            {
                var dialogResult = MessageBox.Show(
                    $"Are you sure you want to delete the recipe: '{recipe.Title}'?",
                    "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var repo = _serviceProvider.GetRequiredService<RecipeRepository>();
                    repo.Delete(recipe.Id);
                    ReloadData();
                }
            }
        }

        public void ReloadData()
        {
            var repo = _serviceProvider.GetRequiredService<RecipeRepository>();
            recipeBindingSource.DataSource = repo.GetAll();
        }
    }
}
