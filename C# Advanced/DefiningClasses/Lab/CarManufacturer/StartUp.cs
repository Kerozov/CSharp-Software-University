﻿using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
