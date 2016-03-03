using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roststyrn
{
    public partial class CustomizeLayout : Form
    {
        public CustomizeLayout()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //////////////////////////////////////////////
        }

        private void Table_up_Click(object sender, EventArgs e)
        {
            String nameOfAxel = PosDeskUp.Name;
            //Customize.changeShaft(nameOfAxel);
            Customize.axelDictionary(nameOfAxel);
            var setting = new ChangeSetting();
            setting.Show();

        }

        private void Table_down_Click(object sender, EventArgs e)
        {
            /* String nameOfAxel = Table_down.Name;
             Customize.changePos(nameOfAxel); 
             var setting = new Change_Setting();
             setting.Show(); */
        }

        private void Monitor_depth_down_Click(object sender, EventArgs e)
        {
            /* String nameOfAxel = Monitor_depth_down.Name;
             Customize.changePos(nameOfAxel); 
             var setting = new Change_Setting();
             setting.Show(); */
        }

        private void Monitor_depth_up_Click(object sender, EventArgs e)
        {
            String nameOfAxel = PosMonitorOut.Name;
            //Customize.changeShaft(nameOfAxel);
            Customize.axelDictionary(nameOfAxel);
            var setting = new ChangeSetting();
            setting.Show();
        }

        private void Monitor_up_Click(object sender, EventArgs e)
        {
            String nameOfAxel = PosMonitorUp.Name;
            //Customize.changeShaft(nameOfAxel);
            Customize.axelDictionary(nameOfAxel);
            var setting = new ChangeSetting();
            setting.Show();
        }

        private void Monitor_down_Click(object sender, EventArgs e)
        {
            /* String nameOfAxel = Monitor_down.Name;
             Customize.changePos(nameOfAxel); 
             var setting = new Change_Setting();
             setting.Show(); */
        }

        private void CLOV_depth_down_Click(object sender, EventArgs e)
        {
            /* String nameOfAxel = CLOV_depth_down.Name;
             Customize.changePos(nameOfAxel); 
             var setting = new Change_Setting();
             setting.Show(); */
        }

        private void CLOV_depth_up_Click(object sender, EventArgs e)
        {
            String nameOfAxel = PosCLOVOut.Name;
            // Customize.changeShaft(nameOfAxel);
            Customize.axelDictionary(nameOfAxel);
            var setting = new ChangeSetting();
            setting.Show();
        }

        private void Monitor_angle_down_Click(object sender, EventArgs e)
        {
            /* String nameOfAxel = Monitor_angle_down.Name;
             Customize.changePos(nameOfAxel); 
             var setting = new Change_Setting();
             setting.Show(); */
        }

        private void Monitor_angle_up_Click(object sender, EventArgs e)
        {
            String nameOfAxel = PosMonitorAngle.Name;
            //Customize.changeShaft(nameOfAxel);
            Customize.axelDictionary(nameOfAxel);
            var setting = new ChangeSetting();
            setting.Show();
        }

        private void CLOV_down_Click(object sender, EventArgs e)
        {
            /*String nameOfAxel = CLOV_down.Name;
            Customize.changePos(nameOfAxel); 
            var setting = new Change_Setting();
            setting.Show(); */
        }

        private void CLOV_up_Click(object sender, EventArgs e)
        {
            String nameOfAxel = PosCLOVUp.Name;
            //Customize.changeShaft(nameOfAxel);
            Customize.axelDictionary(nameOfAxel);
            var setting = new ChangeSetting();
            setting.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Customize.updateUser(Name_personal.Text);
            Customize.updateDeskConfig();
            Close();
        }
    }
}
