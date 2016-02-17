using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roststyrn
{
    abstract class Command
    {

        abstract public void Send();
    }

    class AxleCommand : Command
    {
        private int ID;
        private int pos;
        private int speed;
        public AxleCommand(int ID , int pos, int speed)
        {
            this.ID = ID;
            this.pos = pos;
            this.speed = speed;
        }
        public override void Send()
        {
            //sim.SendAxleMoveCommand(ID, pos, speed);
            Console.WriteLine("SendAxleMoveCommand("+ ID+ ", "+pos+", "+speed+")");
        }
    }

    class StopCommand : Command
    {
        private int ID;
        public StopCommand(int ID)
        {
            this.ID = ID;
        }
        public override void Send()
        {
            //sim.SendAxleStopCommand(ID);
            Console.WriteLine("SendAxleStopCommand(" + ID + ")");
        }
    }

    class LampCommand : Command
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
            //sim.SendAxleMoveCommand(ID, pos, speed);
            Console.WriteLine("SendLampCommand(" + ID + ", "+ mVDC+")");
        }
    }

}
