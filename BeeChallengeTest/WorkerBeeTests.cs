using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeChallenge;
namespace BeeChallengeTest
{

    public class WorkerBeeTests
    {

        [Test]
        public void Health_ShouldBe100_WhenBeeIsCreated()
        {
            // Arrange
            var bee = new WorkerBee();

            // Act

            // Assert
            Assert.AreEqual(100.00, bee.Health);
        }

        [Test]
        public void Dead_ShouldBeFalse_WhenBeeIsCreated()
        {
            // Arrange
            var bee = new WorkerBee();

            // Act

            // Assert
            Assert.False(bee.Dead);
        }

        [Test]
        [TestCase(0)]
        [TestCase(100)]
        public void Damage_ShouldNotChangeHealth_WhenAttackIsOutOfRange(int attack)
        {
            // Arrange
            var bee = new WorkerBee();
            var initialHealth = bee.Health;

            // Act
            bee.Damage(attack);

            // Assert
            Assert.AreEqual(initialHealth, bee.Health);
        }

        [Test]
        [Theory]
        [TestCase(10, 90.00)]
        [TestCase(50, 50.00)]
        public void Damage_ShouldReduceHealth_WhenAttackIsInRange(int attack, double expectedHealth)
        {
            // Arrange
            var bee = new WorkerBee();

            // Act
            bee.Damage(attack);

            // Assert
            Assert.AreEqual(expectedHealth, bee.Health, 2); // Allowing a small tolerance in comparison
        }

        [Test]
        public void IsDead_ShouldSetDeadToTrue_WhenHealthIsBelow70()
        {
            // Arrange
            var bee = new WorkerBee();
            bee.Damage(50); // This should bring health below 70

            // Assert
            Assert.True(bee.IsDead());
        }

        [Test]
        public void IsDead_ShouldNotSetDeadToTrue_WhenHealthIsAbove70()
        {
            // Arrange
            var bee = new WorkerBee();
            bee.Damage(20); // This should keep health above 70

            // Assert
            Assert.False(bee.IsDead());
        }
    }

}
