﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Common
{
    public class PageResultBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecord { get; set; }

        public int PageCount
        {
            get
            {
                var pageCount = (double)TotalRecord / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}