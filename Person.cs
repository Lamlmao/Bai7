using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai7
{
    public class Person
    {
        public string _name { get; set; }
        protected string _address { get; set; }
        protected string _gender { get; }
        protected DateTime _birth { get; }
    
        public Person(string name, string gender, string address, DateTime birth)
        {
            _name = name;
            _gender = gender;
            _address = address;
            _birth = birth;
        }
        public int GetAge()
        {
            int age = DateTime.Now.Year - _birth.Year;
            return age;
        }

    }
}