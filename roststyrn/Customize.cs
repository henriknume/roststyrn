using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Security.Principal;
using System.Security.AccessControl;


namespace roststyrn
{

    class Customize
    {
        private static int size = 6;
        private static DeskConfig desk = new DeskConfig();
        private static Dictionary<String, Dictionary<String, int>> user_Positions_Profile = new Dictionary<String, Dictionary<String, int>>();
        private static Dictionary<String, int> shafts_Pos = new Dictionary<string, int>();
        private static String[] shafts = new String[size];
        private static int[] positions = new int[size];
        private static int p, s = 0;
        private static String tempNameOfShaft = "";       // sets to remember" when shaft already exist" -> to that existing shaft

        public static void changePos(int pos)
        {
            if (0 < p && p <= size-1)
            {
                if (shafts.Length > positions.Length)
                {
                    positions[p] = pos;
                    p++;
                }
                else {          // update already existing pos //

                   int indexExistingPos = getPosForExistingShaft(tempNameOfShaft);
                   positions[indexExistingPos] = pos;
                }
            }
        }
        public static void changeShaft(String nameOfShaft)
        {
            if (!alreadyExist(nameOfShaft))   // check if shaft already exist in array, if true -> dont add ..
            {
                shafts[s] = nameOfShaft;
                s++;
            }
            else {
                tempNameOfShaft = nameOfShaft;
            }
        }
        public static void mergePosAndShafts()
        {                                                               // called by save button...........

            for (int i = 0; i < size - 1; i++)    
            {
                if (shafts[i] == null || positions[i] == null) { break; }
                if (isValid(shafts[i], positions[i]))             // check if valid "pos" for that specific "shaft"
                {   
                    shafts_Pos.Add(shafts[i], positions[i]);
                }
            }
            shafts_Pos.Clear(); // reset dictionary for shaft_pos, so it can be re-used ....

        }
        public static void updateUser(String User)     // called by save button
        {
            if (! User.Equals("")) // not allowed to be blank..
            {
                if (user_Positions_Profile.ContainsKey(User))   // if key exist
                {
                    user_Positions_Profile[User] = shafts_Pos; // update key with the new value ....
                }
                else
                {
                    user_Positions_Profile.Add(User, shafts_Pos);   // adds new user to a dictionary with custom shaft positions
                }                           
            }
            reset();             // reset position  shafts array for new updates for user profile...
        }
        public static void updateDeskConfig()
        {    // called by save button  .... // this is where updates are made  // 

            foreach (var pos in shafts_Pos.Keys)
            {    // loop "Axels_Pos" to find which shafts = axlar to change the position and then updates position with deskConfig

                if (pos.Equals("PosDeskUp"))
                {
                    desk.PosDeskUp = shafts_Pos[pos];
                }
                if (pos.Equals("PosMonitorOut"))
                {
                    desk.PosMonitorOut = shafts_Pos[pos];
                }
                if (pos.Equals("PosMonitorUp"))
                {
                    desk.PosMonitorUp = shafts_Pos[pos];
                }
                if (pos.Equals("PosMonitorAngle"))
                {
                    desk.PosMonitorAngle = shafts_Pos[pos];
                }
                if (pos.Equals("PosCLOVOut"))
                {
                    desk.PosCLOVOut = shafts_Pos[pos];
                }
                if (pos.Equals("PosCLOVUp"))
                {
                    desk.PosCLOVUp = shafts_Pos[pos];
                }
            }
        }
        public static bool isValid(String nameOfShaft, int pos)
        {            //  check if pos is valid for that shaft  //

            if (nameOfShaft.Equals("PosDeskUp"))
            {
                if (pos >= 0 && pos <= 650) { return true; }
                else { return false; }
            }
            else if (nameOfShaft.Equals("PosMonitorOut"))
            {
                if (pos >= 0 && pos <= 150) { return true; }
                else { return false; }
            }
            else if (nameOfShaft.Equals("PosMonitorUp"))
            {
                if (pos >= 0 && pos <= 200) { return true; }
                else { return false; }
            }
            else if (nameOfShaft.Equals("PosMonitorAngle"))
            {
                if (pos >= 0 && pos <= 24) { return true; }
                else { return false; }
            }
            else if (nameOfShaft.Equals("PosCLOVOut"))
            {
                if (pos >= 0 && pos <= 300) { return true; }
                else { return false; }
            }
            else if (nameOfShaft.Equals("PosCLOVUp"))
            {
                if (pos >= 0 && pos <= 650) { return true; }
                else { return false; }
            }
            else { return false; }
        }
        public static bool alreadyExist(String nameOfShaft)
        {     // checks if shaft already exists in array  //

            foreach (var current in shafts)
            {
                if (current == null) { return false; }
                if (current.Equals(nameOfShaft)) { return true; }
            }
            return false;
        }
        public static int getPosForExistingShaft(String name) {
            
            int count = 0;
            for (int i = 0; i < shafts.Length; i++ )
            {
                if (shafts[i].Equals(name)) {
                    count = i;
                }
            }
            return count;
        }

        public static void reset()
        {

            Array.Clear(shafts, 0, shafts.Length);
            Array.Clear(positions, 0, positions.Length);
            p = 0;
            s = 0;
        }

        public static void set_default()
        {                         //  probably need  ? //
            /////////// ToDO ///////////////////////////
        }
        public static void set_all_default()
        {                       //   probably need  ? //      
            /////////// ToDO //////////////////////////
        }
    }
}
