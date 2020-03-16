using System;
using Xunit;

namespace Shapes.Tests
{
    public class UnitTestShapes
    {
        [Fact]
        public void BoxVolumeTest()
        {
            // Arrange 
            Box box = new Box(10);

            // Act
            double volume = box.Volume();

            // Assert
            Assert.Equal( 1000.0, volume, 5);
        }

        [Fact]
        public void BallVolumeTest()
        {
            var ball = new Ball(15.0);

            double volume = ball.Volume();

            Assert.Equal(14137.167, volume, 3);
        }

        [Theory]
        [InlineData(20, 10)]
        public void TestShapeAdding(double containerHeight, double ballRadius)
        {
            var container = new Box(containerHeight);
            var ball = new Ball(ballRadius);

            bool result = container.Add(ball);

            Assert.True(result);
        }
    }
}
