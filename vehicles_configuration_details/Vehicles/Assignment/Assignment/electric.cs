using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class electric: vehicle
    {
        //Auto-implemented properties for trivial get and set
        public new string vehicleID { get; private set; }
        public int voltage { get; private set; }
        public int brushed { get; private set; }

        //Constructor
        public electric(string VehicleID, int Voltage, int Brushed)
        {

            vehicleID = VehicleID;
            voltage= Voltage;
            brushed = Brushed; 


        }

        
        
        
    }
}
