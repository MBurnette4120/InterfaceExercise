using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool ThirdRowSeat { get; set; } = false;
        public bool RoofRack { get; set; } = false;
        public bool Has4Wheels { get; set; } = true;
        public int NumDoors { get; set; } = 4;
        public bool HasRadio { get; set; } = true;
        public string EngineType { get; set; } = "V6";
        public string Logo { get; set; } = "GMC";
        public string Slogan { get; set; } = "We are professional grade!";
        public bool HasChangedGears { get; set; } = false;
        public string PaintColor { get; set; }



        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} now driving forward. . .");
        }

        public void Park()
        {
            Console.WriteLine($"The {GetType().Name} is now in park. . .");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
