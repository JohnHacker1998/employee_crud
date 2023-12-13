using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        public string Employee_ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Sub_City { get; set; }
        public string Location_Special_Name { get; set; }
        public string Data_Update_Date { get; set; }
        public bool Active_Ind { get; set; }
    }
}
