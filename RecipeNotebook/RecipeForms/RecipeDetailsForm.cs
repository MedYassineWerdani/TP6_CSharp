using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeNotebook.Data.Entities;

namespace RecipeNotebook.RecipeForms
{
    public partial class RecipeDetailsForm : Form
    {
        public RecipeDetailsForm(Data.Entities.Recipe recipe)
        {
            InitializeComponent();
            recipeBindingSource.DataSource = recipe;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
    }
}
