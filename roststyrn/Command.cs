using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Simulator sim = null;

        public AxleCommand(int ID, int pos, int speed)
        {
            this.ID = ID;
            this.pos = pos;
            this.speed = speed;
        }
        public AxleCommand(int ID , int pos, int speed, Simulator sim)
        {
            this.ID = ID;
            this.pos = pos;
            this.speed = speed;
            this.sim = sim;
        }
        public override void Send()
        {
            if(sim != null)
                sim.SendAxleMoveCommand(ID, pos, speed);
            Console.WriteLine("SendAxleMoveCommand("+ ID+ ", "+pos+", "+speed+")");
        }
    }

    public class StopCommand : Command
    {
        private int ID;
        private Simulator sim = null;

        public StopCommand(int ID)
        {
            this.ID = ID;
        }
        public StopCommand(int ID, Simulator sim)
        {
            this.ID = ID;
            this.sim = sim;
        }

        public override void Send()
        {
            if (sim != null)
                sim.SendAxleStopCommand(ID);
            Console.WriteLine("SendAxleStopCommand(" + ID + ")");
        }
    }

    public class LampCommand : Command
    {
        private int ID;
        private int mVDC;
        private Simulator sim;
        public LampCommand(int ID, int mVDC)
        {
            this.ID = ID;
            this.mVDC = mVDC;
        }

        public LampCommand(int ID, int mVDC, Simulator sim)
        {
            this.ID = ID;
            this.mVDC = mVDC;
            this.sim = sim;
        }
        public override void Send()
        {
            if (sim != null)
                sim.SendLampCommand(ID, mVDC);
            Console.WriteLine("SendLampCommand(" + ID + ", "+ mVDC+")");
        }
    }

}
