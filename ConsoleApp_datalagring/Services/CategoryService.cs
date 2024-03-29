﻿using ConsoleApp_datalagring.Entities;
using ConsoleApp_datalagring.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Services
{
    internal class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }



        public CategoryEntity CreateCategory(string categoryName)
        {
            var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
            categoryEntity ??= _categoryRepository.Create(new CategoryEntity { CatagoryName = categoryName });
            return categoryEntity;
        }

        public CategoryEntity GetCategoryByCategoryName(string categoryName)
        {

            var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
            return categoryEntity;
        }
        public CategoryEntity GetCategoryById(int id)
        {

            var categoryEntity = _categoryRepository.Get(x => x.Id == id);
            return categoryEntity;
        }

        public IEnumerable<CategoryEntity> GetCategories() 
        {
            var categories = _categoryRepository.GetAll();
            return categories;
        }

        public CategoryEntity UpdateCategory(CategoryEntity categoryEntity)
        {
            var updatedCategoryEntity = _categoryRepository.Update(x => x.Id == categoryEntity.Id, categoryEntity);
            return updatedCategoryEntity;
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(x => x.Id == id);    
        }
    }
}
