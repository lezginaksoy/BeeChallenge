using BeeChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeChallengeTest
{
    public class QueenBeeTests
    {

        [Test]
        public void Health_ShouldBe100_WhenCreatedBee()
        {
            //arrange
            var bee = new QueenBee();


            //assert
            Assert.AreEqual(bee.Health, 100.00);
        }

        [Test]
        public void Dead_ShouldBeFalse_WhenCreatedBee()
        {
            var bee = new QueenBee();


            Assert.IsFalse(bee.Dead);
        }

        [Test]
        [TestCase(0)]
        [TestCase(100)]
        public void Health_ShouldNotBeReduce_WhenAttackIsOutOfRange(int attack)
        {
            //arraneg
            var bee = new QueenBee();

            //act
            bee.Damage(attack);

            //assert
            Assert.AreEqual(100, bee.Health);
        }

        [Test]
        [TestCase(12)]
        [TestCase(56)]
        public void Health_ShouldBeReduced_WhenAttackIsInRange(int attack)
        {
            var bee = new QueenBee();

            //act
            bee.Damage(attack);


            Assert.AreNotEqual(100, bee.Health);
        }

        [Test]
        [TestCase(84)]
        public void Dead_ShouldBeTrue_WhenHealthIsBelow20(int attack)
        {
            var bee = new QueenBee();

            bee.Damage(attack);

            //assert
            Assert.IsTrue(bee.IsDead());
        }


        [Test]
        [TestCase(45)]
        public void Dead_ShouldBeFalse_WhenHealthIsAbove20(int attack)
        {
            var bee = new QueenBee();

            bee.Damage(attack);

            //assert
            Assert.IsFalse(bee.IsDead());
        }


    }
}
