using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEastMotorClub
{
    class SponsoredPro : Professional
    {
        private String companySponsor;

        public String CompanySponsor
        {
            get { return companySponsor; }
            set { companySponsor = value; }
        }

        public SponsoredPro(String name, int driverNumber,  int grade, String companySponsor) : base(name, driverNumber, grade)
        {
            this.companySponsor = companySponsor;
        }

        public override string ToString()
        {
            return base.ToString() + " sponsored by " + companySponsor ;
        }
    }
}
