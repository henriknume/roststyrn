using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roststyrn
{
    public class VoiceCommands
    {

        static Dictionary<string, List<Command>> allCommands = new Dictionary<string, List<Command>>();


        public void Init(string lang)
        {
            //read all commands from database or file, and put them in allCommands
        }

        public static bool Contains(string key)
        {
            if (allCommands.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
       
        public static Command getCommand(string s)
        {
            // return command with the correct key

            return new AxleCommand(1, 70, 100);
        }

        public static void addCommand(string key)
        {

        }
    }
}

//getcommand().send()