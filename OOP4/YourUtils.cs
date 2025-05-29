using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Reuse_OOP2
{
    public static class YourUtils
    {
        public static int Tuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year;
        }

        public static Boolean CheckMonthBirthday(this Employee emp) 
        {
            Boolean Check = false;
            if (DateTime.Now.Month == emp.Birthday.Month) {
                Check = true;
            }
            return Check;
        }
    }
}
