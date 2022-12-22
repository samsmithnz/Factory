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

        //Assert
        Assert.IsNotNull(class1);
    }
}