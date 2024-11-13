using System;
namespace uppgift3_3
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar ska du hyra bilen?");
            int timmar =int.Parse(Console.ReadLine());
            int totalt = timmar * 80 + 950;
            Console.WriteLine("Det kommer att kosta" +  totalt );
        }
    }
}
