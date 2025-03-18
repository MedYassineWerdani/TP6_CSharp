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
        private CategoryDetailsForm _categoryDetailsForm;
        private IServiceProvider _serviceProvider;

        public CategoriesListForm(CategoryDetailsForm categoryDetailsForm , IServiceProvider serviceProvider)
        {
            _categoryDetailsForm = categoryDetailsForm;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            var dialogResult = _categoryDetailsForm.ShowDialog();
        }

        private void CategoriesListForm_Load(object sender, EventArgs e)
        {
            var repoCategory = _serviceProvider.GetRequiredService<CategoryRepository>();
        }
    }
}
