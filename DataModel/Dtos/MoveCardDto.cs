using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
  public class MoveCardDto : IChangeOrder
    {
    public int CardId { get; set; }
    public int TargetColumnId { get; set; }
    public int PreviousOrderNo { get; set; }
    public int NewOrderNo { get; set; }
    }
}
