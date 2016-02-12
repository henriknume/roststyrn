using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roststyrn
{
    public partial class Simulator : Form
    {

        private delegate void VoidDelegate();
        private Thread t1;
        private bool cancelWork = false;

        private List<Axle> axles;

        public Simulator()
        {
            InitializeComponent();
            axles = new List<Axle>();
            axles.Add(new Axle(1, 0, 650)); //last argument is real max pos for all axles
            axles.Add(new Axle(2, 0, 150));
            axles.Add(new Axle(3, 0, 200));
            axles.Add(new Axle(4, 0, 300));
            axles.Add(new Axle(5, 0, 650));
            axles.Add(new Axle(10, 0, 24));
        }

        public void SendAxleMoveCommand(int ID, int pos, int speed)
        {
            cancelWork = false;
            if (t1 != null) t1.Abort();
            t1 = new Thread(() => MoveAxles(ID, pos));
            t1.Start();
        }

        public void SendAxleStopCommand(int ID)
        {
            //stop all axles
            cancelWork = true;
            try { Thread.Sleep(100); } catch (ThreadAbortException e) { Console.WriteLine(e.StackTrace); }
            // stop axle with ID
            axles[ID].Stop();

            //start all again
            cancelWork = false;
            if (t1 != null) t1.Abort();
            t1 = new Thread(() => MoveAxles(ID, -1));  // -1 as target wont change any target values
            t1.Start();
        }

        private void MoveAxles(int ID, int target)
        {
            Axle currentAxle = null;
            for(int i = 0; i < axles.Count ; i++)
            {
                if(axles[i].id == ID) {
                    currentAxle = axles[i];
                    break;
                }
            }
            if(target != -1)    // dont set target if target is -1,  used for stop command, change this later.
            {
                currentAxle.SetTargetPos(target);  
            }

            Console.WriteLine("Table moving...");
            bool running = true;
            while (running)
            {
                foreach (Axle a in axles)
                {
                    a.Step();
                }
                int c = 0;
                foreach (Axle a in axles)
                {
                    if (a.AtTarget()) c++;
                }
                if (c == axles.Count()) running = false;

                this.Invoke(new VoidDelegate(UpdateProgressBar));
                if (cancelWork) break;
                try { Thread.Sleep(100); } catch (ThreadAbortException e) { Console.WriteLine(e.StackTrace); }
            }
            this.Invoke(new VoidDelegate(WorkFinished));
            Console.WriteLine("Table stopped.");
        }

        private void UpdateProgressBar()
        {
            progressBar1.Value = axles[0].currentPos;
            label1AxlePos.Text = "ID #1  Pos: " + axles[0].currentPos;

            progressBar2.Value = axles[1].currentPos;
            label2AxlePos.Text = "ID #2  Pos: " + axles[1].currentPos;

            progressBar3.Value = axles[2].currentPos;
            label3AxlePos.Text = "ID #3  Pos: " + axles[2].currentPos;

            progressBar4.Value = axles[3].currentPos;
            label4AxlePos.Text = "ID #4  Pos: " + axles[3].currentPos;

            progressBar5.Value = axles[4].currentPos;
            label5AxlePos.Text = "ID #5  Pos: " + axles[4].currentPos;

            progressBar10.Value = axles[5].currentPos;
            label10AxlePos.Text = "ID #10  Pos: " + axles[5].currentPos;
        }

        private void WorkFinished()
        {
            buttonStop.Enabled = false;
            buttonStop2.Enabled = false;
        }

        

        //   --- Buttonlisteners ---  
        private void buttonUp_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            SendAxleMoveCommand(1, 80, 100);

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            SendAxleMoveCommand(1, 10, 100);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            SendAxleStopCommand(1);
        }

        private void buttonUp2_Click(object sender, EventArgs e)
        {
            buttonStop2.Enabled = true;
            SendAxleMoveCommand(2, 80, 100);
        }

        private void buttonDown2_Click(object sender, EventArgs e)
        {
            buttonStop2.Enabled = true;
            SendAxleMoveCommand(2, 10, 100);
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            buttonStop2.Enabled = false;
            SendAxleStopCommand(2);
        }


        //--------- light listeners --------------------------------------------

        private void LightOn_Click(object sender, EventArgs e)
        {
            LightCheckOn.Checked = true;
            LightCheckOff.Checked = false;
        }

        private void LightOff_Click(object sender, EventArgs e)
        {
            LightCheckOff.Checked = true;
            LightCheckOn.Checked = false;
        }

        private void WarmLight_Click(object sender, EventArgs e)
        {
            if (WarmCheck.Checked)
            {
                WarmCheck.Checked = false;
            }
            else
            {
                WarmCheck.Checked = true;
            }
        }

        private void ColdLight_Click(object sender, EventArgs e)
        {
            if (ColdCheck.Checked)
            {
                ColdCheck.Checked = false;
            }
            else
            {
                ColdCheck.Checked = true;
            }
        }

        /* method that turns on turns off lights 
         * Also regulates light brightness.... 
         */

        public void SendLampCommand(int ID, int mVDC)
        {
            String textmVDC = mVDC.ToString(); // convert to string
            mVDC_Output.AppendText(textmVDC);  // show current mVDC ( 0 - 10 000 ) .... ( ljusstyrka-- brightness )

            if (ID == 0)   // ( uppåtriktat ljus ) is Light " on " at the moment, for testing voice controll
            {
                LightCheckOn.Checked = true;
                LightCheckOff.Checked = false;

            }
            else if (ID == 1 || ID == 2) // ( nedåtriktat ljus )   is Light " off " at the moment ... same as above ....
            {
                LightCheckOff.Checked = true;
                LightCheckOn.Checked = false;
            }
            else {

                Console.WriteLine("incorrect ID");
            }
        }
    }
}
