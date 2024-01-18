using System;

namespace ConsoleApp14 {
    class Car {
        Random random;
        public string _brand;
        public string _model;
        public string _color;
        public int _year;
        public string _fuel;
        public string _fuel_tank;
        public string _license_plate;
        public int _speed;
        public int _distance_traveled;
        public Car(string brand, string model, string color, int year, string fuel, string fuel_tank, string license_plate, int speed, int distance_traveled) {
            _brand = brand;
            _model = model;
            _color = color;
            _year = year;
            _fuel = fuel;
            _fuel_tank = fuel_tank;
            _license_plate = license_plate;
            _speed = speed;
            _distance_traveled = distance_traveled;
            random = new Random();
        }

        public void PrintCarInfo() {
            Console.WriteLine(
                $"brand: {_brand}\n" +
                $"model: {_model}\n" +
                $"color: {_color}\n" +
                $"year: {_year}\n" +
                $"fuel: {_fuel}\n" +
                $"fuel_tank: {_fuel_tank}\n" +
                $"license_plate: {_license_plate}\n" +
                $"speed: {_speed}\n" +
                $"distance_traveled: {_distance_traveled}\n");
        }
        public void Drive() {
            _distance_traveled += _speed;
        }
        public void Accelerate() {
            if (_speed < 20) {
                _speed += 5;
            }
        }
        public void Break() {
            _speed -= 5;
            if (_speed < 0) {
                _speed = 0;
            }
        }
        public void Horn() {
            Console.Write("Tut tut");
        }
        public void DoAction() {
            int num = random.Next(1, 4);
            switch (num) {
                case 1:
                    Drive();
                    break;
                case 2:
                    Accelerate();
                    break;
                case 3:
                    Break();
                    break;

            }
        }
    }
}
