using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
  public class MoveColumnDto : IChangeOrder
  {
    public int PreviousOrderNo { get; set; }
    public int NewOrderNo { get; set; }
    public MoveColumnDto(int previous, int newOne)
    {
        PreviousOrderNo = previous;
        NewOrderNo = newOne;
    }
  }
}
