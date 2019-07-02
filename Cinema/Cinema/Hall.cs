using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Hall
    {
        public static int ID;
        
        public string Name { get; set; }

        public float Price { get; set; }

        public Seat[,] seats;

        public Hall(string name, float price)
        {
            Name = name;
            Price = price;
            seats = new Seat[13, 12];

        }
        public void AddPerson(Seat seat)
        {
            if (seat.personseat.Money>= Price && seats[seat.Row,seat.Col]==null)
            {
                seats[seat.Row, seat.Col] = seat;
                Console.WriteLine($"Welcome");
            }

            else 
            {
                Console.WriteLine($"sorry not found");
            }

        }
        public string Empty()
        {
            int count = 0;
            foreach (var item in seats)
            {
                if (item == null)
                    count++;
            }

            return $"{count} bos yerimiz var";
        }
    }
}

