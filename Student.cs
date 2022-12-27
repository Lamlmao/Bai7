using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai7
{
    public class Student : Person
    {
        private string _id { get; }
        private float _point { get; }
        private string _email { get; }

        public Student(string name, string gender, string address, DateTime birth, string id, float point, string email) : base(name, gender, address, birth)
        {
            _id = id;
            _point = point;
            _email = email;
        }
        public void InputForStudent(string name, string gender, string address, DateTime birth, string id, float point, string email){
            
        }
        public void CheckHoBo()
        {
            if(_point >= 8)
            {
                Console.WriteLine(_name + " co hoc bong");
            }
            else
            {
                Console.WriteLine(_name + " khong co hoc bong");
            }
        }
        public void OutputStudent()
        {
            Console.WriteLine("Thong tin hoc sinh: ");
            Console.WriteLine(_name + " " + GetAge() + " " + _gender + " " + _address + " " + _birth + " " + _id + " " + _point + " " + _email);
        }
    }
}