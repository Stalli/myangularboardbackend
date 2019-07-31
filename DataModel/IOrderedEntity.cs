using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public interface IOrderedEntity
    {
        //void GetOrder();

        int OrderNo { get; set; }
    }
}
