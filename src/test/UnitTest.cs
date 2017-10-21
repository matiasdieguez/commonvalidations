using CommonValidations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.IsFalse(Validations.BePhoneNumber("lgaskg88222"));
            Assert.IsTrue(Validations.BePhoneNumber("+541127281111"));

            Assert.IsFalse(Validations.BeStrongPassword("1234"));
            Assert.IsTrue(Validations.BeStrongPassword("j28AM$22"));

            Assert.IsFalse(Validations.BeValidUserName("a 3ad us3rname"));
            Assert.IsTrue(Validations.BeValidUserName("goodname"));
        }
    }
}
