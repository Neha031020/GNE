using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessRepo
{
    public class CategoryRepo : ICategory
    {
        private readonly GneProjectContext _Context;
        public CategoryRepo(GneProjectContext context)
        {
            _Context = context;
        }
        public async Task<string> AddOrUpdateCategory(Category category)
        {
            try
            {
                var CategoryData = await _Context.Categories.Where(x => x.CategoryName == category.CategoryName)
                                                            .FirstOrDefaultAsync();
                if (CategoryData != null)
                {
                    CategoryData.CategoryType = category.CategoryType;
                    await _Context.SaveChangesAsync();
                    return ("Updated Successfully.....:)");
                }
                _Context.Categories.Add(new Category
                {
                   CategoryType = category.CategoryType,
                   CategoryName = category.CategoryName,

                });
                await _Context.SaveChangesAsync();
                return ("Added Succesfully......:)");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Category>> CategoryList()
        {
            try
            {
                var ListCategory = await _Context.Categories.ToListAsync();
                return ListCategory;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> DeleteCategoryById(int id)
        {
            try
            {
                var CategoryById = await _Context.Categories.Where(x => x.CategoryId == id).FirstOrDefaultAsync();
                if (CategoryById == null)
                    return ("Category Not Found");
                _Context.RemoveRange(CategoryById);
                _Context.SaveChanges();
                return ("Delete Succesfully......:)");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
