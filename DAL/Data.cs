using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
using DataModel.Dtos;

namespace DAL
{
  public class Data
  {
    private const string DemoUserId = "DEMO_USER_ID";

    private static Data _instance;
    private List<Column> _columns { get; set; }
    private List<Card> _cards { get; set; }
    private List<Comment> _comments { get; set; }

    private Data()
    {
      _columns = new List<Column>
      {
        new Column
        {
          Id = 1,
          OrderNo = 1,
          Title = "ColumnOne",
          UserId = "103168318818722947027"
        },
        new Column
        {
          Id = 2,
          OrderNo = 2,
          Title = "BackendColumnTitleForColumnTwoqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq",
          UserId = "2103168318818722947027"
        },
        new Column
        {
          Id = 3,
          OrderNo = 3,
          Title = "ColumnThree",
          UserId = "103168318818722947027"
        },
        new Column
        {
          Id = 4,
          OrderNo = 4,
          Title = "BackendColumnTitleForColumnFour",
          UserId = DemoUserId
        },
        new Column
        {
          Id = 5,
          OrderNo = 5,
          Title = "BackendColumnTitleForColumnFive",
          UserId = DemoUserId
        }
      };

      _cards = new List<Card>
        {
          new Card{
            Id = 1,
            Title = "TestCard1",
            Description = "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1,
            OrderNo = 1
            },
          new Card{
            Id = 2,
            Title = "TestCard2",
            Description = "2TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1,
            OrderNo = 2
          },
          new Card{
            Id = 3,
            Title = "TestCard3",
            Description = "3TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1,
            OrderNo = 3
          },
          new Card{
            Id = 4,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2,
            OrderNo = 1
          },
          new Card{
            Id = 5,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2,
            OrderNo = 2
          },
          new Card{
            Id = 6,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2,
            OrderNo = 3
          },
          new Card{
            Id = 7,
            Title = "TestCard7",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3,
            OrderNo = 1
          },
          new Card{
            Id = 8,
            Title = "TestCard8",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3,
            OrderNo = 2
          },
          new Card{
            Id = 9,
            Title = "TestCard9",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3,
            OrderNo = 3
          },
          new Card{
            Id = 10,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4,
            OrderNo = 1
          },
          new Card{
            Id = 11,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4,
            OrderNo = 2
          },
          new Card{
            Id = 12,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4,
            OrderNo = 3
          },
          new Card{
            Id = 13,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5,
            OrderNo = 1
          },
          new Card{
            Id = 14,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5,
            OrderNo = 2
          },
          new Card{
            Id = 15,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5,
            OrderNo = 3
          },
        };

      _comments = new List<Comment>
      {
        new Comment
        {
          Id = 1,
          CardId = 1,
          Text = "Awesome comment"
        },
        new Comment
        {
          Id = 2,
          CardId = 1,
          Text = "Qasdasdasd comment"
        },
        new Comment
        {
          Id = 3,
          CardId = 2,
          Text = "Adadsasdsdsd comment"
        },
        new Comment
        {
          Id = 4,
          CardId = 2,
          Text = "Ffweefefwefwefwefwefwef comment"
        },
        new Comment
        {
          Id = 5,
          CardId = 3,
          Text = "Fwdewdwede comment"
        },
      };
    }

        public static Data Instance => _instance ?? (_instance = new Data());

    public Data(List<Column> columns, List<Card> cards, List<Comment> comments)
    {
      _columns = columns;
      _cards = cards;
      _comments = comments;
    }

    public IEnumerable<Column> Columns => _columns;

    public IEnumerable<CardDto> Cards => _cards.Select(car => new CardDto
    {
      Id = car.Id,
      Title = car.Title,
      Description = car.Description,
      ColumnId = car.ColumnId,
      OrderNo = car.OrderNo,
      ColumnTitle = _columns.FirstOrDefault(col => col.Id == car.ColumnId)?.Title,
      Comments = _comments.Where(com => com.CardId == car.Id)
    });

    public IEnumerable<Comment> Comments => _comments.Select(c => c);

    public IEnumerable<ColumnDto> GetColumns()
    {
        return GetColumns(DemoUserId);
    }

    public IEnumerable<ColumnDto> GetColumns(string userId, int? count = null)
    {
        var query = _columns.Where(col => col.UserId == userId);

        query = count.HasValue ? query.Take(count.Value) : query;

        return query.ToDto(_cards);
    }

