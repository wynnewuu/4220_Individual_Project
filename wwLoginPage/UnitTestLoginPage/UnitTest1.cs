using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLoginPage
{

    [TestClass]
    //for testing the functionality of checking if username and password are correct
    public class UnitTest1
    {
        UserData userData = new UserData();
        string inputName, inputPassword;
        int actualUserId;
        [TestMethod]
        public void TestMethod1()
        {
            //test valid inputs with right username and password
            inputName = "wynnewu";
            inputPassword = "ww1234";
            //expected outputs
            Boolean expectedReturn = true;
            int expectedUserId = 1;
            //actual outputs
            Boolean actualReturn = userData.Login(inputName,inputPassword);
            actualUserId = userData.UserID;

            //verify the results of valid inputs;
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

            //test valid inputs with wrong username and password
            inputName = "wynnewu";
            inputPassword = "ww1234";
            //expected outputs
            expectedReturn = false;
            expectedUserId = -1;
            //actual outputs
            actualReturn = userData.Login(inputName, inputPassword);
            actualUserId = userData.UserID;

            //verify the results of invalid inputs;
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        

    }
}
