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

        private static DeskConfig desk = new DeskConfig();
        private static Dictionary<String, Dictionary<String, int>> user_Positions_Profile = new Dictionary<String, Dictionary<String, int>>();
        private static Dictionary<String, int> shafts_Pos = new Dictionary<string, int>();
        private static String currentAxelUpdate = "";

        public static void axelDictionary(String axel)
        {

            if (!shafts_Pos.ContainsKey(axel))
            {
                shafts_Pos.Add(axel, getDeskConfigAxelValue(axel)); // get current user Value 
                currentAxelUpdate = axel;
            }
            else
            {
                currentAxelUpdate = axel;
            }

        }
        public static void posDictionary(int pos)
        {

            if (isValid(currentAxelUpdate, pos))
            {
                shafts_Pos[currentAxelUpdate] = pos;
            }

        }
        public static int getDeskConfigAxelValue(String axel)
        {

            if (axel.Equals("PosDeskUp"))
            {
                return desk.PosDeskUp;
            }
            else if (axel.Equals("PosMonitorOut"))
            {
                return desk.PosMonitorOut;
            }
            else if (axel.Equals("PosMonitorUp"))
            {
                return desk.PosMonitorUp;
            }
            else if (axel.Equals("PosMonitorAngle"))
            {
                return desk.PosMonitorAngle;
            }
            else if (axel.Equals("PosCLOVOut"))
            {
                return desk.PosCLOVOut;
            }
            else
            {
                return desk.PosCLOVUp;    // axel == PosCLOVUp
            }
        }
        public static void updateUser(String User)     // called by save button
        {
            if (!User.Equals("")) // not allowed to be blank..
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
            shafts_Pos.Clear();
        }
        public static bool isValid(String nameOfShaft, int pos)
        {            //  check if pos is valid for that axel  //

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

        public static Dictionary<String, int> printAllSavedData()
        {  // used for testing....

            return shafts_Pos;

        }
        public static Dictionary<String, int> getUserProfile(String user)
        { // called by voiceControl.......

            foreach (var currentUser in user_Positions_Profile.Keys)
            {

                if (currentUser.Equals(user))
                {

                    return user_Positions_Profile[currentUser];   // use these values for axels..in voiceCommand.. to adjust profile...

                }

            }
            return null;   // user does not exist
        }
        public static void saveUserProfile(String user)
        {

            /////////////////////  Save in local file... textfile....  ////////////////////////

        }

    }
}
