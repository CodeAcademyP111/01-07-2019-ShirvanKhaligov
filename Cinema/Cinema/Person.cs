using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Person
    {
        public string Name { get; set; }
        
        public byte Money { get; set; }

        public string Surname { get; set; }

        public Person(string name, string surname,  byte money)
        {
            Name = name;
            Money = money;
            Surname = surname;
        }
    }
}
