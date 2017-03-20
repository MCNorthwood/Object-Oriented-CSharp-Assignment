using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEastMotorClub
{
    abstract class Driver
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int driverNumber;

        public int DriverNumber
        {
            get { return driverNumber; }
            set { driverNumber = value; }
        }

        public bool driverFinished { get; set; }

        //when the programs starts it sets the driver as not finished
        public Driver(String name, int driverNumber)
        {
            this.name = name;
            this.driverNumber = driverNumber;
            this.driverFinished = false;
        }

        public TimeSpan timeTaken { get; set; }


        //Updates the time
        public virtual void UpdateTime(TimeSpan time)
        {
            this.timeTaken = time;
            this.driverFinished = true;
        }

        public override String ToString()
        {
            return name + " " + driverNumber;
        }
    }
}
