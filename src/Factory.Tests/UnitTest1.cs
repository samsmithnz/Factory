namespace Factory.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        Class1 class1 = new();

        //Act
        class1.HelloWorld();

        //Assert
        Assert.IsNotNull(class1);
    }
}