using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeNotebook.CategoryForms
{
    public partial class CategoriesListForm : Form
    {
        private CategoryDetailsForm _categoryDetailsForm;
        public CategoriesListForm(CategoryDetailsForm categoryDetailsForm)
        {
            _categoryDetailsForm = categoryDetailsForm;
            InitializeComponent();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            var dialogResult = _categoryDetailsForm.ShowDialog();
        }
    }
}
