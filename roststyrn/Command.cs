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


    public class WowFactorCommand : Command
    {
        private string time;

        

    public WowFactorCommand(string time)
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

    public class ProfileCommand : Command
    {
        private int a1;
        private int a2;
        private int a3;
        private int a4;
        private int a5;
        private int a10;

        public ProfileCommand(DeskConfig config)
        {
            a1 = config.PosDeskUp;
            a2 = config.PosMonitorOut;
            a3 = config.PosMonitorUp;
            a4 = config.PosCLOVOut;
            a5 = config.PosCLOVUp;
            a10 = config.PosMonitorAngle;
        }

        public override void Send()
        {
            Simulator sim = Simulator.GetInstance();

            sim.SendAxleMoveCommand(1, a1, 100);
            sim.SendAxleMoveCommand(2, a2, 100);
            sim.SendAxleMoveCommand(3, a3, 100);
            sim.SendAxleMoveCommand(4, a4, 100);
            sim.SendAxleMoveCommand(5, a5, 100);
            sim.SendAxleMoveCommand(10, a10, 100);
            //sim.SendLampCommand(ID, mVDC);
            
        }
    }


}

