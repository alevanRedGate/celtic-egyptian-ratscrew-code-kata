﻿using CelticEgyptianRatscrewKata.GameSetup;
using CelticEgyptianRatscrewKata.SnapRules;

namespace CelticEgyptianRatscrewKata.Game
{
    public class GameFactory
    {
        public GameController Create()
        {
            IRule[] rules =
            {
                new DarkQueenSnapRule(),
                new SandwichSnapRule(),
                new StandardSnapRule(),
            };
            return new GameController(new GameState(), new SnapValidator(rules), new Dealer(), new Shuffler());
        }

        public static Cards CreateFullDeckOfCards()
        {
            return Cards.With(
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
                new Card(Suit.Clubs, Rank.Three),
                new Card(Suit.Clubs, Rank.Four),
                new Card(Suit.Clubs, Rank.Five),
                new Card(Suit.Clubs, Rank.Six),
                new Card(Suit.Clubs, Rank.Seven),
                new Card(Suit.Clubs, Rank.Eight),
                new Card(Suit.Clubs, Rank.Nine),
                new Card(Suit.Clubs, Rank.Ten),
                new Card(Suit.Clubs, Rank.Jack),
                new Card(Suit.Clubs, Rank.Queen),
                new Card(Suit.Clubs, Rank.King),
                
                new Card(Suit.Diamonds, Rank.Ace),
                new Card(Suit.Diamonds, Rank.Two),
                new Card(Suit.Diamonds, Rank.Three),
                new Card(Suit.Diamonds, Rank.Four),
                new Card(Suit.Diamonds, Rank.Five),
                new Card(Suit.Diamonds, Rank.Six),
                new Card(Suit.Diamonds, Rank.Seven),
                new Card(Suit.Diamonds, Rank.Eight),
                new Card(Suit.Diamonds, Rank.Nine),
                new Card(Suit.Diamonds, Rank.Ten),
                new Card(Suit.Diamonds, Rank.Jack),
                new Card(Suit.Diamonds, Rank.Queen),
                new Card(Suit.Diamonds, Rank.King),
                
                new Card(Suit.Hearts, Rank.Ace),
                new Card(Suit.Hearts, Rank.Two),
                new Card(Suit.Hearts, Rank.Three),
                new Card(Suit.Hearts, Rank.Four),
                new Card(Suit.Hearts, Rank.Five),
                new Card(Suit.Hearts, Rank.Six),
                new Card(Suit.Hearts, Rank.Seven),
                new Card(Suit.Hearts, Rank.Eight),
                new Card(Suit.Hearts, Rank.Nine),
                new Card(Suit.Hearts, Rank.Ten),
                new Card(Suit.Hearts, Rank.Jack),
                new Card(Suit.Hearts, Rank.Queen),
                new Card(Suit.Hearts, Rank.King),
                
                new Card(Suit.Spades, Rank.Ace),
                new Card(Suit.Spades, Rank.Two),
                new Card(Suit.Spades, Rank.Three),
                new Card(Suit.Spades, Rank.Four),
                new Card(Suit.Spades, Rank.Five),
                new Card(Suit.Spades, Rank.Six),
                new Card(Suit.Spades, Rank.Seven),
                new Card(Suit.Spades, Rank.Eight),
                new Card(Suit.Spades, Rank.Nine),
                new Card(Suit.Spades, Rank.Ten),
                new Card(Suit.Spades, Rank.Jack),
                new Card(Suit.Spades, Rank.Queen),
                new Card(Suit.Spades, Rank.King)
                );
        }
    }
}