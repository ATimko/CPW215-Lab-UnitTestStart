using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTests
{
    [TestClass]
    public class ValidatorTest
    {
        // SSN
        [TestMethod]
        [DataRow("555-55-5555")]
        [DataRow("555555555")]
        [DataRow("547821693")]
        [DataRow("428-52-1234")]
        public void IsValidSsn_ValidInput_ReturnTrue(string input)
        {
            //Assert.Fail();

            //Returns True                       string is input
            Assert.AreEqual(true, Validator.IsSsn(input));
        }

        [TestMethod]
        [DataRow("A")]
        [DataRow("123-123-123")]
        [DataRow("1234567890")]
        [DataRow("TenLetters")]
        public void IsValidSsn_InvalidInput_ReturnsFalse(string input)
        {
            //Assert.Fail();

            //Returns False                       string is input
            Assert.AreEqual(false, Validator.IsSsn(input));
        }


        // IsWithinRange
        [TestMethod]
        [DataRow(10, 1, 10)] //max boundary
        [DataRow(1, 1, 10)] //min boundary
        [DataRow(5, 1, 10)]
        [DataRow(2000, 0, 50000)]
        public void IsWithinRange_NumInInclusiveRange_ReturnTrue(int test, int min, int max)
        {
            //Assert.Fail();

            //Returns True                                adding the int of test, min and max
            Assert.AreEqual(true, Validator.IsWithinRange(test, min, max));
        }

        [TestMethod]
        [DataRow(4, 5, 10)]
        [DataRow(11, 1, 10)]
        [DataRow(10000, 0, 5000)]
        public void IsWithinRange_NumOutsideInclusiveRange_ReturnsFalse(int test, int min, int max)
        {
            //Assert.Fail();

            //Returns False                               adding the int of test, min and max
            Assert.AreEqual(false, Validator.IsWithinRange(test, min, max));
        }
    }
}
