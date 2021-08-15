﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.System.Language;
using MyShop.ViewModels.System.Languages;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        //PUBLIC

        //http://localhost/port/product/products/products?pageIndex=1&pagesize=10
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            ApiResult<List<LanguageVm>> language = await _languageService.GetAll();
            return Ok(language);
        }
    }
}