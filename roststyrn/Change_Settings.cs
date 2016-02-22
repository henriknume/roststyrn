using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace roststyrn
{
    public partial class Change_Setting : Form
    {
        public Change_Setting()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int tempPos = 0;
            bool result = int.TryParse(newPos.Text, out tempPos); // check if String is numeric.. if true -> tempPos = newPos.Text
            if (result)
            {
                Customize.changePos(tempPos);

            }
        }

        private void Set_default_Click(object sender, EventArgs e)
        {
          /////////////// Load defaults ///////////////////////////
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
