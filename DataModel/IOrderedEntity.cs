﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public interface IOrderedEntity : IEntity
    {
        int OrderNo { get; set; } // 1-based
    }
}
