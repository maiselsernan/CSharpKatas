namespace CSharpKatas.Tests
{
    [TestClass()]
    public class DigitalRootTests
    {
        [TestMethod()]
        public void CalculateDigitalRootTest()
        {
            //arrange
            var digitalRoot = new DigitalRoot();
            //act
            var result = digitalRoot.CalculateDigitalRoot(16);
            //assert
            Assert.AreEqual(7, result);
            
        }
    }
}
