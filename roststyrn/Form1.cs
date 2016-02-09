using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace roststyrn
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        private Choices commands;
        private GrammarBuilder gBuilder;
        private Grammar grammar;
        private bool asyncOn;
        private Simulator sim;

        public Form1()
        {
            InitializeComponent();
            commands = new Choices();
            commands.Add(new string[] { "table up",
                                        "table down",
                                        "table stop",
                                        "screen closer",
                                        "screen back",
                                        "screen stop",
                                         "stop" });
            gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            asyncOn = false;
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "table up":
                    sim.SendAxleMoveCommand(0, 80, 100);
                    label1.Text = "Input: TABLE_UP";
                    break;
                case "table down":
                    sim.SendAxleMoveCommand(0, 20, 100);
                    label1.Text = "Input: TABLE_DOWN";
                    break;
                case "table stop":
                    sim.SendAxleStopCommand(0);
                    label1.Text = "Input: TABLE_STOP";
                    break;

                case "screen closer":
                    sim.SendAxleMoveCommand(1, 50, 100);
                    label1.Text = "Input: SCREEN_CLOSER";
                    break;
                case "screen back":
                    sim.SendAxleMoveCommand(1, 10, 100);
                    label1.Text = "Input: SCREEN_BACK";
                    break;
                case "screen stop":
                    sim.SendAxleStopCommand(1);
                    label1.Text = "Input: SCREEN_STOP";
                    break;
                case "stop":
                    sim.SendAxleStopCommand(0);
                    sim.SendAxleStopCommand(1);
                    label1.Text = "Input: STOP";
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
                recEngine.RecognizeAsync(RecognizeMode.Multiple);
                asyncOn = true;
                return true;
            }
            return false;
        }


        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R || e.KeyCode == Keys.ControlKey)
            {
                label2.Text = "Status: OFF";
                if(sim != null)
                    sim.SendAxleStopCommand(0);
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

