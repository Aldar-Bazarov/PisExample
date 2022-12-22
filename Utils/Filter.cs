using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisFirst.Utils
{
    public class Filter
    {
        public static Filter CreateInstance()
        {
            return new Filter();
        }

    
        public DateTime MinRecordDate { get; set; }
        public DateTime MaxRecordDate { get; set; }
        public int RegCardID { get; set; }
        public int ApplicantCategoryID { get; set; }
        public int MunDistrID { get; set; }
        public int AnimalCategoryID { get; set; }
        public int UrgencyTypeID { get; set; }
        public int OrganizationID { get; set; }
        public int StatusID { get; set; }


    }
}
