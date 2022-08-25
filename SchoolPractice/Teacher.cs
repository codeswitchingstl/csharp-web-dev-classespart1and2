using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsInTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, int years)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsInTeaching = years;
        }
    }
}
