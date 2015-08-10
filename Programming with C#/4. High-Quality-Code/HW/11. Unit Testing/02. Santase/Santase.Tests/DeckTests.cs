namespace Santase.Tests
{
    using System;

    using NUnit.Framework;

    using Logic.Cards;

    using Santase.Logic;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void NewDeckShouldContain24Cards()
        {
            Deck testDeck = new Deck();
            Assert.AreEqual(24, testDeck.CardsLeft, "The new deck should contain 24 cards");
        }

        [Test]
        public void TrumpCardShouldBeAValidCard()
        {
            Deck testDeck = new Deck();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.GetTrumpCard.Suit), "Card must have one of the predefined suits");
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.GetTrumpCard.Type), "Card must have one of the predefined types");
        }

        [Test]
        public void GetNextCardShouldReturnAValidCard()
        {
            Deck testDeck = new Deck();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.GetNextCard().Suit), "Card must have one of the predefined suits");
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.GetNextCard().Type), "Card must have one of the predefined types");
        }

        [Test]
        public void GetNextCardShouldRemoveTheCardFromTheDeck()
        {
            Deck testDeck = new Deck();
            int initialNumberOfCards = testDeck.CardsLeft;
            testDeck.GetNextCard();
            Assert.AreEqual((initialNumberOfCards - 1), testDeck.CardsLeft, "GetNextCard() should remove 1 card from the deck");
        }

        [TestCase(25)]
        [ExpectedException(typeof(InternalGameException))]
        public void GetNextCardShouldThrowAnInternalGameExceptionWhenThereAreNoCardsLeftInTheDeck(int cardsToBeDrawn)
        {
            Deck testDeck = new Deck();
            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                testDeck.GetNextCard();
            }
        }

        [Test]
        public void ChangeTrumpCardShouldChangeTheTrumpCardIfThereAreCardsLeftInTheDeck()
        {
            Deck testDeck = new Deck();
            Card initialTrumpCard = testDeck.GetTrumpCard;
            Card newCard = testDeck.GetNextCard();
            testDeck.ChangeTrumpCard(newCard);
            Assert.AreNotSame(initialTrumpCard, testDeck.GetTrumpCard);
        }

        [TestCase(24)]
        public void ChangeTrumpCardShouldNotChangeTheTrumpCardIfThereAreNoCardsLeftInTheDeck(int cardsToBeDrawn)
        {
            Deck testDeck = new Deck();
            Card initialTrumpCard = testDeck.GetTrumpCard;
            Card newCard = new Card(CardSuit.Spade, CardType.Ace);
            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                if (i == cardsToBeDrawn - 1)
                {
                    newCard = testDeck.GetNextCard();
                }
                else
                {
                    testDeck.GetNextCard();
                }
            }

            testDeck.ChangeTrumpCard(newCard);

            Assert.AreEqual(0, testDeck.CardsLeft, "There should be no cards left in the deck after drawing 24 cards");
            Assert.AreSame(initialTrumpCard, testDeck.GetTrumpCard, "ChangeTrumpCard should not change the trump card when there are no cards left in the deck");
        }
    }
}
