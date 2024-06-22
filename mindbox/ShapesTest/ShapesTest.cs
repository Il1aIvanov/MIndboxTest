using Microsoft.VisualStudio.TestTools.UnitTesting;
using mindbox.Shapes;
namespace ShapesTest;

[TestClass]
public class ShapesTest
{
    [TestMethod]
    public void TestCreateCircle()
    {
        Circle circle = new Circle(6);
        Assert.AreEqual(6, circle.Radius);
    }

    [TestMethod]
    public void TestCreateWrongCircle()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
    }

    [TestMethod]
    public void TestGetAreaOfCircle()
    {
        Circle circle = new Circle(5);
        float expected = (float)(Math.PI * Math.Pow(5, 2));
        float area = circle.GetArea();
        Assert.AreEqual(expected, area);
    }

    [TestMethod]
    public void TestCreateTriangle()
    {
        Triangle triangle = new Triangle(10, 10, 10);
        Assert.AreEqual(10, triangle.SideA);
        Assert.AreEqual(10, triangle.SideB);
        Assert.AreEqual(10, triangle.SideC);
    }

    [TestMethod]
    public void TestCreateWrongTriangleSideOutOfRange()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(10, 10, 0));
    }

    [TestMethod]
    public void TestCreateWrongTriangleDoesNotExist()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 2, 20));
    }

    [TestMethod]
    public void TestGetAreaOfTriangle()
    {
        Triangle triangle = new Triangle(10, 10, 10);
        float expected = 43.30127018922193f;
        float area = triangle.GetArea();
        Assert.AreEqual(expected, area);
    }

    [TestMethod]
    public void TestTriangleIsRight()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRight());
    }

    [TestMethod]
    public void TestTriangleIsNotRight()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        Assert.IsFalse(triangle.IsRight());
    }
}