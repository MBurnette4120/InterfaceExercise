using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool Has4Wheels { get; set; }
        public int NumDoors { get; set; }
        public bool HasRadio { get; set; }
        public string EngineType { get; set; }

        public string PaintColor { get; set; }

        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);


    }
}
