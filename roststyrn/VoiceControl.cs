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
        private System.Globalization.CultureInfo sweCulture;
        private System.Globalization.CultureInfo engCulture;
        private SpeechRecognitionEngine sweEngine;
        private SpeechRecognitionEngine engEngine;
        private SpeechRecognitionEngine curEngine;
        private Choices sweChoices;
        private GrammarBuilder sweGBuilder;
        private Grammar sweGrammar;
        private Choices engChoices;
        private GrammarBuilder engGBuilder;
        private Grammar engGrammar;
        private bool asyncOn;
        private Simulator sim;
        private bool newInput;
        private string time = DateTime.Now.ToString();

        //private int AudioLevel { get; }
        public VoiceControl()
        {


            InitializeComponent();



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

                InitSwe();
                InitEng();
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
                    curEngine.RecognizeAsync(RecognizeMode.Multiple);
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
                curEngine.RecognizeAsyncStop();
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
                Console.WriteLine("Information for the current speech recognition engine:");
                Console.WriteLine("  Name: {0}", curEngine.RecognizerInfo.Name);
                Console.WriteLine("  Culture: {0}", curEngine.RecognizerInfo.Culture.ToString());
                Console.WriteLine("  Description: {0}", curEngine.RecognizerInfo.Description);
        }

        private void startSimBtn_Click(object sender, EventArgs e)
        {
            if (sim != null)
                sim.Close();
            sim = Simulator.GetInstance();
            sim.Show();
            this.TopMost = true;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(langBox.Text == "Svenska")
            {
                curEngine = sweEngine;
            }
            else if (langBox.Text == "Engelska")
            {
                curEngine = engEngine;
            }
            printEngineInfo();
        }

        private void testSend_Click(object sender, EventArgs e)
        {


        }

        private void InitSwe()
        {
            sweCulture = new System.Globalization.CultureInfo("sv-SE");
            sweEngine = new SpeechRecognitionEngine(sweCulture);
            sweChoices = new Choices();
            VoiceCommands.Init("sv-SE");
            sweChoices.Add(VoiceCommands.GetAllCommands());
            sweGBuilder = new GrammarBuilder();
            sweGBuilder.Culture = sweCulture;
            sweGBuilder.Append(sweChoices);
            sweGrammar = new Grammar(sweGBuilder);
            try
            {
                sweEngine.LoadGrammarAsync(sweGrammar);
                sweEngine.SetInputToDefaultAudioDevice();
                sweEngine.SpeechRecognized += recEngine_SpeechRecognized;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Error: UnauthorizedAccessException");
                Console.WriteLine(e.ToString());
            }
        }

        private void InitEng()
        {
            engCulture = new System.Globalization.CultureInfo("en-US");
            engEngine = new SpeechRecognitionEngine(engCulture);
            engChoices = new Choices();
            VoiceCommands.Init("en-US");
            engChoices.Add(VoiceCommands.GetAllCommands());
            engGBuilder = new GrammarBuilder();
            engGBuilder.Culture = engCulture;
            engGBuilder.Append(engChoices);
            engGrammar = new Grammar(engGBuilder);
            try
            {
                engEngine.LoadGrammarAsync(engGrammar);
                engEngine.SetInputToDefaultAudioDevice();
                engEngine.SpeechRecognized += recEngine_SpeechRecognized;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Error: UnauthorizedAccessException");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
