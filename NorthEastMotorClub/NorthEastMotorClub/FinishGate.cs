using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEastMotorClub
{
    class FinishGate
    {
        public int NumDriver{get;set;}

        public int milesCompleted;

        //updates time and amount of drivers finished
        public void updateFinish(Driver driverUpdate, TimeSpan timeUpdate)
        {
            driverUpdate.UpdateTime(timeUpdate);
            NumDriver++;
            milesCompleted = 100;
        }

        public FinishGate()
        {
            // TODO: Complete member initialization
            NumDriver = 0;
        }
    }
}
