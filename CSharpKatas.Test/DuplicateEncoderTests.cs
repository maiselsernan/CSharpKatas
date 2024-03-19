namespace CSharpKatas.Tests
{
    [TestClass()]
    public class DuplicateEncoderTests
    {
        [TestMethod()]
        public void DuplicateEncodeTest()
        {
            Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
            Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
        }
    }
}