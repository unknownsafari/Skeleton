using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    internal class tststaffCollection
    {
        public void IstanceOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.IsNotNull(AllStaffs);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.CountyCode = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.HouseNo = "21B";
            TestItem.PostCode = "LE2 7DN";
            TestItem.Street = "some street";
            TestItem.Town = "Leicester";
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.Active = true;
            TestStaff.StaffId = 1;
            TestStaff.CountyCode = 1;
            TestStaff.DateAdded = DateTime.Now;
            TestStaff.HouseNo = "21B";
            TestStaff.PostCode = "LE2 7DN";
            TestStaff.Street = "some street";
            TestStaff.Town = "Leicester";
            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.CountyCode = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.HouseNo = "21B";
            TestItem.PostCode = "LE2 7DN";
            TestItem.Street = "some street";
            TestItem.Town = "Leicester";
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs. Count, TestList.Count);

        }
        //P13a
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.CountyCode = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.HouseNo = "28";
            TestItem.PostCode = "LE83RT";
            TestItem.Street = "Ar Road";
            TestItem.Town = "Leicester";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        //13b
        [TestMethod]
        public void UpdateMthodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimartKey = 0;
            TestItem.Active = true;
            TestItem.CountyCode= 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.HouseNo = "21b";
            TestItem.PostCode = "LE1 4AB";
            TestItem.Street = "Some Street";
            TestItem.Town = "Leicester";
            AllStaffs.ThisStaff = TestItem;
            PrimartKey = AllStaffs.Add();
            TestItem.StaffId= PrimartKey;
            TestItem.Active = false;
            TestItem.CountyCode= 3;
            TestItem.DateAdded = DateTime.Now;
            TestItem.HouseNo = "123b";
            TestItem.PostCode = "LE2 7DN";
            TestItem.Street = "some Street";
            TestItem.Town = "Liverpool";
            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimartKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        //14a
        [TestMethod]
        public void DeleteMthodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimartKey = 0;
            TestItem.Active = true;
            TestItem.CountyCode = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.HouseNo = "21b";
            TestItem.PostCode = "LE1 4AB";
            TestItem.Street = "Some Street";
            TestItem.Town = "Leicester";
            AllStaffs.ThisStaff = TestItem;
            PrimartKey = AllStaffs.Add();
            TestItem.StaffId = PrimartKey;
            AllStaffs.ThisStaff.Find(PrimartKey);
            AllStaffs.Delete();
            Boolean Found = AllStaffs.ThisStaff.Find(PrimartKey);
            Assert.IsFalse(Found);
        }

    }
}
