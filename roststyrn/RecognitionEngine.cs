using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roststyrn
{
    class RecognitionEngine
    {
        private static System.Globalization.CultureInfo culture;
        private static SpeechRecognitionEngine recEngine;
        private static Choices choices;
        private static GrammarBuilder grammarBuilder;
        private static Grammar grammar;
        private static bool init;

        public static SpeechRecognitionEngine getEngine(String lang)
        {
            if(init)
                recEngine.Dispose();
            Console.WriteLine("Kastat current engine");
            culture = new System.Globalization.CultureInfo(lang);
            choices = new Choices();
            grammarBuilder = new GrammarBuilder();
            VoiceCommands.Init(lang);
            choices.Add(VoiceCommands.GetAllCommands());
            grammarBuilder.Culture = culture;
            grammarBuilder.Append(choices);
            grammar = new Grammar(grammarBuilder);
            Console.WriteLine("Initialiserat svenskt grammar");
            try
            {
                recEngine = new SpeechRecognitionEngine(culture);
                recEngine.LoadGrammarAsync(grammar);
                Console.WriteLine("Laddat enginen med " + lang);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Error: UnauthorizedAccessException");
                Console.WriteLine(e.ToString());
            } 
            init = true;
            recEngine.SetInputToDefaultAudioDevice();
            return recEngine;
        }
    }
}
