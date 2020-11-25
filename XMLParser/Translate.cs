using System;
using Google.Cloud.Translation.V2;
using XMLParser;

namespace FCA_Coding_generate
{
    class Translate
    {
        public void TranslateInit(string credential_path)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            string neww = "";
        }
        public bool TranslateText( errorsForm form, string input_text, string language, ref string translatedText)
        {
            try
            {
                TranslationClient client = TranslationClient.Create();

                var translated = client.TranslateText(input_text, language, "en", TranslationModel.NeuralMachineTranslation);
                translatedText = translated.TranslatedText;

            }
            catch( Exception ex)
            {
                string test = ex.ToString();

            }


            bool result = false;


            return result;
        }

    }
}
