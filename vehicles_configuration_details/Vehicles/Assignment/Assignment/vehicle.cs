using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class vehicle
    {
        //Auto-implemented properties for trivial get and set
        public string engine { get; private set; }
        public string vehicleID { get; private set; }
        public int range { get; private set; }
        public int weight { get; private set; }
        public int carryCapacity { get; private set; }
        public float topspeed { get; private set; }

        // default constructor as petrol and vehicle classes are defined in elsewhere.
        public vehicle()
        {

        }

        //Constructor
        public vehicle(string Engine, string VehicleID, int Range, int Weight, int CarryCapacity, float Topspeed)
        {
            engine = Engine;
            vehicleID = VehicleID;
            range = Range;
            weight = Weight;
            carryCapacity = CarryCapacity;
            topspeed = Topspeed;

        }

        // Method to display the engine type in the listBox. Displays 'Petrol' or 'Eletric'. 

        // Upon selecting the engine type in the listBox for each vehicleID from the loaded Xml file, the contents that are inserted for the selected vehicle ID in vehicle table (in database)
        // are diaplayed in the Property Grid.
        public override string ToString()
        {
            return engine;
        } 
    }
}
