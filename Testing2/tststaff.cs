using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tststaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);

        }
    }
}
