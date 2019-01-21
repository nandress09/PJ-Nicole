using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ListOfObjects
{
    class PersonCar
    {
        public enum MakeName
        {
            NONE,
            DODGE,
            FORD,
            CHEVY,

        }

        public bool IsHardTop { get; internal set; }
        public double Engine { get; internal set; }
        public int Year { get; internal set; }
        public string Model { get; internal set; }
        public MakeName Make { get; internal set; }
        
    }
}
