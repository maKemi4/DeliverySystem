﻿using DeliverySystem.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IPathCreatingService
    {
        Task<BuiltPath> CreatePath(int orderId);
    }
}
