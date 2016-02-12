using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;


namespace roststyrn
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("sv-SE"));
        private Choices commands;
        private GrammarBuilder gBuilder;
        private Grammar grammar;
        private bool asyncOn;
        private Simulator sim;
        private bool newInput;
        public Form1()
        {
            InitializeComponent();
            commands = new Choices();
            commands.Add(new string[] { "bord upp",
                                        "bord ner",
                                        "skärm närmre",
                                        "skärm bakåt",
                                        "stopp" });
            gBuilder = new GrammarBuilder();
            gBuilder.Culture = new System.Globalization.CultureInfo("sv-SE");
            gBuilder.Append(commands);
            grammar = new Grammar(gBuilder);
            try
            {
                recEngine.LoadGrammarAsync(grammar);
                recEngine.SetInputToDefaultAudioDevice();
                recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            }
            catch (UnauthorizedAccessException e) {
                Console.WriteLine("Error: UnauthorizedAccessException");
                Console.WriteLine(e.ToString());
            }
            asyncOn = false;
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //label1.Text = "Input: " + e.Result.Text.ToUpper().Replace(" ", "_");
            if (sim == null)
                return;
            switch (e.Result.Text)
            {
                case "bord upp":
                    sim.SendAxleMoveCommand(0, 80, 100);
                    break;
                case "bord ner":
                    sim.SendAxleMoveCommand(0, 20, 100);
                    break;
                case "skärm närmre":
                    sim.SendAxleMoveCommand(1, 50, 100);
                    break;
                case "skärm bakåt":
                    sim.SendAxleMoveCommand(1, 10, 100);
                    break;
                case "stopp":
                    sim.SendAxleStopCommand(0);
                    sim.SendAxleStopCommand(1);
                    label2.Text = "Status: OFF";
                    recEngine.RecognizeAsyncStop();
                    break;
            }
            
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
                    sim.SendAxleStopCommand(0);
                    sim.SendAxleStopCommand(1);
                }
                recEngine.RecognizeAsyncStop();
                asyncOn = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void startSimBtn_Click(object sender, EventArgs e)
        {
            if(sim == null) //only able to create 1
                sim = new Simulator();
            sim.Show();
        }
    }
}

