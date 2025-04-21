using DesignPattern.code.Prototype_Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Prototype_Pattern
{
    public class PrototypePattern
    {
        public void Demo()
        {
            Student raj = new Student(1, "raj", "ECE");
            Student ram = (Student) raj.clone();

            Console.WriteLine(raj.ToString() + raj.GetHashCode());
            Console.WriteLine(ram.ToString() + ram.GetHashCode());
        }
    }
}
