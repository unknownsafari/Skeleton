using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }
        public clsStaff ThisStaff 
        { get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaff mThisStaff { get; private set; }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount) 
            {
               clsStaff AnStaff = new clsStaff();
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.CountyCode = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyCode"]);
                AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStaff.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnStaff.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AnStaff.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                mStaffList.Add(AnStaff);
                Index++;

            }

           
        }

        public int Add()
        {
          clsDataConnection DB=new clsDataConnection();
            DB.AddParameter("@HouseNo", mThisStaff.HouseNo);
            DB.AddParameter("@Street",mThisStaff.Street);
            DB.AddParameter("@Town", mThisStaff.Town);
            DB.AddParameter("@PostCode",mThisStaff.PostCode);
            DB.AddParameter("@CountyCode", mThisStaff.CountyCode);
            DB.AddParameter("@DateAdded",mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId",mThisStaff.StaffId);
            DB.AddParameter("@HouseNo", mThisStaff.HouseNo);
            DB.AddParameter("@Street", mThisStaff.Street);
            DB.AddParameter("@Town", mThisStaff.Town);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@CountyCode", mThisStaff.CountyCode);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active",ThisStaff.Active);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public bool FindUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        private class clsStaffcollection
        {
            List<clsStaff> mStaffList = new List<clsStaff>();
            clsStaff mThisStaff = new clsStaff();
        }
    }  
}