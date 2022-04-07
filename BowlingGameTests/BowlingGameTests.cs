using NUnit.Framework;
using BowlingGame;

namespace BowlingGameTests
{

    public class BowlingGameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenGameHasGutterThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(0);
            game.Roll(0);
            Assert.AreEqual(0, game.TotalScore());
        }
        
        [Test]
        public void WhenGameHasTwoRollsThenCalculateScore()
        {
            Game game = new Game();
             game.Roll(5);
             game.Roll(4);
            Assert.AreEqual(9, game.TotalScore());
        }


        [Test]
        public void WhenGameHasFourRollsWithDifferentPinsThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(2);
            game.Roll(4);
            game.Roll(4);
            Assert.AreEqual(15, game.TotalScore());
        }
        
        [Test]
        public void WhenGameHasTwentyRollsWithTwoPinsEachThenCalculateScore()
        {
            Game game = new Game();
            for(int i=1; i<=20; i++)
                game.Roll(2);
            Assert.AreEqual(40, game.TotalScore());
        }
        
        [Test]
        public void WhenGameHasStrikeRollThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(10);
            game.Roll(2);
            game.Roll(4);
            Assert.AreEqual(22, game.TotalScore());
        }
        
        [Test]
        public void WhenGameHasConsecutiveTwoStrikeRollThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(10);
            game.Roll(10);
            game.Roll(2);
            game.Roll(4);
            Assert.AreEqual(44, game.TotalScore());
        }
        
        [Test]
        public void WhenGameHasSpareThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(5);
            game.Roll(2);
            game.Roll(4);
            Assert.AreEqual(18, game.TotalScore());
        }
    }
}