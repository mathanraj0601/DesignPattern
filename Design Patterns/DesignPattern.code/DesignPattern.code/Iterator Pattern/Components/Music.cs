using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Iterator_Pattern.Components
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Music(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Music ID : {Id} and Name : {Name}";
        }
    }
}
