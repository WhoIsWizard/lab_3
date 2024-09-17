using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Passport_document
    {
        public string ID;
        public string Name;
        public string Surname;
        public string Date_Of_Birth;
        public string Nationality;
        public bool sex;                        // True for man,   False for woman
        public string Date_Of_Issue;
        public string Date_Of_expire;
        public string Individual_tax_number;

        public int Passport_Expired_in()
        {
            DateTime expireDate = DateTime.Parse(Date_Of_expire);
            DateTime currentDate = DateTime.Now;

            // Calculate full years between the current date and expiration date
            int years = (expireDate.Year - currentDate.Year);

            // Adjust if expiration date hasn't occurred yet this year
            if (expireDate < currentDate.AddYears(years))
            {
                years--;
            }

            return years;
        }


    }
}
