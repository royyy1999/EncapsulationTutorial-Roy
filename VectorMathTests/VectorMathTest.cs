using System;
using Xunit;
using VectorLibrary;

namespace VectorExercisesTest
{
    public class VectorMathTest
    {
        [Theory]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(1.0, 5.0, 7.0)]
        [InlineData(-3.0, 12.343553, 8.0)]
        public void ConstructingAVectorSetsState(double x, double y, double z)
        {
            Vector3 v = new Vector3(x, y, z);
            Assert.Equal(x, v.X);
            Assert.Equal(y, v.Y);
            Assert.Equal(z, v.Z);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 6.0, 7.0, 8.6)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, 2.0, -4.0, -1.5)]
        public void AddReturnsVectorSum(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            Vector3 c = VectorMath.Add(a, b);
            Assert.Equal(cx, c.X);
            Assert.Equal(cy, c.Y);
            Assert.Equal(cz, c.Z);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 4.0, 3.0, 2.0)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -8.0, 0.0, -1.5)]
        public void SubtractReturnsVectorDifference(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            Vector3 c = VectorMath.Subtract(a, b);
            Assert.Equal(cx, c.X);
            Assert.Equal(cy, c.Y);
            Assert.Equal(cz, c.Z);
        }


        [Theory]
        [InlineData(0.0, 0.0, 0.0, 25.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 5.0, 5.0, 5.3)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -15.0, -10.0, -7.5)]
        [InlineData(2.3, 0.0, -3.5, -2.0, -4.6, 0.0, 7.0)]
        [InlineData(4.0, 8.0, -6.0, 0.5, 2.0, 4.0, -3.0)]
        public void ScaleReturnsScaledVector(double ax, double ay, double az, double scalar, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 c = VectorMath.Scale(a, scalar);
            Assert.Equal(cx, c.X, 12);
            Assert.Equal(cy, c.Y, 12);
            Assert.Equal(cz, c.Z, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.2, 31.96)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -11)]
        public void DotProductReturnsDotProduct(double ax, double ay, double az, double bx, double by, double bz, double actualProduct)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            double computedProduct = VectorMath.DotProduct(a, b);
            Assert.Equal(actualProduct, computedProduct, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 5.9, -11.2, 5)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -3, -7.5, 16)]
        public void CrossProductReturnsCrossProduct(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            Vector3 c = VectorMath.CrossProduct(a, b);
            Assert.Equal(cx, c.X, 12);
            Assert.Equal(cy, c.Y, 12);
            Assert.Equal(cz, c.Z, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        [InlineData(0.0, 1.0, 0.0, 1.0)]
        [InlineData(5.0, 3.6, 2.7, 6.72681202353685)]
        [InlineData(2.0, -2.0, 0.0, 2.82842712474619)]
        [InlineData(1.5, 1.5, 1.5, 2.598076211353316)]
        public void MagnitudeReturnsVectorMagnitude(double ax, double ay, double az, double actualMagnitude)
        {
            Vector3 a = new Vector3(ax, ay, az);
            double calculatedMagnitude = VectorMath.Magnitude(a);
            Assert.Equal(actualMagnitude, calculatedMagnitude, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, double.NaN, double.NaN, double.NaN)]
        [InlineData(0.0, 1.0, 0.0, 0.0, 1.0, 0.0)]
        [InlineData(5.0, 3.6, 2.7, 0.743294146247166, 0.53517178529796, 0.40137883897347)]
        [InlineData(2.0, -2.0, 0.0, 0.707106781186547, -0.707106781186547, 0)]
        [InlineData(1.5, 1.5, 1.5, 0.577350269189626, 0.577350269189626, 0.577350269189626)]
        public void NormalizeReturnsNormalizedVector(double ax, double ay, double az, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 c = VectorMath.Normalize(a);
            Assert.Equal(cx, c.X, 12);
            Assert.Equal(cy, c.Y, 12);
            Assert.Equal(cz, c.Z, 12);
        }
    }
}
