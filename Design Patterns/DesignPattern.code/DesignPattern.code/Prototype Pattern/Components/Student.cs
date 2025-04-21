using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Prototype_Pattern.Components
{
    public class Student : IPrototype
    {
        private int RollNumber { get; set; }
        private string Name { get; set; }
        private string Department { get; set; }

        public Student(int rollNumber, string name, string department)
        {
            RollNumber = rollNumber;
            Name = name;
            Department = department;
        }

        public override string ToString()
        {
            return $" Roll number : {RollNumber}, Name : {Name}, Department :{Department}";
        }
        public object clone()
        {
            return new Student(this.RollNumber, this.Name, this.Department);
        }
    }
}
