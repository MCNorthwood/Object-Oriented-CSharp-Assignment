using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEastMotorClub
{
    class Amateur : Driver
    {
        private int engineSize;

        public int EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        public Amateur(String name, int driverNumber,  int engineSize)
            : base(name, driverNumber)
        {
            this.engineSize = engineSize;
        }

        public override string ToString()
        {
            return base.ToString() + " with " + engineSize + "cc vehicle";
        }
    }
}
