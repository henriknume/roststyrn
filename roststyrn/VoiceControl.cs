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
        private bool newInput;
        private string time = DateTime.Now.ToString();

        //private int AudioLevel { get; }
        public VoiceControl()
        {

            InitializeComponent();
            InitSwe();
            InitEng();
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
                deactivateEngine();
            }
        }


        public void CloseIt()
        {
            System.Threading.Thread.Sleep(5000);
            SendKeys.SendWait(" ");
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
            Simulator.GetInstance().Show();
            this.TopMost = true;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(langBox.Text == "Svenska")
            {
                curEngine = sweEngine;
                Console.WriteLine("Svenska på");
            }
            else if (langBox.Text == "Engelska")
            {
                curEngine = engEngine;
                Console.WriteLine("Engelska på");
            }
            //printEngineInfo();
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

        private void Customize_profile_Click(object sender, EventArgs e)
        {
            var customize = new Customize_layout();
            customize.Show();
        }
        private void deactivateEngine()
        {
            label2.Text = "Status: OFF";
            Simulator.GetInstance().SendAxleStopCommand(1);
            Simulator.GetInstance().SendAxleStopCommand(2);
            curEngine.RecognizeAsyncStop();
            asyncOn = false;
        }
        private void VoiceControl_Deactivate(object sender, EventArgs e)
        {
            deactivateEngine();
        }
    }
}
