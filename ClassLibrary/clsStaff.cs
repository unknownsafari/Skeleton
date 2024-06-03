using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public string HouseNo;
        public int StaffID;
        public int CountyCode;
        public string PostCode;
        public string Town;
        public string Street;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }

        public bool Find(int staffId)
        {
            throw new NotImplementedException();
        }
    }
}