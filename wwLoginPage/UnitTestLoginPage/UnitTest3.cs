using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLoginPage
{
    [TestClass]
    //for testing the functionality of checking if password is empty or not
    public class UnitTest3
    {
        string password;
        UserData userData = new UserData();
        [TestMethod]
        public void TestMethod1()
        {
            //test invalid input with an empty password 
            password = "";
            //expected outputs
            Boolean expectedReturn = false;
            //actual outputs
            Boolean actualReturn = userData.IfPasswordNotBlank(password);
            //verify the result of invalid input;
            Assert.AreEqual(expectedReturn, actualReturn);

            //test valid input with a not empty password 
            password = "ww1234";
            //expected outputs
            expectedReturn = true;
            //actual outputs
            actualReturn = userData.IfPasswordNotBlank(password);
            //verify the result of valid input;
            Assert.AreEqual(expectedReturn, actualReturn);
        }
    }
}
