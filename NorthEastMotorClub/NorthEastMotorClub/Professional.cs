using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEastMotorClub
{
    class Professional : Driver
    {       
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private int miles;

        public int Miles 
        {
            get { return miles; }
            set { miles = value; }
        }

        public Professional(String name, int driverNumber, int grade) : base(name, driverNumber)
        {
            this.grade = grade;
            this.miles = 0;
        }

        // Updates the time for professionals
        public override void UpdateTime(TimeSpan time)
        {
 	         base.UpdateTime(time);
             miles = miles + 100;
        }
                
        public override string ToString()
        {
            return base.ToString() + " (Grade " + grade + ") "; // +" completed " + Miles + " miles";
        }
    }
}
