using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car() 
        { 
        }
        public bool HasTrunk { get; set; }

        public bool HasSunroof { get; set; } = false;
        public bool Has4Wheels { get; set; } = true;
        public int NumDoors { get; set; } = 2;
        public bool HasRadio { get; set; } = true;
        public string EngineType { get; set; } = "4 Cylinder";
        public string Logo { get; set; } = "Nissan";
        public string Slogan { get; set; } = "Innovation that excites";
        public bool HasChangedGears { get; set; }
        public string PaintColor { get ; set; }

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
