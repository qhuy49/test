using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testAPI.Models
{
    public class Employee
    {
        public static List<Employee> Employees = new List<Employee>() {
            new Employee() {name="HUY",age = "18", birthday="04/09",cmnd="272558911",sdt="0963105785",email="QHUYLK49@GMAIL.COM" },
            new Employee() {name="TRỌNG",age = "19", birthday="04/09",cmnd="272558912",sdt="0963105785",email="QHUYLK50@GMAIL.COM" },
            new Employee() {name="TÂM",age = "20", birthday="04/09",cmnd="272558913",sdt="0963105785",email="QHUYLK475@GMAIL.COM" },
            new Employee() {name="SƠN",age = "21", birthday="04/09",cmnd="272558914",sdt="0963105785",email="QHUYLK479@GMAIL.COM" },
            new Employee() {name="LỢI",age = "12", birthday="04/09",cmnd="272558916",sdt="0963105785",email="QHUYLK489@GMAIL.COM" },
        };
        public string name { get; set; }
        public string age { get; set; }
        public string birthday { get; set; }
        public string cmnd { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
    }
}