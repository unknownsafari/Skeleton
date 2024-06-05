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
        public clsStaff ThisStaff { get; set; }

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
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId "]);
                AnStaff.CountyCode = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyCode "]);
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
            throw new NotImplementedException();
        }
        private class clsStaffcollection
        {
            List<clsStaff> mStaffList = new List<clsStaff>();
            clsStaff mThisStaff = new clsStaff();
        }
    }  
}