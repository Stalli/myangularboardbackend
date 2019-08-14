using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
  public class Column : IOrderedEntity
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int OrderNo { get; set; }
    public string UserId { get; set; }
  }
}
