﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MyShop.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApiIntergration
{
    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {
        public SlideApiClient(IHttpClientFactory httpClientFactory,
               IHttpContextAccessor httpContextAccessor,
                IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<SlideVm>> GetAll()
        {
            return await GetListAsync<SlideVm>("/api/slides");
        }
    }
}