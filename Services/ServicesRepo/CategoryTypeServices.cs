using AutoMapper;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Services.DTOClass;

using Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesRepo
{
    public class CategoryTypeServices : ICategoryTypeServices
    {
        private readonly ICategory _category;
        private IMapper _mapper;
        public CategoryTypeServices(ICategory category, IMapper mapper)
        {
           _category = category;
            _mapper = mapper;
        }
        public async Task<string> AddOrUpdateCategory(CategoryTypeDTO categoryDTO)
        {
            var DtoToUser = _mapper.Map<CategoryTypeDTO, Category>(categoryDTO);

            var CurrencyData = await _category.AddOrUpdateCategory(DtoToUser);
            return CurrencyData;
        }

        public async Task<string> DeleteCategoryById(int id)
        {
            var DeleteCategory=await _category.DeleteCategoryById(id);
            return DeleteCategory;
        }

        public async Task<List<CategoryTypeDTO>> GetAllCategoryList()
        {
            var ListOfCategory = await _category.CategoryList();
            var DtoToClass = _mapper.Map<List<Category>, List<CategoryTypeDTO>>(ListOfCategory);
            return DtoToClass;
        }

        
    }
}
