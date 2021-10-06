using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLoginPage
{
    [TestClass]
    //for testing the functionality of checking password is long enough(at least characters) or not
    public class UnitTest4
    {
        string password;
        UserData userData = new UserData();
        [TestMethod]
        public void TestMethod1()
        {
            //test invalid input with a password with only 4 characters
            password = "abb1";
            //expected outputs
            Boolean expectedReturn = false;
            //actual outputs
            Boolean actualReturn = userData.IfLongEnough(password);
            //verify the result of invalid input;
            Assert.AreEqual(expectedReturn, actualReturn);

            //test valid input with a long enough (6 characters) password
            password = "ww1234";
            //expected outputs
            expectedReturn = true;
            //actual outputs
            actualReturn = userData.IfLongEnough(password);
            //verify the result of valid input;
            Assert.AreEqual(expectedReturn, actualReturn);
        }
    }
}
