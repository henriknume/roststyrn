using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Security.Principal;
using System.Security.AccessControl;


namespace Customize
{
     
   class Customize
    {
           private static DeskConfig desk = new DeskConfig();
           private static Dictionary<String, Dictionary<String, int>> user_Positions_Profile = new Dictionary<String, Dictionary<String,int>>();
           private static Dictionary<String, int> shafts_Pos = new Dictionary<string, int>();
           private static String[] shafts = new String [6];
           private static int[] positions = new int[6];
           private static int p, s = 0;

           public static void changePos(int pos)
           {
               positions[p] = pos;
               p++;
               
              
           }
           public static void changeShaft(String nameOfShaft){

               shafts[s] = nameOfShaft;
               s++;
   
           }
           public static void mergePosAndShafts() {          // called by save button
               
               for (int i = 0; i < 5; i++) {
                   if (shafts[i] == null || positions[i] == null) { break; }
                   //// need a method for if( isvalid ) here  /////////////////
                       shafts_Pos.Add(shafts[i], positions[i]);
               }
           }
           public static void updateUser(String User)     // called by save button
           {

               user_Positions_Profile.Add(User, shafts_Pos);            // adds user to a dictionary with custom shaft positions 
           
           }
           public static void updateDeskConfig() {    // called by save button             // this is where updates are made  // 
               
               foreach (var pos in shafts_Pos.Keys) {    // loop "Axels_Pos" to find which shafts = axlar to change the position and then updates position with deskConfig

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
           public static void isValid() { // needed ....
           
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
