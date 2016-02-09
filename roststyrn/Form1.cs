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
            commands.Add(new string[] { "table up", "table down", "stop" });
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
                    sim.SendMoveAxleCommand(0, 100, 100);
                    label1.Text = "TABLE UP";
                    break;
                case "table down":
                    sim.SendMoveAxleCommand(0, 0, 100);
                    label1.Text = "TABLE DOWN";
                    break;
                case "stop":
                    sim.SendStop(0);
                    label2.Text = "AV";
                    recEngine.RecognizeAsyncStop();
                    break;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Control | Keys.R)) && asyncOn == false)
            {
                label2.Text = "PÅ";
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
                label2.Text = "AV";
                sim.SendStop(0);
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

