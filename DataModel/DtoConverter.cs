using System.Collections.Generic;
using System.Linq;
using DataModel.Dtos;

namespace DataModel
{
    public static class DtoConverter
    {
        public static IEnumerable<ColumnDto> ToDto(this IEnumerable<Column> columns, IEnumerable<Card> cards)
        {
            return columns.Select(col => new ColumnDto
            {
                Id = col.Id,
                OrderNo = col.OrderNo,
                Title = col.Title,
                Cards = cards.Where(car => car.ColumnId == col.Id)
            });
        }

        public static Column ToEntity(this ColumnDto dto)
        {
            return new Column
            {
                Id = dto.Id,
                OrderNo = dto.OrderNo,
                Title = dto.Title,
                UserId = dto.UserId
            };
        }
    }
}