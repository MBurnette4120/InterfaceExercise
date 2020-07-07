using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string BedSize { get; set; } = "Long";
        public string CabSize { get; set; } = "Crew";
        public string Logo { get; set; } = "Ford";
        public string Slogan { get; set; } = "Built Tough!";
        public bool Has4Wheels { get; set; } = true;
        public int NumDoors { get; set; } = 4;
        public bool HasRadio { get; set; } = true;
        public string EngineType { get; set; } = "V6";
        public bool HasChangedGears { get; set; }
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

