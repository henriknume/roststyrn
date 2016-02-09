using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roststyrn
{
    public class Axle
    {
        public int id;
        public int currentPos;
        int targetPos;
        int min = 1;
        int max;

        public Axle(int id, int currentPos, int targetPos, int maxPos)
        {
            this.id = id;
            this.currentPos = currentPos;
            this.targetPos = targetPos;
            this.max = maxPos;
        }

        public void Step()
        {
            int dir = 1;

            if (targetPos < currentPos)
            {
                dir = -1;
            }
            if (currentPos != targetPos)
            {
                currentPos += dir;
            }
        }

        public void SetTargetPos(int newPos)
        {
            if (newPos < min) targetPos = min;

            else if (newPos > max) targetPos = max;

            else targetPos = newPos;
        }

        public bool AtTarget()
        {
            if (currentPos == targetPos)
                return true;
            return false;
        }
    }
}
