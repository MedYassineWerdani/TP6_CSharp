using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook.CategoryForms;

namespace RecipeNotebook
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private CategoryForms.CategoriesListForm _categoriesListForm;
        private RecipeForms.RecipesListForm _recipesListForm;
        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();           
        }

        private void recettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecipesListForm();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCategoriesListForm();
        }


        //Private Methods
        private void ShowRecipesListForm()
        {
            //V�rifie si l'instance de la fen�tre des cat�gories est nulle ou d�j� ferm�e
            if (_recipesListForm == null || _recipesListForm.IsDisposed)
            {
                // R�cup�re une instance via l'injection de d�pendances
                _recipesListForm = _serviceProvider.GetRequiredService<RecipeForms.RecipesListForm>();
                // D�finit la fen�tre comme enfant du formulaire MDI principal
                _recipesListForm.MdiParent = this;
                // D�finit la fen�tre en plein �cran
                _recipesListForm.WindowState = FormWindowState.Maximized;
            }
            // Affiche la fen�tre si elle n'est pas d�j� affich�e et la met au premier plan
            _recipesListForm.Show();
            _recipesListForm.Activate();
        }
        private void ShowCategoriesListForm()
        {
            // V�rifie si l'instance de la fen�tre des cat�gories est nulle ou d�j� ferm�e
            if (_categoriesListForm == null || _categoriesListForm.IsDisposed)
            {
                // R�cup�re une instance via l'injection de d�pendances
                _categoriesListForm = _serviceProvider.GetRequiredService<CategoryForms.CategoriesListForm>();
                // D�finit la fen�tre comme enfant du formulaire MDI principal
                _categoriesListForm.MdiParent = this;
                // D�finit la fen�tre en plein �cran
                _categoriesListForm.WindowState = FormWindowState.Maximized;
            }

            // Affiche la fen�tre si elle n'est pas d�j� affich�e et la met au premier plan
            _categoriesListForm.Show();
            _categoriesListForm.Activate();
        }
    }
}
