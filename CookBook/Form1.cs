using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void recipeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cookBookDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookBookDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.cookBookDataSet.Ingredient);
            // TODO: This line of code loads data into the 'cookBookDataSet.Recipe' table. You can move, or remove it, as needed.
            this.recipeTableAdapter.Fill(this.cookBookDataSet.Recipe);

        }
    }
}
