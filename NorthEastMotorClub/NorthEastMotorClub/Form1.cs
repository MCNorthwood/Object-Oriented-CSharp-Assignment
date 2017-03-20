using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthEastMotorClub
{
    public partial class Form1 : Form
    {
        const int MAX_DRIVERS = 10;

        FinishGate finishGate = new FinishGate();

        public Form1()
        {
            InitializeComponent();
            driverTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create array of drivers
            Driver[] driveList;
            driveList = new Driver[10];

            driveList[0] = new Professional("Professional Driver", 313, 3);
            driveList[1] = new SponsoredPro("Professional Driver", 242, 1, "CocaCola");
            driveList[2] = new Amateur("Amateur Driver", 178 , 1600);
            driveList[3] = new SponsoredPro("Professional Driver", 299, 6, "Redbull");
            driveList[4] = new Professional("Professional Driver", 334, 5);
            driveList[5] = new Amateur("Amateur Driver", 129 , 2400);
            driveList[6] = new Professional("Professional Driver", 382, 2);
            driveList[7] = new SponsoredPro("Professional Driver", 203, 6, "Microsoft");
            driveList[8] = new Amateur("Amateur Driver", 149 , 1800);
            driveList[9] = new Professional("Professional Driver", 357, 4);

            // add drivers to listbox
            for (int i = 0; i < MAX_DRIVERS; i++)
            {
                lstDrivers.Items.Add(driveList[i]);
            }
        }

        private int timer = 0;

        private void driverTimer_Tick(object sender, EventArgs e)
        {
            // will add on 1 second onto lblTimer
            timer++;
            TimeSpan time = TimeSpan.FromSeconds(timer);
            // here it represents the time in hours, minutes and seconds
            lblTimer.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lstDrivers.SelectedIndex > -1)
            {
                Driver finishDriver = (Driver)lstDrivers.SelectedItem;

                //disables button so when clicked doesn't enable if the driver is clicked again
                btnComplete.Enabled = false;

                // use labels to display the time/number of finished drivers/miles completed
                finishGate.updateFinish(finishDriver,TimeSpan.FromSeconds(timer));
                lblTime.Text = finishDriver.timeTaken.ToString(@"hh\:mm\:ss");

                //Adds 1 every time to the number of drivers finished when finish race button is pressed
                lblFinish.Text = finishGate.NumDriver.ToString();

                // miles only shows when Pros are clicked
                if (finishDriver.DriverNumber >= 200)
                {
                    lblMiles.Text = finishGate.milesCompleted.ToString();
                }
                else
                {
                    lblMiles.Text = "Not Completed";
                }
                lblListDriver.Text = finishDriver.Name + " " + finishDriver.DriverNumber.ToString();

            }

        }

        private void lstDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Driver finishDriver = (Driver)lstDrivers.SelectedItem;

            if(finishDriver.driverFinished == true)
            {
                btnComplete.Enabled = false;
                //when driver is selected, shows the time it was completed in, miles and name of the driver
                lblTime.Text = "Completed in: " + finishDriver.timeTaken.ToString(@"hh\:mm\:ss");
                if (finishDriver.DriverNumber >= 200)
                {
                    lblMiles.Text = finishGate.milesCompleted.ToString();
                }
                else
                {
                    lblMiles.Text = "Not Completed";
                }
                lblListDriver.Text = finishDriver.Name + " " + finishDriver.DriverNumber.ToString();    
            }
            else
            {
                //if it's not selected it's to stay normal
                btnComplete.Enabled = true;
                lblTime.Text = "Not Finished";
                lblMiles.Text = "Not Completed";
                lblListDriver.Text = " ";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFinish_Click(object sender, EventArgs e)
        {

        }

    }
}
