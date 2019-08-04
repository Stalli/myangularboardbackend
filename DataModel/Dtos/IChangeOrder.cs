using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
    public interface IChangeOrder
    {
        int PreviousOrderNo { get; set; }//1-based (not 0-based)
        int NewOrderNo { get; set; }//1-based
    }
}
