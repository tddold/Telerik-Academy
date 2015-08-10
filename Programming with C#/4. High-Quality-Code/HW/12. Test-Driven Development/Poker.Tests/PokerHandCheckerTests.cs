namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PokerHandCheckerTests
    {
        private Hand testValidHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidFlushHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Clubs),
                        new Card(CardFace.Jack, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Clubs)
                    });

        private Hand testValidFlushHand2 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Clubs),
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Clubs)
                    });

        private Hand testInvalidHandWithLessCards =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs)
                    });

        private Hand testInvalidHandWithMoreCards =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds),
                        new Card(CardFace.Nine, CardSuit.Diamonds)
                    });

        private Hand testInvalidHandWithSameCards =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Clubs)
                    });

        private Hand testValidOnePairHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.King, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Diamonds),
                        new Card(CardFace.Eight, CardSuit.Clubs)
                    });

        private Hand testValidOnePairHand2 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.King, CardSuit.Clubs),
                        new Card(CardFace.Five, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Ten, CardSuit.Diamonds),
                        new Card(CardFace.Ten, CardSuit.Clubs)
                    });

        private Hand testValidFourOfAKindHand = new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Eight, CardSuit.Spades),
                        new Card(CardFace.Eight, CardSuit.Hearts),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Diamonds),
                        new Card(CardFace.Eight, CardSuit.Clubs)
                    });

        private Hand testValidFourOfAKindHand2 = new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Seven, CardSuit.Spades),
                        new Card(CardFace.Seven, CardSuit.Hearts),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Seven, CardSuit.Diamonds),
                        new Card(CardFace.Seven, CardSuit.Clubs)
                    });

        private Hand testValidFourOfAKindHand3 = new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Seven, CardSuit.Spades),
                        new Card(CardFace.Seven, CardSuit.Hearts),
                        new Card(CardFace.Five, CardSuit.Hearts),
                        new Card(CardFace.Seven, CardSuit.Diamonds),
                        new Card(CardFace.Seven, CardSuit.Clubs)
                    });

        private Hand testValidHigCardHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Clubs)
                    });

        private Hand testValidHigCardHand2 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Two, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Clubs)
                    });

        private Hand testValidTwoPairHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Ten, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidTwoPairHand4 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Seven, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Ten, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidTwoPairHand2 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Jack, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidTwoPairHand3 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Ten, CardSuit.Hearts),
                        new Card(CardFace.Two, CardSuit.Clubs),
                        new Card(CardFace.Two, CardSuit.Diamonds)
                    });


        private Hand testValidThreeOfAKindHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Ten, CardSuit.Hearts),
                        new Card(CardFace.Ten, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidThreeOfAKindHand2 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.King, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Spades),
                        new Card(CardFace.Nine, CardSuit.Hearts),
                        new Card(CardFace.Nine, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidThreeOfAKindHand3 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Spades),
                        new Card(CardFace.Nine, CardSuit.Hearts),
                        new Card(CardFace.Nine, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Diamonds)
                    });

        private Hand testValidFullHouseHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Ten, CardSuit.Hearts),
                        new Card(CardFace.Ten, CardSuit.Clubs),
                        new Card(CardFace.Ace, CardSuit.Diamonds)
                    });

        private Hand testValidFullHouseHand2 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Jack, CardSuit.Spades),
                        new Card(CardFace.Jack, CardSuit.Hearts),
                        new Card(CardFace.Jack, CardSuit.Clubs),
                        new Card(CardFace.Ace, CardSuit.Diamonds)
                    });

        private Hand testValidFullHouseHand3 =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Spades),
                        new Card(CardFace.Ten, CardSuit.Hearts),
                        new Card(CardFace.Ten, CardSuit.Clubs),
                        new Card(CardFace.Five, CardSuit.Diamonds)
                    });

        private Hand testValidStraightHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Six, CardSuit.Spades),
                        new Card(CardFace.Seven, CardSuit.Hearts),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Diamonds)
                    });

        private Hand testA2345Straight =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Four, CardSuit.Spades),
                        new Card(CardFace.Two, CardSuit.Hearts),
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Three, CardSuit.Diamonds)
                    });

        private Hand test23456Straight =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Four, CardSuit.Spades),
                        new Card(CardFace.Two, CardSuit.Hearts),
                        new Card(CardFace.Six, CardSuit.Clubs),
                        new Card(CardFace.Three, CardSuit.Diamonds)
                    });

        private Hand testTJQKAStraight =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Jack, CardSuit.Clubs),
                        new Card(CardFace.Ace, CardSuit.Spades),
                        new Card(CardFace.King, CardSuit.Hearts),
                        new Card(CardFace.Queen, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Diamonds)
                    });

        private Hand testValidStraightFlushHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Six, CardSuit.Clubs),
                        new Card(CardFace.Seven, CardSuit.Clubs),
                        new Card(CardFace.Eight, CardSuit.Clubs),
                        new Card(CardFace.Nine, CardSuit.Clubs)
                    });

        private Hand testA2345StraightFlushHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Two, CardSuit.Clubs),
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Four, CardSuit.Clubs),
                        new Card(CardFace.Three, CardSuit.Clubs)
                    });

        private Hand testTJQKAStraightFlushHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Queen, CardSuit.Clubs),
                        new Card(CardFace.Ace, CardSuit.Clubs),
                        new Card(CardFace.Jack, CardSuit.Clubs),
                        new Card(CardFace.King, CardSuit.Clubs),
                        new Card(CardFace.Ten, CardSuit.Clubs)
                    });

        private Hand test23456StraightFlushHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Five, CardSuit.Clubs),
                        new Card(CardFace.Two, CardSuit.Clubs),
                        new Card(CardFace.Six, CardSuit.Clubs),
                        new Card(CardFace.Four, CardSuit.Clubs),
                        new Card(CardFace.Three, CardSuit.Clubs)
                    });


        private PokerHandsChecker testChecker = new PokerHandsChecker();

        // IsValidHand() tests
        [TestMethod]
        public void IsValidHandShouldReturnTrueWhenAValidHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsValidHand(this.testValidHand));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenNullIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsValidHand(null));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenHandWithLessThanFiveCardsIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsValidHand(this.testInvalidHandWithLessCards));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenHandWithMoreThanFiveCardsIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsValidHand(this.testInvalidHandWithMoreCards));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenHandWithTwoOrMoreSameCardsIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsValidHand(this.testInvalidHandWithSameCards));
        }

        // IsFlush() tests
        [TestMethod]
        public void IsFlushShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFlush(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsFlush(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsFlush(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseWhenANonFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFlush(this.testValidHand));
        }

        [TestMethod]
        public void IsFlushShouldReturnTrueWhenAFlushHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsFlush(this.testValidFlushHand));
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseWhenAStraightFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFlush(this.testValidStraightFlushHand));
        }

        // IsFourOfAKind() tests
        [TestMethod]
        public void IsFourOfAKindShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFourOfAKind(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsFourOfAKind(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsFourOfAKind(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnFalseWhenANonFourOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFourOfAKind(this.testValidHand));
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnTrueWhenAFourOfAKindHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsFourOfAKind(this.testValidFourOfAKindHand));
        }

        // IsHighCard() tests
        [TestMethod]
        public void IsHighcardShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsHighCard(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsHighCard(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsHighCard(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseWhenANonHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsHighCard(this.testValidHand));
        }

        [TestMethod]
        public void IsHighCardShouldReturnTrueWhenAHighCardHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsHighCard(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseWhenAFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsHighCard(this.testValidFlushHand));
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseWhenAStraightHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsHighCard(this.testValidStraightHand));
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseWhenAStraightFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsHighCard(this.testValidStraightFlushHand));
        }

        // IsOnePair() tests
        [TestMethod]
        public void IsOnePairShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsOnePair(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsOnePair(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsOnePair(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsOnePairShouldReturnTrueWhenAValidOnePairHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsOnePair(this.testValidHand));
        }

        [TestMethod]
        public void IsOnePairShouldReturnFalseWhenAValidHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsOnePair(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsOnePairShouldReturnFalseWhenAValidTwoPairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsOnePair(this.testValidTwoPairHand));
        }

        [TestMethod]
        public void IsOnePairShouldReturnFalseWhenAValidFourOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsOnePair(this.testValidFourOfAKindHand));
        }

        [TestMethod]
        public void IsOnePairShouldReturnFalseWhenAValidThreeOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsOnePair(this.testValidThreeOfAKindHand));
        }

        [TestMethod]
        public void IsOnePairShouldReturnFalseWhenAValidFullHouseHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsOnePair(this.testValidFullHouseHand));
        }

        // IsTwoPair() tests
        [TestMethod]
        public void IsTwoPairShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsTwoPairShouldReturnTrueWhenAValidTwoPairHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsTwoPair(this.testValidTwoPairHand));
        }

        [TestMethod]
        public void IsTwoPairShouldReturnFalseWhenAValidHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsTwoPairShouldReturnFalseWhenAValidOnePairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testValidHand));
        }

        [TestMethod]
        public void IsTwoPairShouldReturnFalseWhenAValidFourOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testValidFourOfAKindHand));
        }

        [TestMethod]
        public void IsTwoPairShouldReturnFalseWhenAValidThreeOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testValidThreeOfAKindHand));
        }

        [TestMethod]
        public void IsTwoPairShouldReturnFalseWhenAValidFullHouseHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsTwoPair(this.testValidFullHouseHand));
        }

        // IsThreeOfAKind() tests
        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnTrueWhenAValidThreeOfAKindHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsThreeOfAKind(this.testValidThreeOfAKindHand));
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseWhenAValidHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseWhenAValidOnePairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testValidHand));
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseWhenAValidFourOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testValidFourOfAKindHand));
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseWhenAValidTwoPairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testValidTwoPairHand));
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseWhenAValidFullHouseHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsThreeOfAKind(this.testValidFullHouseHand));
        }

        // IsFullHouse() tests
        [TestMethod]
        public void IsFullHouseShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsFullHouseShouldReturnFalseWhenAValidThreeOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testValidThreeOfAKindHand));
        }

        [TestMethod]
        public void IsFullHouseShouldReturnFalseWhenAValidHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsFullHouseShouldReturnFalseWhenAValidOnePairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testValidHand));
        }

        [TestMethod]
        public void IsFullHouseShouldReturnFalseWhenAValidFourOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testValidFourOfAKindHand));
        }

        [TestMethod]
        public void IsFullHouseShouldReturnFalseWhenAValidTwoPairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsFullHouse(this.testValidTwoPairHand));
        }

        [TestMethod]
        public void IsFullHouseShouldReturnTrueWhenAValidFullHouseHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsFullHouse(this.testValidFullHouseHand));
        }

        // IsStraight() tests
        [TestMethod]
        public void IsStraightShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraight(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsStraight(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsStraight(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsStraightShouldReturnTrueWhenAValidStraightHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsStraight(this.testValidStraightHand));
        }

        [TestMethod]
        public void IsStraightShouldReturnTrueWhenAnA2345HandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsStraight(this.testA2345Straight));
        }

        [TestMethod]
        public void IsStraightShouldReturnTrueWhenATJQKAHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsStraight(this.testTJQKAStraight));
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseWhenAValidThreeOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraight(this.testValidThreeOfAKindHand));
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseWhenAValidHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraight(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseWhenAValidPairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraight(this.testValidHand));
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseWhenAValidFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraight(this.testValidFlushHand));
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseWhenAValidStraightFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraight(this.testValidStraightFlushHand));
        }

        // IsStraightFlush() tests
        [TestMethod]
        public void IsStraightFlushShouldReturnFalseWhenAnInvalidHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testInvalidHandWithLessCards));
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testInvalidHandWithMoreCards));
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testInvalidHandWithSameCards));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnTrueWhenAValidStraightFlushHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsStraightFlush(this.testValidStraightFlushHand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnTrueWhenAnA2345StraightFlushHandIsPassed()
        {
            Assert.IsTrue(this.testChecker.IsStraightFlush(this.testA2345StraightFlushHand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseWhenAValidThreeOfAKindHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testValidThreeOfAKindHand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseWhenAValidHighCardHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testValidHigCardHand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseWhenAValidPairHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testValidHand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseWhenAValidFlushHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testValidFlushHand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseWhenANonflushStraightHandIsPassed()
        {
            Assert.IsFalse(this.testChecker.IsStraightFlush(this.testValidStraightHand));
        }

        // CompareHands() tests
        // General
        // Either hand is invalid
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareHandsShouldThrowAnArgumentExceptionIfEitherOfThePassedHandsIsInvalid()
        {
            this.testChecker.CompareHands(this.testInvalidHandWithLessCards, this.testValidHand);
        }

        // Different in general strength hands
        [TestMethod]
        public void CompareHandsShouldReturnMinusOneWhenTheFirstHandIsWeaker()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidHigCardHand, this.testValidFourOfAKindHand));
        }

        [TestMethod]
        public void CompareHandsShouldReturnPlusOneWhenTheFirstHandIsStronger()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidStraightFlushHand, this.testValidFourOfAKindHand));
        }

        // Equal hands
        [TestMethod]
        public void CompareHandsShouldReturnZeroWhenTheHandsAreEqualInStrength()
        {
            Assert.AreEqual(0, this.testChecker.CompareHands(this.testValidHigCardHand, this.testValidHigCardHand));
        }

        // Equal in general strength hands (compare hands of the same type using further criteria)
        // HighCard hands
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentHighCardHandsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidHigCardHand, this.testValidHigCardHand2));
        }

        // OnePair hands
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentOnePairHandsWithTheSamePairsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidHand, this.testValidOnePairHand));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentOnePairHandsWithDifferentPairsArePassed()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidHand, this.testValidOnePairHand2));
        }

        // TwoPair hands
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentTwoPairHandsWithDifferentHighPairsArePassed()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidTwoPairHand, this.testValidTwoPairHand2));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentTwoPairHandsWithDifferentLowPairsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidTwoPairHand, this.testValidTwoPairHand3));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentTwoPairHandsWithSamePairsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidTwoPairHand, this.testValidTwoPairHand4));
        }

        // ThreeOfAKind hands
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentThreeOfAKindHandsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidThreeOfAKindHand, this.testValidThreeOfAKindHand2));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentThreeOfAKindHandsWithSameThreeOfAKindValueArePassed()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidThreeOfAKindHand2, this.testValidThreeOfAKindHand3));
        }

        // Straight hands
        [TestMethod]
        public void CompareHandsShouldReturnProperValueWhenTwoDifferentStraightsArePassedA2345IsLowest()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidStraightHand, this.testA2345Straight));
        }

        [TestMethod]
        public void CompareHandsShouldReturnProperValueWhenTwoDifferentStraightsArePassedTJQKAIsHighest()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidStraightHand, this.testTJQKAStraight));
        }

        [TestMethod]
        public void CompareHandsShouldReturnProperValueWhenA2345And23456ArePassed()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testA2345Straight, this.test23456Straight));
        }

        // Flush hands (compared like HighCard hands)
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentFlushHandsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidFlushHand, this.testValidFlushHand2));
        }

        // FullHouse hands
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentFullHouseHandsWithDifferentThreeOfAKindArePassed()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidFullHouseHand, this.testValidFullHouseHand2));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentFullHouseHandsWithSameThreeOfAKindArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidFullHouseHand, this.testValidFullHouseHand3));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentFullHouseHandsWithSameThreeOfAKindArePassed2()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidFullHouseHand3, this.testValidFullHouseHand));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoSameFullHouseHandsArePassed()
        {
            Assert.AreEqual(0, this.testChecker.CompareHands(this.testValidFullHouseHand, this.testValidFullHouseHand));
        }

        // FourOfAKind hands
        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentFourOfAKindHandsArePassed()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidFourOfAKindHand, this.testValidFourOfAKindHand2));
        }

        [TestMethod]
        public void CompareHandsShouldReturnTheProperValueWhenTwoDifferentFourOfAKindHandsArePassedSameFourOfAKindDifferentFifthCard()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidFourOfAKindHand2, this.testValidFourOfAKindHand3));
        }

        // StraightFlush hands (compared like straight hands)
        [TestMethod]
        public void CompareHandsShouldReturnProperValueWhenTwoDifferentStraightFlushHandsArePassedA2345IsLowest()
        {
            Assert.AreEqual(1, this.testChecker.CompareHands(this.testValidStraightFlushHand, this.testA2345StraightFlushHand));
        }

        [TestMethod]
        public void CompareHandsShouldReturnProperValueWhenTwoDifferentStraightFlushHandsArePassedTJQKAIsHighest()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testValidStraightHand, this.testTJQKAStraightFlushHand));
        }

        [TestMethod]
        public void CompareHandsShouldReturnProperValueWhenA2345And23456StraightFlushesArePassed()
        {
            Assert.AreEqual(-1, this.testChecker.CompareHands(this.testA2345StraightFlushHand, this.test23456StraightFlushHand));
        }
    }
}
