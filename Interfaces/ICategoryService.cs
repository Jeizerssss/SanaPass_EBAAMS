using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface ICategoryService
    {
        bool createCategory(Category category);
        bool updateCategory(Category category);
        bool removeCategory(int categoryID);
        Category getCategoryById(int categoryID);
        IEnumerable<Category> getAllCategories();
    }
}
