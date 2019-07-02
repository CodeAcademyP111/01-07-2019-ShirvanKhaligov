using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Seat
    {
        public static  int ID;
       
        public int Row { get; set; }

        public int Col { get; set; }
        public Person personseat;


        public Seat(int row,int col,Person person)
        {
            Row = row;
            Col = col;
            personseat = person;
            
        }

    }
}
