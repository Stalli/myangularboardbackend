using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DataModel;
using DataModel.Dtos;
using NUnit.Framework;

namespace DalTests
{
  public class ColumnsTests
  {

    private Data data;
    private string userId_1 = "user1";
    private string userId_2 = "user2";

    [SetUp]
    public void Setup()
    {
      data = new Data
      (
        new List<Column>
        {
          new Column
          {
            Id = 1,
            OrderNo = 1,
            Title = "BackendColumnTitleForColumnOne",
            UserId = userId_1
          },
          new Column
          {
            Id = 2,
            OrderNo = 2,
            Title = "BackendColumnTitleForColumnTwo",
            UserId = userId_1
          },
          new Column
          {
            Id = 3,
            OrderNo = 3,
            Title = "BackendColumnTitleForColumnThree",
            UserId = userId_2
          },
          new Column
          {
            Id = 4,
            OrderNo = 4,
            Title = "BackendColumnTitleForColumnFour",
            UserId = userId_2
          },
          new Column
          {
            Id = 5,
            OrderNo = 5,
            Title = "BackendColumnTitleForColumnFive"
          }
        },
        new List<Card>
        {
          new Card{
            Id = 1,
            Title = "TestCard1",
            Description = "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
            },
          new Card{
            Id = 2,
            Title = "TestCard2",
            Description = "2TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
          },
          new Card{
            Id = 3,
            Title = "TestCard3",
            Description = "3TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
          },
          new Card{
            Id = 4,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2
          },
          new Card{
            Id = 5,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2
          },
          new Card{
            Id = 6,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2
          },
          new Card{
            Id = 7,
            Title = "TestCard7",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3
          },
          new Card{
            Id = 8,
            Title = "TestCard8",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3
          },
          new Card{
            Id = 9,
            Title = "TestCard9",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3
          },
          new Card{
            Id = 10,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4
          },
          new Card{
            Id = 11,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4
          },
          new Card{
            Id = 12,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4
          },
          new Card{
            Id = 13,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5
          },
          new Card{
            Id = 14,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5
          },
          new Card{
            Id = 15,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5
          }
        },
        new List<Comment>()
      );
    }

    [Test]
    public void GetNonexistentUserColumnsTest()
    {
        var nonExistentUserId = "foo";
        var count = data.Columns.Count(col => string.Equals(col.UserId, nonExistentUserId));
        var columns = data.GetColumns(nonExistentUserId);

        Assert.AreEqual(0, count);
        Assert.AreEqual(0, columns.Count());
    }

    [Test]
    public void GetUsersAllColumnsTest()
    {
        var count = data.Columns.Count(col => string.Equals(col.UserId, userId_1));
        var columns = data.GetColumns(userId_1);

        Assert.AreEqual(count, columns.Count());
    }

    [Test]
    public void GetZeroColumnsTest()
    {
        var count = data.Columns.Count(col => string.Equals(col.UserId, userId_1));
        var columns = data.GetColumns(userId_1, 0);

        Assert.NotZero(count);
        Assert.Zero(columns.Count());
    }

    [Test]
    public void GetNegativeColumnsTest()
    {
        var columns = data.GetColumns(userId_1, -2);

        Assert.Zero(columns.Count());
    }

    [Test]
    public void GetLessThanExistColumnsTest()
    {
        var amountToTake = 1;
        var count = data.Columns.Count(col => string.Equals(col.UserId, userId_1));

        var columns = data.GetColumns(userId_1, amountToTake);

        Assert.Greater(count, amountToTake);
        Assert.AreEqual(amountToTake, columns.Count());
    }

    [Test]
    public void GetMoreThanExistColumnsTest()
    {
        var amountToTake = 3;
        var count = data.Columns.Count(col => string.Equals(col.UserId, userId_1));
        var columns = data.GetColumns(userId_1, amountToTake);

        Assert.Less(count, amountToTake);
        Assert.AreEqual(count, columns.Count());
    }

    [Test]
    public void AddColumnTest()
    {
        var countBefore = data.Columns.Count(col => string.Equals(col.UserId, userId_1));

        data.AddColumn(new ColumnDto
        {
            UserId = userId_1
        });

        var countAfter = data.Columns.Count(col => string.Equals(col.UserId, userId_1));

        Assert.AreEqual(countBefore+1,countAfter);
    }

  }
}
