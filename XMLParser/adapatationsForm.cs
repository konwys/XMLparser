using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLParser
{
    public partial class adapatationsForm : Form
    {
        public adapatationsForm(XmlDocument xmld)
        {
            InitializeComponent();
            XmlNodeList idConfig = xmld.SelectNodes("//DiagServiceWithType/@name");
            XmlNodeList list = xmld.SelectNodes("//DiagServiceWithType");
            string  [] description = new string  [15000]; // !!
            string data = " daata";
            richTextBox1.AppendText("ecuAdaptation1 = { "+"\n"+"{"+"\n"); // beginning
            // first 
            for (int i = 0; i < idConfig.Count; i++)
            {
                for (int k = 0; k <=6; k++) 
                {
                   //description[k] = list.Item(i + 5).SelectNodes("//DIAGSERVICEPREPARATION").Item(2).InnerText;
                  //  richTextBox2.AppendText(description[k]);
                }
                richTextBox1.AppendText("{"+"\n"+ "{ app.ECUFEATURE_TEMPLATE,"+ idConfig.Item(5+i).InnerText +", ID_STR_ECUFEATURE_BUTTON_EXIT }," + "\n" 
                    +"{ app.ECUFEATURE_PARAMETER, " + description[i] + ", app.TYPE_RB, { "+ data + "}}");
            }
            richTextBox1.AppendText("}"); // end 

        }
        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
