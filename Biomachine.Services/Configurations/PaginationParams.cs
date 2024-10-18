﻿using Biomachine.Services.Helpers;

namespace Biomachine.Services.Configurations;

public class PaginationParams
{
    public PaginationParams()
    {
        PageIndex = EnvironmentHelper.PageIndex;
        PageSize = EnvironmentHelper.PageSize;
    }

    public int PageIndex { get; set; }
    public int PageSize { get; set; }
}
