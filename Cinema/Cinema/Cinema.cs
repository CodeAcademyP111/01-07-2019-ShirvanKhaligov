using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        private static int ID;
        private int uniqueId;


        public string Name { get; set; }

        public string Address { get; set; }

        public Hall[] halls;

        public Cinema (string name, string address)
        {
            ID++;
            uniqueId = ID;
            Name = name;
            Address = address;
        }
    }
}
