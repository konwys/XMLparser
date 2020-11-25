using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace XMLParser
{
    public partial class testsForm : Form
    {
        // GLOBAL VARIABLES
        SaveFileDialog saveFile = new SaveFileDialog();
        string data = " ?DATA?";

        // FORM INIT AND FORM LOAD EVENT 
        public testsForm(XmlDocument xmld)
        {
            InitializeComponent();
            XmlNodeList csNumber = xmld.SelectNodes("//DiagServiceWithType[starts-with(@name,'RT')]/DIOpenDiagService/DIDiagServiceRetrieveRequestMessage/@request");
            XmlNodeList dsName = xmld.SelectNodes("//DiagServiceWithType[starts-with(@name,'RT')]/@name");

            for(int i = 0; i < csNumber.Count; i++)
            {
                richTextBox1.AppendText(dsName.Item(i).InnerText+"\n"+csNumber.Item(i).InnerText+"\n");
            }

            richTextBox2.AppendText("ecuTest1 = {" + "\n");

            for (int i = 0; i <= csNumber.Count-1; i++)
            {
                richTextBox2.AppendText(" {" + "\n" + "   {" + " app.ECUFEATURE_TEMPLATE," + '"'+ dsName.Item(i).InnerText +'"'+ " ,ID_STR_ECUFEATURE_BUTTON_EXIT }," + "\n" + "" +
                "   { app.ECUFEATURE_ACTION," + '"' + "test_" + i + "_on " + '"' + ", app.WAITDIALOG_NONE,ID_ON }" + "\n" + "   { app.ECUFEATURE_ACTION, " +
                '"' + "test_" + i + "_off" + '"' + ", app.WAITDIALOG_NONE, ID_VALUE_OFF_V9}" + "\n" + " }," + "\n");

            }

            for (int i = 0; i <csNumber.Count; i++)
            {
                richTextBox2.AppendText("function test_"+i+ "_on()   return FEATURETOOLS.ecuTestGeneral(ELM_SEND,normalizeFrames,"+'"' + csNumber.Item(i).InnerText +
                    '"' +")  end"+"\n"+ "function test_" + i + "_off()  return FEATURETOOLS.ecuTestGeneral(ELM_SEND,normalizeFrames," + '"' + csNumber.Item(i).InnerText + '"' + ")  end" + "\n\n");
            }

        }
        
        private void testsForm_Load(object sender, EventArgs e)
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
    }
}
