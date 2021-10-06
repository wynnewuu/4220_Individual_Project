using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLoginPage
{
    [TestClass]
    //for testing the functionality of checking if username is empty or not
    public class UnitTest2
    {
        string inputName;
        UserData userData = new UserData(); 
        [TestMethod]
        public void TestMethod1()
        {
            //test invalid input with an empty username 
            inputName = "";
            //expected outputs
            Boolean expectedReturn = false;
            //actual outputs
            Boolean actualReturn = userData.IfUserNameNotBlank(inputName);
            //verify the result of invalid input;
            Assert.AreEqual(expectedReturn, actualReturn);

            //test valid input with a not empty username 
            inputName = "wynnewu";
            //expected outputs
            expectedReturn = true;
            //actual outputs
            actualReturn = userData.IfUserNameNotBlank(inputName);
            //verify the result of valid input;
            Assert.AreEqual(expectedReturn, actualReturn);
        }
    }
}
