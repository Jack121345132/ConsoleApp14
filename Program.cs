using System;
using System.Threading;

namespace ConsoleApp14 {
    class Program {
        static void Main(string[] args) {
            Car c1 = new Car("Audi", "RS6", "Black", 2022, "Petrol", "73L", "ABC 12R", 10, 0);
            c1.PrintCarInfo();
            Car c2 = new Car("BMW", "Q5", "White", 2023, "Petrol", "120L", "UBD 39B", 8, 0);
            c2.PrintCarInfo();
            Car c3 = new Car("Toyota", "MK4", "Silver", 2002, "Petrol", "50L", "POS 93A", 9, 0);
            c3.PrintCarInfo();
            Car c4 = new Car("Volvo", "240", "Blue", 1984, "Whiskey and butter", "4L", "AAA 666", 4, 0);
            c4.PrintCarInfo();

            Console.WriteLine("Enter för att racea");
            Console.ReadLine();

            void Race() {
                while (c1._distance_traveled < 100 && c2._distance_traveled < 100 && c3._distance_traveled < 100 && c4._distance_traveled < 100) {
                    c1.DoAction();
                    c2.DoAction();
                    c3.DoAction();
                    c4.DoAction();

                    Console.Clear();
                    Console.SetCursorPosition(c1._distance_traveled, 0);
                    Console.Write("bil");
                    Console.SetCursorPosition(c2._distance_traveled, 1);
                    Console.Write("bil");
                    Console.SetCursorPosition(c3._distance_traveled, 2);
                    Console.Write("bil");
                    Console.SetCursorPosition(c4._distance_traveled, 3);
                    Console.Write("bil");

                    Console.SetCursorPosition(100, 0);
                    Console.Write("|");
                    Console.SetCursorPosition(100, 1);
                    Console.Write("|");
                    Console.SetCursorPosition(100, 2);
                    Console.Write("|");
                    Console.SetCursorPosition(100, 3);
                    Console.Write("|");
                    Console.SetCursorPosition(100, 4);
                    Console.Write("|");

                    Thread.Sleep(200);
                }                
            }
            Race();
            // av någon anledning funkar det utanför loopen
            Console.SetCursorPosition(0, 6);
            Console.Write("någon vann");

            Console.ReadLine();
        }
    }
}
