using System;
namespace Daycare.Models
{
    public class Children
    {
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public DateTime Date_Of_Birth { get; set; }

        public string Gender { get; set; }

        public Children(string first_name, string last_name, DateTime date_of_birth, string gender)
        {
            First_Name = first_name;
            Last_Name = last_name;
            Date_Of_Birth = date_of_birth;
            Gender = gender;
        }
    }
}

