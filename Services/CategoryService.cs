using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public bool createCategory(Category category)
        {
            if (category == null || string.IsNullOrWhiteSpace(category.cName))
                return false;

            return _categoryRepository.add(category);
        }

        public bool updateCategory(Category category)
        {
            if (category == null || category.categoryID <= 0)
                return false;

            return _categoryRepository.update(category);
        }

        public bool removeCategory(int categoryID)
        {
            return _categoryRepository.delete(categoryID);
        }

        public Category getCategoryById(int categoryID)
        {
            return _categoryRepository.getById(categoryID);
        }

        public IEnumerable<Category> getAllCategories()
        {
            return _categoryRepository.getAll();
        }
    }
}
