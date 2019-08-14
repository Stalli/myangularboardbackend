using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
  public class ColumnDto
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int OrderNo { get; set; }
    public string UserId { get; set; }

    public IEnumerable<Card> Cards { get; set; }
  }
}
