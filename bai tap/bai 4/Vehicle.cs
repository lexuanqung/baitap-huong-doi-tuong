using System;
using System.Collections.Generic;
using System.Text;

namespace bai_4
{
    class Vehicle
    {
        String name, range_of_vehicle;
        long car_deceit;
        double xylanh;

        public Vehicle(string name, string range_of_vehicle, double xylanh, long car_deceit)
        {
            this.name = name;
            this.range_of_vehicle = range_of_vehicle;           
            this.xylanh = xylanh;
            this.car_deceit = car_deceit;
        }

        public Vehicle()
        {
        }

        public void set_Name(string NewName) { if (NewName != string.Empty) this.name = NewName; else name = "Dafult"; }
        public void set_Range_of_vehicle(string NewRange_of_vehicle) { this.range_of_vehicle = NewRange_of_vehicle; }
        public void set_Car_deceit(long NewCar_deceit) { if (NewCar_deceit > 0) this.car_deceit = NewCar_deceit; else car_deceit = 0; }
        public void set_Xylanh(double NewXylanh) { if (NewXylanh > 0) this.xylanh = NewXylanh; else xylanh = 0; }
        public string get_Name() { return name; }
        public string get_Range_of_vehicle() { return range_of_vehicle; }
        public long get_Car_deceit() { return car_deceit; }
        public double get_Xylanh() { return xylanh; }

        public double Car_tax()
        {
            if (xylanh < 100)
            {
                return car_deceit * 0.1;
            }
            else if (xylanh >= 100 || xylanh < 200)
            {
                return car_deceit * 0.3;
            }
            else return car_deceit * 0.5;

        }
        public static void Printtitle()
        {
            Console.WriteLine("| {0,-20} | {1,-20} | {2, -12} | {3, -15} | {4,-18} |", "Name", "range_of_vehicle", "xylanh", "car_deceit", "car_tax");
        }
        public void ToString()
        {
            Console.WriteLine("| {0,-20} | {1,-20} | {2, -12} | {3, -15} | {4,-18} | ", name, range_of_vehicle, xylanh, car_deceit, Car_tax());
        }
    }
}
