using System;
using Xunit;

namespace BinaryChop.Tests
{
    public class BinaryChopTests
    {
        [Fact]
        public void ZeroLengthArray()
        {
            // Arrange
            int[] empty = Array.Empty<int>();

            // Act/Assert
            Assert.Equal(-1, empty.Chop(3));
        }

        [Fact]
        public void OneLengthArray()
        {
            // Arrange
            int[] array1 = new[] { 1 };

            // Act/Assert
            Assert.Equal(-1, array1.Chop(3));
            Assert.Equal(0, array1.Chop(1));
        }

        [Fact]
        public void ThreeLengthArray()
        {
            // Arrange
            int[] array3 = new[] { 1, 3, 5 };

            // Act/Asset
            Assert.Equal(0, array3.Chop(1));
            Assert.Equal(1, array3.Chop(3));
            Assert.Equal(2, array3.Chop(5));
            Assert.Equal(-1, array3.Chop(0));
            Assert.Equal(-1, array3.Chop(2));
            Assert.Equal(-1, array3.Chop(4));
            Assert.Equal(-1, array3.Chop(6));
        }

        [Fact]
        public void FourLengthArray()
        {
            // Arrange
            int[] array4 = new[] { 1, 3, 5, 7 };

            // Act/Asset
            Assert.Equal(0, array4.Chop(1));
            Assert.Equal(1, array4.Chop(3));
            Assert.Equal(2, array4.Chop(5));
            Assert.Equal(3, array4.Chop(7));
            Assert.Equal(-1, array4.Chop(0));
            Assert.Equal(-1, array4.Chop(2));
            Assert.Equal(-1, array4.Chop(4));
            Assert.Equal(-1, array4.Chop(6));
            Assert.Equal(-1, array4.Chop(8));
        }
    }
}
