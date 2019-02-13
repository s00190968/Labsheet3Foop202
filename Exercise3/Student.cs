using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Student
    {
        public string Name { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Student(string name, string snumber, string email, string phone)
        {
            Name = name;
            StudentNumber = snumber;
            Email = email;
            PhoneNumber = phone;
        }
    }
}