    /// <summary>
    /// Changes the order of one entity inside a parent one, e.g. a card inside a column or column inside a board.
    /// Don't use this function for moving a card from one column to another.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    private bool ChangeOrder<T>(T entity, IChangeOrder dto) where T : IOrderedEntity
    {
        try
        {
            if (entity == null)
            {
                Log();
                return false;
            }

            if (dto.NewOrderNo == dto.PreviousOrderNo)
                return true;

            entity.OrderNo = dto.NewOrderNo;

            var repository = GetRepository<T>();

            if (dto.NewOrderNo > dto.PreviousOrderNo)
            {
                repository.Where(col =>
                        col.OrderNo <= dto.NewOrderNo &&
                        col.OrderNo > dto.PreviousOrderNo &&
                        col.Id != entity.Id)
                    .ToList().ForEach(col => { col.OrderNo--; });
            }
            else
            {
                repository.Where(col =>
                        col.OrderNo >= dto.NewOrderNo &&
                        col.OrderNo < dto.PreviousOrderNo &&
                        col.Id != entity.Id)
                    .ToList().ForEach(col => { col.OrderNo++; });
            }
        }
        catch (Exception)
        {
            Log();
            return false;
        }

        return true;
    }

    private IEnumerable<T> GetRepository<T>() where T : IOrderedEntity
        {
        if (typeof(T) == typeof(Column))
        {
            return _columns as IEnumerable<T>;
        }

        if (typeof(T) == typeof(Card))
        {
            return _cards as IEnumerable<T>;
        }

        if (typeof(T) == typeof(Comment))
        {
            return _comments as IEnumerable<T>;
        }

        throw new Exception("Unknown type");
    }


    public bool MoveColumn(MoveColumnDto moveColumnDto)
    {
        var column = _columns.FirstOrDefault(col => col.OrderNo == moveColumnDto.PreviousOrderNo);
        return ChangeOrder(column, moveColumnDto);
    }

    public bool MoveCard(MoveCardDto moveCardDto)
    {
        var card = _cards.FirstOrDefault(car => car.Id == moveCardDto.CardId && car.OrderNo == moveCardDto.PreviousOrderNo);

        if (card == null)
            return false;

        if (card.ColumnId == moveCardDto.TargetColumnId)
            return ChangeOrder(card, moveCardDto);
        
        _cards.Where(car => car.ColumnId == moveCardDto.TargetColumnId
                            && car.OrderNo >= moveCardDto.NewOrderNo
                            && car.Id != card.Id)
            .ToList().ForEach(car => { car.OrderNo++; });

        _cards.Where(car => car.ColumnId == card.ColumnId
                            && car.OrderNo >= moveCardDto.PreviousOrderNo)
            .ToList().ForEach(car => { car.OrderNo--; });

        card.OrderNo = moveCardDto.NewOrderNo;
        card.ColumnId = moveCardDto.TargetColumnId;

        return true;
    }

    private void Log()
    {
    }

    public ColumnDto AddColumn(ColumnDto input)
    {
      input.Id = _columns.Max(col => col.Id) + 1;
      input.OrderNo = _columns.Max(col => col.OrderNo) + 1;

      _columns.Add(input.ToEntity());

      return input;
    }

    public Comment AddComment(Comment input)
    {
      input.Id = (_comments.Any() ? _comments.Max(com => com.Id) : 0) + 1;

      _comments.Add(input);

      return input;
    }

    public CardDto AddCard(CardDto input)
    {
      input.Id = _cards.Max(car => car.Id) + 1;
      var orderNumber = _cards.Max(car => car.OrderNo) + 1;

      _cards.Add(new Card
      {
        Id = input.Id,
        ColumnId = input.ColumnId,
        Title = input.Title,
        OrderNo = orderNumber
      });

      return input;
    }

    public void UpdateCard(CardDto input)
    {
      var card = _cards.FirstOrDefault(c => c.Id == input.Id);

      card.Title = input.Title;
      card.ColumnId = input.ColumnId;
      card.Description = input.Description;


      if (input.Comments == null)
      {
        _comments.RemoveAll(com => com.CardId == input.Id);
      }
      else
      {
        // some comment could be deleted from card at the front, but is still in card.Comments at the backend
        _comments.RemoveAll(com =>
          com.CardId == input.Id &&
          !input.Comments.Select(ic => ic.Id).Contains(com.Id));

        foreach (var comment in input.Comments)
          UpdateComment(comment);
      }
    }

    public void UpdateComment(Comment input)
    {
      var comment = _comments.FirstOrDefault(c => c.Id == input.Id) ?? AddComment(input);

      comment.Text = input.Text;
      comment.CardId = input.CardId;
    }

    public void DeleteCard(int id)
    {
        _cards.Remove(_cards.First(c => c.Id == id));
    }
  }
}
