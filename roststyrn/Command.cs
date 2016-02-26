using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace roststyrn
{
    public abstract class Command
    {

        abstract public void Send();
    }

    public class AxleCommand : Command
    {
        private int ID;
        private int pos;
        private int speed;

        public AxleCommand(int ID, int pos, int speed)
        {
            this.ID = ID;
            this.pos = pos;
            this.speed = speed;
        }

        public override void Send()
        {
            Simulator.GetInstance().SendAxleMoveCommand(ID, pos, speed);
            Console.WriteLine("SendAxleMoveCommand("+ ID+ ", "+pos+", "+speed+")");
        }
    }

    public class StopCommand : Command
    {
        private int ID;

        public StopCommand(int ID)
        {
            this.ID = ID;
        }

        public override void Send()
        {
            Simulator.GetInstance().SendAxleStopCommand(ID);
            Console.WriteLine("SendAxleStopCommand(" + ID + ")");
        }
    }

    public class LampCommand : Command
    {
        private int ID;
        private int mVDC;
        public LampCommand(int ID, int mVDC)
        {
            this.ID = ID;
            this.mVDC = mVDC;
        }

        public override void Send()
        {
            Simulator.GetInstance().SendLampCommand(ID, mVDC);
            Console.WriteLine("SendLampCommand(" + ID + ", "+ mVDC+")");
        }
    }
    /*
    public class OpenProgramCommand : Command
    {

        private string program;

        public OpenProgramCommand(string exefile)
        {
            program = exefile;
        }
        public override void Send()
        {
            Process.Start(program);
            Console.WriteLine("opening program: {0}", program);
        }
    }
*/


    public class TimeCommand : Command
{
        private string time;

        

    public TimeCommand(string time)
        {
            this.time = DateTime.Now.ToString();
            time = DateTime.Now.ToString();

        }
        public override void Send()
        { 
            try {
                (new System.Threading.Thread(CloseIt)).Start();
                MessageBox.Show("The time is: " + time);
                Console.WriteLine("Displaying time");
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine(" ");
            }
        }

        public void CloseIt()
        {
            System.Threading.Thread.Sleep(5000);
            SendKeys.SendWait(" ");
        }
    }


}

