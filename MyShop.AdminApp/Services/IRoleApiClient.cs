﻿using MyShop.ViewModels.Common;
using MyShop.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.AdminApp.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RolesVm>>> GetAll();
    }
}