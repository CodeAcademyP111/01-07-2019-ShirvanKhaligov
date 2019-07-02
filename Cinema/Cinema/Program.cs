using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("zaqulba", "BUZOVNA");
            Hall hall = new Hall("Vip", 20);
            Person sirvan = new Person(360);
            Seat seat1 = new Seat(5,6,sirvan);
            Cinema cinema1 =new Cinema ("Nizami","Semed vurgun");
            hall.AddPerson(seat1);
            Person flankes = new Person(25);
            Seat seat2 = new Seat(10, 11, flankes);
            hall.AddPerson(seat2);
            Console.WriteLine(hall.Empty());
          
        }
    }
}
