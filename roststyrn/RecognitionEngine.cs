﻿using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roststyrn
{
    class RecognitionEngine
    {
        private static System.Globalization.CultureInfo sweCulture;
        private static System.Globalization.CultureInfo engCulture;
        private static SpeechRecognitionEngine recEngine;
        private static Choices sweChoices;
        private static GrammarBuilder sweGBuilder;
        private static Grammar sweGrammar;
        private static Choices engChoices;
        private static GrammarBuilder engGBuilder;
        private static Grammar engGrammar;
        private static bool init;


        public static SpeechRecognitionEngine getEngine(String lang)
        {
            if(init)
                recEngine.Dispose();
            Console.WriteLine("Kastat current engine");
            if(lang == "swe")
            {
                sweCulture = new System.Globalization.CultureInfo("sv-SE");
                sweChoices = new Choices();
                sweGBuilder = new GrammarBuilder();
                VoiceCommands.Init("sv-SE");
                sweChoices.Add(VoiceCommands.GetAllCommands());
                sweGBuilder.Culture = sweCulture;
                sweGBuilder.Append(sweChoices);
                sweGrammar = new Grammar(sweGBuilder);
                Console.WriteLine("Initialiserat svenskt grammar");
                try
                {
                    recEngine = new SpeechRecognitionEngine(sweCulture);
                    recEngine.LoadGrammarAsync(sweGrammar);
                    Console.WriteLine("Laddat enginen med svenska");
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Error: UnauthorizedAccessException");
                    Console.WriteLine(e.ToString());
                }
                
            }
            else if(lang == "eng")
            {
                engCulture = new System.Globalization.CultureInfo("en-US");
                engChoices = new Choices();
                VoiceCommands.Init("en-US");
                engChoices.Add(VoiceCommands.GetAllCommands());
                engGBuilder = new GrammarBuilder();
                engGBuilder.Culture = engCulture;
                engGBuilder.Append(engChoices);
                engGrammar = new Grammar(engGBuilder);
                Console.WriteLine("Initialiserat engelskt grammar");
                try
                {
                    recEngine = new SpeechRecognitionEngine(engCulture);
                    recEngine.LoadGrammarAsync(engGrammar);
                    Console.WriteLine("Laddat enginen med engelska");
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Error: UnauthorizedAccessException");
                    Console.WriteLine(e.ToString());
                }

            }
            init = true;
            recEngine.SetInputToDefaultAudioDevice();
            return recEngine;
        }

    }
}