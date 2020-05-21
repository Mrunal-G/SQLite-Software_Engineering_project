using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class petrol : vehicle
    {
        //Auto-implemented properties for trivial get and set
        public new string vehicleID { get; private set; }
        public int noise { get; private set; }
        public int cylinders { get; private set; }

        //Constructor
        public petrol(string VehicleID, int Noise, int Cylinders)
        {
            
            vehicleID = VehicleID;
            noise = Noise;
            cylinders = Cylinders;


        }

        
    }
}
