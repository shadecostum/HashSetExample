using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{
    internal class Coustumer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Coustumer(int id,string name) 
        {
            Id = id;
            Name = name;
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public override bool Equals(object? obj)
        {
            Coustumer coustumer = obj as Coustumer;
            return coustumer.Id==Id;
        }
        public override string ToString()
        {
            return $"{Id} , {Name}";
        }
    }
}
