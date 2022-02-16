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
        public void WhenGameHasOneRollsWithFivePinsEachThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(5);
            Assert.AreEqual(10, game.totalScore());
        }


        [Test]
        public void WhenGameHasFourRollsWithDifferentPinsThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(2);
            game.Roll(4);
            game.Roll(4);
            Assert.AreEqual(15, game.totalScore());
        }
        
        [Test]
        public void WhenGameHasTwentyRollsWithTwoPinsEachThenCalculateScore()
        {
            Game game = new Game();
            for(int i=1; i<=20; i++)
                game.Roll(2);
            Assert.AreEqual(40, game.totalScore());
        }
    }
}