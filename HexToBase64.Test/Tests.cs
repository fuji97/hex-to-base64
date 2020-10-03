using NUnit.Framework;

namespace HexToBase64.Test {
    public class Tests {
        private const string Result = "ShtI1zIjlKeDJs0oPwg0CT5lQhp+mOkOW0UtFgtdB9g=";
        
        [Test]
        public void TestResult() {
            Assert.AreEqual(Result, Converter.CovertToBase64());
        }
    }
}