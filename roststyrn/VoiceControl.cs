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
        private SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("sv-SE"));
        private Choices choices;
        private GrammarBuilder gBuilder;
        private Grammar grammar;
        private bool asyncOn;
        private Simulator sim;
        private bool newInput;
        private string time = DateTime.Now.ToString();

        //private int AudioLevel { get; }
        public VoiceControl()
        {
            printEngineInfo(); //prints information about the recEngine - useful for testing when we change language

            InitializeComponent();

            /* starting the simulator first cause we need to pass refs to the commands*/
            if (sim != null)
                sim.Close();
            sim = new Simulator();
            sim.Show();
            this.TopMost = true;

            
            VoiceCommands.Init(sim, "sv-SE");

            Console.WriteLine("\n----------- loading default commands ------------");
            string[] allCommands = VoiceCommands.GetAllCommands();
            if(allCommands.Length > 0)
            {
                foreach (string s in allCommands)
                {

                    Console.WriteLine(s);

                }
                Console.WriteLine("---------------------------------------------------");
                /* speech rec stuff, only start if there exists commands*/
                Console.WriteLine("-starting SpeechRecognitionEngine");
                choices = new Choices();
                choices.Add(allCommands);
                gBuilder = new GrammarBuilder();
                gBuilder.Culture = new System.Globalization.CultureInfo("sv-SE");
                gBuilder.Append(choices);
                grammar = new Grammar(gBuilder);
                try
                {
                    recEngine.LoadGrammarAsync(grammar);
                    recEngine.SetInputToDefaultAudioDevice();
                    recEngine.SpeechRecognized += recEngine_SpeechRecognized;
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Error: UnauthorizedAccessException");
                    Console.WriteLine(e.ToString());
                }
                asyncOn = false;
                this.KeyUp += new KeyEventHandler(Form1_KeyUp);
                langBox.SelectedIndex = 0;

            }
            else
            {
                Console.WriteLine("--no commands loaded, check resources files");
                Console.WriteLine("---------------------------------------------------");
            }
            
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }



        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            Console.WriteLine("####### Recognized input #########:" + e.Result.Text);
            //label1.Text = "Input: " + e.Result.Text.ToUpper().Replace(" ", "_");
            if (sim == null)
                return;

            string voiceInput = e.Result.Text;

            Console.WriteLine("========== Input recognized: ============>" + voiceInput);

            if (VoiceCommands.Contains(voiceInput))
            {
                VoiceCommands.GetCommand(voiceInput).Send();
      
            }

            /* case "öppna chrome":
                 Process.Start("chrome.exe", "http:\\www.google.com");
                 break;
           
                case "öppna notepad":
                    Process.Start("notepad.exe");
                    break;
                case "vad är klockan":
                case "klockan":
                    (new System.Threading.Thread(CloseIt)).Start();
                    MessageBox.Show(string.Format("Datum och tid är {0}", time));
                    break;
            }*/
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Control | Keys.R)) && asyncOn == false)
            {
                label2.Text = "Status: ON";
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
                label2.Text = "Status: OFF";
                if(sim != null) {
                    sim.SendAxleStopCommand(1);
                    sim.SendAxleStopCommand(2);
                }
                recEngine.RecognizeAsyncStop();
                asyncOn = false;
            }

        }

        public void CloseIt()
        {
            System.Threading.Thread.Sleep(5000);
            SendKeys.SendWait(" ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printEngineInfo()
        {

            using (SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine())
            {
                Console.WriteLine("Information for the current speech recognition engine:");
                Console.WriteLine("  Name: {0}", recognizer.RecognizerInfo.Name);
                Console.WriteLine("  Culture: {0}", recognizer.RecognizerInfo.Culture.ToString());
                Console.WriteLine("  Description: {0}", recognizer.RecognizerInfo.Description);
            }
        }

        private void startSimBtn_Click(object sender, EventArgs e)
        {
            if (sim != null)
                sim.Close();
            sim = new Simulator();
            sim.Show();
            this.TopMost = true;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(langBox.Text == "Svenska")
            {

            }
            else if (langBox.Text == "Engelska")
            {

            }
        }

        private void testSend_Click(object sender, EventArgs e)
        {


        }
    }
}
