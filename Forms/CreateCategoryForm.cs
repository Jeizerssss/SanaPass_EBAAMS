using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SanaPass_EBAAMS.Forms
{
    public partial class CreateCategoryForm : Form
    {
        public CreateCategoryForm()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = cbCategory.Text.Trim();
            string categoryDesc = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show(
                    "Please enter a category name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbCategory.Focus();
                return;
            }

            // Database functionality will be connected when the database is implemented.
            MessageBox.Show(
                "Category information is valid. Database functionality is not connected yet.",
                "Category",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
