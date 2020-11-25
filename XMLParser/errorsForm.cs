using System;
using System.Windows.Forms;
using System.Xml;
using Google.Cloud.Translation.V2;
using FCA_Coding_generate;

namespace XMLParser
{
    public partial class errorsForm : Form
    {
        //GLOBAL VARIABLES
        SaveFileDialog saveFile = new SaveFileDialog();
        private Translate CS_Translate;

        // FORM INIT AND FORM LOAD EVENT 
        public errorsForm(XmlDocument xmld, string [] text, string[] number)
        {
            InitializeComponent();

            // LOCAL VARIABLES 

            XmlNodeList list = xmld.SelectNodes("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DISetVariantByName/ERRORS/DIGetComfortErrorCode//@result");
            XmlNode errorNode = xmld.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DISetVariantByName/ERRORS");

            // displaying errors

            richTextBox2.AppendText("dtc = {" + "\n" + "{" + " ");
            richTextBox2.AppendText('"' + number[0] + '"' + ", "+ '"' + number[0] + '"' + ", " + "ID_DTCTYPE_NONE" + ", " + '"' +text[0]+ '"' + " }" + "\n");
            richTextBox1.AppendText("Error nr :" + " " +number[0] + "\n\n" + text[0] + "\n\n");

            if (errorNode != null)
            {
                for (int i = 0; i < errorNode.ChildNodes.Count-1; i++) 
                {
                    richTextBox1.AppendText("Error nr :" + " " + number[i+1] + "\n\n" + text[i+1] + "\n\n"); 
                    richTextBox2.AppendText(","+"{"+'"' +number[i+1] + '"' + ", "+ '"' + number[i+1] + '"' + ", " + "ID_DTCTYPE_NONE" + ", " + '"' + text[i+1] + '"' + " }" +"\n" ); 
                }

                richTextBox2.AppendText( "}");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        // BUTTON_CLICK EVENTS
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
            saveFile.Dispose();
        }
        private void Translate_Click(object sender, EventArgs e)
        {
            // Your Google Cloud Platform project ID.
            /*string credential_path = Application.StartupPath + "/My_First_Project_00618ac966b2.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

            var message = "This is some html text to <strong>translate</strong>!";
            string targetLanguage = "fr";
            string sourceLanguage = null; // automatically detected
            var client = TranslationClient.Create();
            var response = client.TranslateHtml(message, targetLanguage, sourceLanguage);
            richTextBox2.Text = response.ToString();
         */
            this.CS_Translate = new Translate();
            string translated = "";
            CS_Translate.TranslateInit(Application.StartupPath + "\\My_First_Project_00618ac966b2.json");
            CS_Translate.TranslateText(this,"Das auto","de",ref translated );
            MessageBox.Show(translated.ToString());
        }        
    }
}
