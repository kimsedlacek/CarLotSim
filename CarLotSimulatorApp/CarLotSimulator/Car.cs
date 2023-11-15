using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public int Year { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
        }

        public void MakeHonkNoise(string honkNoise)
        { }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = 2015;
            Make = "Dodge";
            Model = "Ram 1500";
            EngineNoise = "loud like a truck";
            HonkNoise = "tough like a truck";
            IsDriveable = true;
        }

    }
}
