using NUnit.Framework;
using System;
using Triangle;

namespace TestTriangle
{
    [TestFixture]
    public class TestTriangle
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTriangleForm()
        {
            int side1 = 20;
            int side2 = 40;
            int side3 = 50;

            String expected = "the triangle can be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void TestTrianglenotForm()
        {
            int side1 = 20;
            int side2 = 30;
            int side3 = 50;

            String expected = "The Triangle cannot be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestTriangleEquilateral()
        {
            int side1 = 40;
            int side2 = 40;
            int side3 = 40;

            String expected = "the triangle can be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestTriangleIsosceles()
        {
            int side1 = 40;
            int side2 = 40;
            int side3 = 50;

            String expected = "the triangle can be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestTriangleScalene()
        {
            int side1 = 20;
            int side2 = 50;
            int side3 = 40;

            String expected = "the triangle can be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTrianglezero()
        {
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;

            String expected = "The Triangle cannot be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestTrianglelargevalue()
        {
            int side1 = 300;
            int side2 = 400;
            int side3 = 500;

            String expected = "the triangle can be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTrianglenegative()
        {
            int side1 = -20;
            int side2 = -40;
            int side3 = -50;

            String expected = "The Triangle cannot be form";

            String actual = TriangleSolver.Analyze(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }

        
    }
}