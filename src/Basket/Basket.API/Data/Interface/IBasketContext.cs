﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Basket.API.Data.Interface
{
    public interface IBasketContext
    {
        public IDatabase Redis { get; }
    }
}
