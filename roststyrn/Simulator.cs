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
            axles.Add(new Axle(0, 1, 1, 100));
            axles.Add(new Axle(1, 1, 1, 80));
        }

        public void SendStop(int id)
        {

        }

        private void MoveAxles(int id, int target)
        {
            Console.WriteLine("Table moving...");
            axles[id].SetTargetPos(target);

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
            label1AxlePos.Text = "Axle 1 pos: " + axles[0].currentPos;

            progressBar2.Value = axles[1].currentPos;
            label2AxlePos.Text = "Axle 2 pos: " + axles[1].currentPos;
        }

        private void WorkFinished()
        {
            buttonUp.Enabled = true;
            buttonDown.Enabled = true;
            buttonStop.Enabled = false;
        }

        public void SendMoveAxleCommand(int ID, int pos, int speed)
        {
            cancelWork = false;
            if (t1 != null) t1.Abort();
            t1 = new Thread(() => MoveAxles(ID, pos));
            t1.Start();
        }

        //   --- Buttonlisteners ---  
        private void buttonUp_Click(object sender, EventArgs e)
        {

            buttonUp.Enabled = false;
            buttonStop.Enabled = true;
            buttonDown.Enabled = true;

            SendMoveAxleCommand(0, 70, 100);

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            buttonUp.Enabled = true;
            buttonDown.Enabled = false;
            buttonStop.Enabled = true;

            SendMoveAxleCommand(0, 1, 100);

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            cancelWork = true;
        }

        private void buttonUp2_Click(object sender, EventArgs e)
        {
            buttonUp2.Enabled = false;
            buttonStop2.Enabled = true;
            buttonDown2.Enabled = true;

            SendMoveAxleCommand(1, 50, 100);

        }

        private void buttonDown2_Click(object sender, EventArgs e)
        {
            buttonUp2.Enabled = true;
            buttonDown2.Enabled = false;
            buttonStop2.Enabled = true;

            SendMoveAxleCommand(1, 20, 100);
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            cancelWork = true;
        }

        //----------------------------



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
