using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameCoC;

namespace GameTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Should_Defense_Win()
        {
            var barbarian = new Fighter(45,8);
            var cannon = new Fighter(390, 10);
            var game = new Game();
            game.Defense.Add(cannon);
            game.Invader.Add(barbarian);
            var winner = game.Start();
            Assert.AreEqual(Winner.Defense, winner);

        }

        [TestMethod]
        public void Should_Attack_Win()
        {
            var cannon = new Fighter(390, 10);
            var game = new Game();
            game.Defense.Add(cannon);
            for (int i = 1; i <= 10; i++)
            {
                var barbarian = new Fighter(45, 8);
                game.Invader.Add(barbarian);
            }
            var winner = game.Start();
            Assert.AreEqual(Winner.Attack, winner);

        }
    }
}
