using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser AnUSer = new clsCustomerUser();
            Assert.IsNotNull(AnUSer);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            string TestData = "Nirmal";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            string TestData = "Nirmal69";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            string TestData = "Customer";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Boolean Found = false;
            string UserName = "Nirmal";
            string Password = "Nirmal69";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Nirmal";
            string Password = "Nirmal69";
            Found = AnUser.FindUser(UserName, Password);
            if(AnUser.UserName != UserName && AnUser.Password != Password)
                {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
