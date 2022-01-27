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
        public void WhenGameHasOneRollsWithFivePinsThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(2);
            Assert.AreEqual(7, game.totalScore());
        }


        [Test]
        public void WhenGameHasTWoRollsWithFivePinsThenCalculateScore()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(5);
            Assert.AreEqual(10, game.totalScore());
        }
        
    }
}