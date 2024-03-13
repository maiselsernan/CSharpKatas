namespace CSharpKatas.Test
{
    [TestClass]
    public class ToCamelCaseKataTest
    {
        [TestMethod]
        public void ToCamelCaseTest()
        {
            Assert.AreEqual("theStealthWarrior", ToCamelCaseKata.ToCamelCase("the_stealth_warrior"),
                "ToCamelCaseKata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", ToCamelCaseKata.ToCamelCase("The-Stealth-Warrior"),
                "ToCamelCaseKata.ToCamelCase('The-Stealth-Warrior') did not return correct value");

        }
    }
}