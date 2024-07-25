using BeeChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeChallengeTest
{
    public class DroneBeeTests
    {
        [Test]
        public void Health_ShouldBe100_WhenCreated()
        {
            //arrange
            var dBee = new DroneBee();

            //act

            //assert
            Assert.AreEqual(100, dBee.Health);
        }

        [Test]
        public void Dead_ShouldBeFalse_WhenCreated()
        {
            var dBee = new DroneBee();

            //assert
            Assert.IsFalse(dBee.Dead);
        }

        [Test]
        [TestCase(110)]
        public void Damage_ShouldNotChangeHealth_WhenDamageOutOfRange(int Damage)
        {
            //arrange
            var dbee = new DroneBee();
            var initHealth = dbee.Health;

            //act
            dbee.Damage(Damage);

            Assert.AreEqual(initHealth, dbee.Health);
        }

        [Test]
        [TestCase(8, 92)]
        [TestCase(25, 75)]
        public void Damage_ShouldReduceHealt_WhenDamaIsInRange(int attack, double expectedHealth)
        {
            //arrange
            var dbee = new DroneBee();
            //act
            dbee.Damage(attack);
            //assert
            Assert.AreEqual(dbee.Health, expectedHealth,1);
        }


        [Test]
        [TestCase(60)]
        public void IsDead_ShouldBeTrue_WhenHealthIsBelow50(int attack)
        {
            //arrange
             var bee=new DroneBee();

            //act
            bee.Damage(attack);
          
            //assert
            Assert.IsTrue(bee.IsDead());
        }


        [Test]
        [TestCase(35)]
        public void IsDead_ShouldBeFalse_WhenHealthIsAbove50(int attack)
        {
            //arrange
            var bee=new DroneBee();

            //act
            bee.Damage(attack);

            //assert
            Assert.IsFalse(bee.IsDead());
        }

    }
}
