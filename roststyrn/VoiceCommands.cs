using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roststyrn
{
    public class VoiceCommands
    {

        //static Dictionary<string, List<Command>> allCommands = new Dictionary<string, List<Command>>();
        static Dictionary<string, Command> allCommands = new Dictionary<string, Command>();
        static Simulator sim;

        public static void Init(Simulator sim, string filename)
        {
            VoiceCommands.sim = sim;
            //for testing:
            //allCommands.Add("test_command", new AxleCommand(1, 60, 100) );

            //read all commands from database or file, and put them in allCommands

            string[] lines = new string[] { };
      
            try
            {
                lines = System.IO.File.ReadAllLines(filename);

                Console.WriteLine("Reading lines from:" + filename);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (SystemException e)
            {
                Console.Write(e.ToString());
            }
      
            foreach (string s in lines)
            {
                string[] temp = s.Split(':');
                allCommands.Add(temp[0], ParseCommandFromText(temp[1]));
            }     
        }

        private static Command ParseCommandFromText(String line)
        {
            /*
                template in .txt file:  "commandname:commandtype,arg1,arg2,argN..."
                Ex: 
                table up:AxleCommand,1,650,100
            */

            Command command = null;

            string[] args = line.Split(',');

            if(args[0] == "AxleCommand")
            {
                command = new AxleCommand(Int32.Parse(args[1]), Int32.Parse(args[2]), Int32.Parse(args[3]), sim);
            }
            else if (args[0] == "StopCommand")
            {
                command = new StopCommand(Int32.Parse(args[1]), sim);
            }
            else if (args[0] == "LampCommand")
            {
                command = new LampCommand(Int32.Parse(args[1]), Int32.Parse(args[2]), sim);
            }

            return command;
        }

        public static bool Contains(string key)
        {
            if (allCommands.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
       
        public static Command GetCommand(string key)
        {
            // return command with the correct key
            Command command;
            allCommands.TryGetValue(key, out command);
            return command;
        }

        public static string[] GetAllCommands()
        {
            // get an array with all keys to use for "Choices"
            return allCommands.Keys.ToArray();
        }

        public static void AddCommand(string key, Command command)
        {
            allCommands.Add(key, command);
        }
    }
}

//getcommand().send()