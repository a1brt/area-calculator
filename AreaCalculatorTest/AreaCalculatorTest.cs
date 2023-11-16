namespace AreaCalculatorTest
{
    [TestClass]
    public class AreaCalculatorTest
    {
        AreaCalclulator calclulator = new AreaCalclulator();

        [TestMethod]
        public void TestValidCircleArea()
        {
            Circle c = new Circle(2);
            Assert.AreEqual(12.566370614359172, calclulator.CalculateArea(c));
        }

        [TestMethod]
        public void TestInvalidCircleArea1()
        {
            Assert.ThrowsException<ArgumentException>( delegate { new Circle(0); ; } );
        }

        [TestMethod]
        public void TestInvalidCircleArea2()
        {
            Assert.ThrowsException<ArgumentException>(delegate { new Circle(-1); });
        }

        [TestMethod]
        public void TestvalidTiangleArea()
        {
            Triangle t = new Triangle(3,4,5);
            Assert.AreEqual(6, calclulator.CalculateArea(t));
        }

        [TestMethod]
        public void TestInvalidTiangleArea1()
        {
            Assert.ThrowsException<ArgumentException>(delegate { new Triangle(0, 4, 5); });
        }

        [TestMethod]
        public void TestInvalidTiangleArea2() 
        {
            Assert.ThrowsException<ArgumentException>(delegate { new Triangle(-1, 4, 5); });
        }

        [TestMethod]
        public void TestInvalidTiangleArea3()
        {
            Assert.ThrowsException<ArgumentException>(delegate { new Triangle(1, 4, 6); });
        }

        [TestMethod]
        public void TestRightAngleTiangle()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.IsTrue(t.IsRightAngled());
        }

        [TestMethod]
        public void TestNotRightAngleTiangle()
        {
            Triangle t = new Triangle(2, 4, 5);
            Assert.IsFalse(t.IsRightAngled());
        }
    }
}