using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace roststyrn
{
    public partial class VoiceControl : Form
    {
        private bool asyncOn;
        private bool newInput;
        private SpeechRecognitionEngine recEngine;
        private Simulator sim = null;

        public VoiceControl()
        {

            InitializeComponent();
            asyncOn = false;
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            langBox.SelectedIndex = 0;      
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            string voiceInput = e.Result.Text;

            Console.WriteLine("========== Input recognized: ============>" + voiceInput);

            if (VoiceCommands.Contains(voiceInput))
            {
                VoiceCommands.GetCommand(voiceInput).Send();
            }
            else
                Console.WriteLine("Command doesn't exist");

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Control | Keys.R)) && asyncOn == false)
            {
                label2.Text = "Status: Listening...";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                try
                {
                    recEngine.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (NullReferenceException e) {
                    Console.WriteLine("Error: NullReferenceException");
                    Console.WriteLine(e.ToString());
                }
                asyncOn = true;
                return true;
            }
            return false;
        }


        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (asyncOn == false)
                return;
            if (e.KeyCode == Keys.R || e.KeyCode == Keys.ControlKey)
            {
                deactivateEngine();
            }
        }


        private void printEngineInfo()
        {
                Console.WriteLine("Information for the current speech recognition engine:");
                Console.WriteLine("  Name: {0}", recEngine.RecognizerInfo.Name);
                Console.WriteLine("  Culture: {0}", recEngine.RecognizerInfo.Culture.ToString());
                Console.WriteLine("  Description: {0}", recEngine.RecognizerInfo.Description);
        }

        private void startSimBtn_Click(object sender, EventArgs e)
        {
            sim = Simulator.GetInstance();
            sim.Show();
            this.TopMost = true;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(langBox.Text == "Svenska")
            {
                recEngine = RecognitionEngine.getEngine("swe");
                
                Console.WriteLine("Svenska på");
            }
            else if (langBox.Text == "English")
            {
                recEngine = RecognitionEngine.getEngine("eng");
                Console.WriteLine("English on");
            }
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            //printEngineInfo();
        }
     

        private void Customize_profile_Click(object sender, EventArgs e)
        {
            var customize = new Customize_layout();
            customize.Show();
        }
        private void deactivateEngine()
        {
            label2.Text = "Status: Not listening";
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            
          

            Console.WriteLine("SendAxleStopCommand(1)");
            Simulator.GetInstance().SendAxleStopCommand(1);
            Console.WriteLine("SendAxleStopCommand(2)");
            Simulator.GetInstance().SendAxleStopCommand(2);
            recEngine.RecognizeAsyncStop();
            asyncOn = false;
        }
        private void VoiceControl_Deactivate(object sender, EventArgs e)
        {
            deactivateEngine();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
