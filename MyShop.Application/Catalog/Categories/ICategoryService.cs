﻿using MyShop.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}