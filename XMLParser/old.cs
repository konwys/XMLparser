using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace XMLParser
{
    public partial class old : Form
    {
        // GLOBAL VARIABLES

        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        XmlDocument document = new XmlDocument();
        string[] errorNumber = new string[100]; // !!!!
        string[] errorText = new string[100]; // !!!!
        string[] errorDescription = new string[1000];
        bool buttonLoadClicked = false;

        // FORM INIT AND FORM LOAD EVENT 

        public old()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        // BUTTON_CLICKS EVENTS

        public void LoadXML_Click(object sender, EventArgs e)
        {
            buttonLoadClicked = true;
            openFile.Filter = "XML Files|*.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                document.Load(openFile.FileName);
                backgroundWorker1.RunWorkerAsync(openFile.FileName);
            }

            // getting variants

            XmlNodeList varriantList = document.SelectNodes("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject/@name");
            XmlNodeList basIsVariante = document.SelectNodes("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DISetVariantByName/@name");
            string varriantString = "";
            string basIsVarrianteString = "";

            // pulling varriants from xmlnodelist

            foreach (XmlNode varr in varriantList)
            {
                varriantString += varr.InnerText + "\n";
            }
            string[] varriantsTable = new string[varriantString.Length];
            varriantsTable = varriantString.Split('\n');

            // dynamically creating radiobuttons with variants for varobjects

            for (int i = 0; i < varriantsTable.Length-1; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new Point(6, i * 20 + 6);
                radioButton.Click += new EventHandler(RadioButton_Click);
                radioButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
                radioButton.Text = varriantsTable[i];
                varriantPanel.Controls.Add(radioButton);
            }

            // dynamically creating radiobuttons with variant BASISVARIANTE 
            
            foreach (XmlNode bas in basIsVariante)
            {
                basIsVarrianteString += bas.InnerText + "\n";
            }
            string[] basIsVarianteTable = new string[basIsVarrianteString.Length];
            basIsVarianteTable = basIsVarrianteString.Split('\n');         

            for (int i = 0; i < basIsVarianteTable.Length-1; i++)
            {
                RadioButton basIsRadioButton = new RadioButton();
                basIsRadioButton.AutoSize = true;
                basIsRadioButton.Location = new Point(220, i * 20 + 6);
                basIsRadioButton.Click += new EventHandler(RadioButton_Click);
                basIsRadioButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
                basIsRadioButton.Text = basIsVarianteTable[i];
                varriantPanel.Controls.Add(basIsRadioButton);
            }
            
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {   
            richTextBox1.Clear();
          
            RadioButton button = sender as RadioButton;
            string varriant = "";
            varriant = button.Text;
            XmlNode errorNodeCount = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject//ERRORS");
            for (int i = 0; i < errorNodeCount.ChildNodes.Count; i++)
            {
                if (button.Text == ">BASISVARIANTE<") // BASISVARIANTE exception
                {

                errorText[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DISetVariantByName/ERRORS/DIGetComfortErrorCode[@index='" + i + "']/DIGetErrorText").InnerText;
                errorNumber[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DISetVariantByName/ERRORS/DIGetComfortErrorCode[@index='" + i + "']/@result").Value;
                errorDescription[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DISetVariantByName/ERRORS/DIGetComfortErrorCode[@index='" + i + "']").InnerText;
                errorDescription[i] = errorDescription[i].Replace(";", ";" + Environment.NewLine);
                richTextBox1.AppendText("\n" + errorNumber[i] + " "+ errorDescription[i]+"\n");
                
                }
                else // the rest of variants
                {

                errorNumber[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject[@name='" + varriant + "']/CaesarGetListElement/ERRORS/DIGetComfortErrorCode[@index='" + i + "']/@result").InnerText;
                errorText[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject[@name='" + varriant + "']/CaesarGetListElement/ERRORS/DIGetComfortErrorCode[@index='" + i + "']/DIGetErrorText").InnerText; // error text 
                errorDescription[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject[@name='" + varriant + "']/CaesarGetListElement/ERRORS/DIGetComfortErrorCode[@index='" + i + "']").InnerText; // error description 
                errorDescription[i] = errorDescription[i].Replace(";", ";" + Environment.NewLine); // converting description to more legible form
                richTextBox1.AppendText("\n" + errorNumber[i]  + " " + errorDescription[i] + " " +  "\n\n");
                    
                }
            }        
        }
        private void Save_Click_1(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
            saveFile.Dispose();
        }
        private void Errors_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonLoadClicked)
                {
                    errorsForm ErrorsForm = new errorsForm(document,errorText,errorNumber);
                    ErrorsForm.Show();
                }
                else
                {
                    MessageBox.Show("Wybierz plik XML");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Tests_Click(object sender, EventArgs e)
        {
            testsForm TestsForm = new testsForm(document);
            TestsForm.Show();
        }

        // METHODS
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            if (inXmlNode.HasChildNodes) // if root has child nodes
            {
                nodeList = inXmlNode.ChildNodes;
                
                for (i = 0; i <nodeList.Count ; i++)
                    {

                   xNode = inXmlNode.ChildNodes[i];
                   treeView1.Invoke(new Action(delegate ()
                    {
                        inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    }));

                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                    
                    }
            }
            else
            {
                treeView1.Invoke(new Action(delegate ()
                {
                    inTreeNode.Text = (inXmlNode.OuterXml).Trim();
                }));
            }

            treeView1.Invoke(new Action(delegate ()
            {
                treeView1.Refresh();
            }));
            
        }

        // BACKGROUNDWORKER
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // CreateTreeView();
            treeView1.Invoke(new Action(delegate ()
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(new TreeNode(document.DocumentElement.Name)); // gets the root
            }));


            TreeNode tNode = new TreeNode();
            tNode = treeView1.Nodes[0];
            AddNode(document.DocumentElement, tNode);
        }

    }

        
    
}
