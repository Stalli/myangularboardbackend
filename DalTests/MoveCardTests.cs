using System.Collections.Generic;
using System.Linq;
using DAL;
using DataModel;
using DataModel.Dtos;
using NUnit.Framework;

namespace DalTests
{
    public class MoveCardTests
    {
        private Data data;

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
                        Title = "BackendColumnTitleForColumnOne"
                    },
                    new Column
                    {
                        Id = 2,
                        OrderNo = 2,
                        Title = "BackendColumnTitleForColumnTwo"
                    }
                },
                new List<Card>
                {
                    new Card
                    {
                        Id = 1,
                        Title = "TestCard1",
                        Description =
                            "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
                        ColumnId = 1,
                        OrderNo = 1
                    },
                    new Card
                    {
                        Id = 2,
                        Title = "TestCard2",
                        Description =
                            "2TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
                        ColumnId = 1,
                        OrderNo = 2
                    },
                    new Card
                    {
                        Id = 3,
                        Title = "TestCard3",
                        Description =
                            "3TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
                        ColumnId = 1,
                        OrderNo = 3
                    },
                    new Card
                    {
                        Id = 4,
                        Title = "TestCard4",
                        Description =
                            "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
                        ColumnId = 2,
                        OrderNo = 1
                    },
                    new Card
                    {
                        Id = 5,
                        Title = "TestCard5",
                        Description =
                            "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
                        ColumnId = 2,
                        OrderNo = 2
                    },
                    new Card
                    {
                        Id = 6,
                        Title = "TestCard6",
                        Description =
                            "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
                        ColumnId = 2,
                        OrderNo = 3
                    }
                },
                new List<Comment>()
            );
        }

        [Test]
        public void CardNotExistsTest()
        {
            var result = data.MoveCard(new MoveCardDto {CardId = 99});

            Assert.IsFalse(result);
        }

        [Test]
        public void MoveInsideOneColumnTest()
        {
            var cardId = 2;
            var cardColumnPrevious = data.Cards.FirstOrDefault(car => car.Id == cardId).ColumnId;
            var newOrderNumber = 3;

            var result = data.MoveCard(new MoveCardDto
            {
                CardId = cardId,
                PreviousOrderNo = 2,
                NewOrderNo = newOrderNumber,
                TargetColumnId = 1
            });

            var card = data.Cards.FirstOrDefault(car => car.Id == cardId);

            Assert.IsTrue(result);
            Assert.AreEqual(cardColumnPrevious, card.ColumnId);
            Assert.AreEqual(newOrderNumber, card.OrderNo);
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 1));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 1));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 3 && car.ColumnId == 1));
        }

        [Test]
        public void MoveToAnotherColumnWithSameOrderNumberTest()
        {
            var cardId = 1;
            var targetColumnId = 2;

            var result = data.MoveCard(new MoveCardDto
            {
                CardId = cardId,
                PreviousOrderNo = 1,
                NewOrderNo = 1,
                TargetColumnId = targetColumnId
            });

            var card = data.Cards.FirstOrDefault(car => car.Id == cardId);

            Assert.IsTrue(result);
            Assert.AreEqual(targetColumnId, card.ColumnId);

            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 1));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 1));

            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 3 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 4 && car.ColumnId == 2));
        }

        [Test]
        public void MoveToAnotherColumnWithLowerOrderNumberTest()
        {
            var cardId = 2;
            var targetColumnId = 2;

            var result = data.MoveCard(new MoveCardDto
            {
                CardId = cardId,
                PreviousOrderNo = 2,
                NewOrderNo = 1,
                TargetColumnId = targetColumnId
            });

            var card = data.Cards.FirstOrDefault(car => car.Id == cardId);

            Assert.IsTrue(result);
            Assert.AreEqual(targetColumnId, card.ColumnId);

            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 1));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 1));

            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 3 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 4 && car.ColumnId == 2));
        }

        [Test]
        public void MoveToAnotherColumnWithHigherOrderNumberTest()
        {
            var cardId = 2;
            var targetColumnId = 2;

            var result = data.MoveCard(new MoveCardDto
            {
                CardId = cardId,
                PreviousOrderNo = 2,
                NewOrderNo = 3,
                TargetColumnId = targetColumnId
            });

            var card = data.Cards.FirstOrDefault(car => car.Id == cardId);

            Assert.IsTrue(result);
            Assert.AreEqual(targetColumnId, card.ColumnId);

            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 1));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 1));

            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 1 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 2 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 3 && car.ColumnId == 2));
            Assert.AreEqual(1, data.Cards.Count(car => car.OrderNo == 4 && car.ColumnId == 2));
        }
    }
}