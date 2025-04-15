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
using RecipeNotebook.Data.Repositories;

namespace RecipeNotebook.CategoryForms
{
    public partial class CategoriesListForm : Form
    {
        //private CategoryDetailsForm _categoryDetailsForm;
        private IServiceProvider _serviceProvider;

        public CategoriesListForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            var category = categoryBindingSource.Current as Data.Entities.Category;
            if (category != null)
            {
                var dialogForm = new CategoryDetailsForm(category);
                var dialogResult = dialogForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    using (var repoCategory = _serviceProvider.GetRequiredService<CategoryRepository>())
                    {
                        repoCategory.Update(category);
                    }
                }
            }
        }

        private void CategoriesListForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var newCategorie = new Data.Entities.Category();
            var dialogForm = new CategoryDetailsForm(newCategorie);
            var DialogResult = dialogForm.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                using (var repoCategory = _serviceProvider.GetRequiredService<CategoryRepository>())
                {
                    repoCategory.Add(newCategorie);
                }
            }
            ReloadData();
        }

        public void ReloadData()
        {
            using (var repoCategory = _serviceProvider.GetRequiredService<CategoryRepository>())
            {
                categoryBindingSource.DataSource = repoCategory.GetAll();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            var category = categoryBindingSource.Current as Data.Entities.Category;
            if (category != null)
            {
                var dialogResult = MessageBox.Show($"Are you sure you want to delete the category : '{category.Name}'", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var repoCategory = _serviceProvider.GetRequiredService<CategoryRepository>())
                    {
                        repoCategory.Delete(category.Id);
                    }
                }
            }
            ReloadData();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
