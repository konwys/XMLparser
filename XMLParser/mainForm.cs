using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using FCA_Coding_generate;

namespace XMLParser
{ 
    public partial class mainForm : Form
    {
        // INIT
        private Translate CS_Translate;
        public mainForm()
        {
            InitializeComponent();
            // backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            this.CS_Translate = new Translate();
            CS_Translate.TranslateInit(Application.StartupPath + "\\My_First_Project_00618ac966b2.json");
        }

        // GLOBAL VARIABLES
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        XmlDocument document = new XmlDocument();
        string[] errorNumber = new string[100]; 
        string[] errorText = new string[100]; 
        string[] errorDescription = new string[1000]; 
        bool buttonLoadClicked = false;
        RichTextBox richTextBox1 = new RichTextBox();
        Panel varriantPanel = new Panel();
        Label varianLabel = new Label();
        Label treeViewLabel = new Label();
        private Form activeForm = null;

        // BUTTON_CLICK_EVENTS
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load_XML_Click(object sender, EventArgs e)
        {
            buttonLoadClicked = true;
            openFile.Filter = "XML Files|*.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                document.Load(openFile.FileName);
                backgroundWorker1.RunWorkerAsync(openFile.FileName);
            }

            #region designing controls 

            // VARIANT PANEL
            varriantPanel.AutoScroll = true;
            varriantPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            varriantPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            varriantPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            varriantPanel.Location = new System.Drawing.Point(0, 0);
            varriantPanel.Name = "varriantPanel";
            varriantPanel.Size = new System.Drawing.Size(413, 245);
            varriantPanel.TabIndex = 20;
            panelChildForm.Controls.Add(varriantPanel);

            // TREE VIEW LABEL 
            treeViewLabel.AutoSize = true;
            treeViewLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            treeViewLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeViewLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            treeViewLabel.Location = new System.Drawing.Point(412, 25);
            treeViewLabel.Name = "label2";
            treeViewLabel.Size = new System.Drawing.Size(196, 20);
            treeViewLabel.TabIndex = 11;
            treeViewLabel.Text = "TREE VIEW";
            panel2.Controls.Add(treeViewLabel);

            // VARIANT LABEL
            varianLabel.AutoSize = true;
            varianLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            varianLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            varianLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            varianLabel.Location = new System.Drawing.Point(3, 25);
            varianLabel.Name = "label3";
            varianLabel.Size = new System.Drawing.Size(112, 20);
            varianLabel.TabIndex = 12;
            varianLabel.Text = "VARIANTS";
            panel2.Controls.Add(varianLabel);

            #endregion

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

            for (int i = 0; i < varriantsTable.Length - 1; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new Point(6, i * 20 + 56);
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

            for (int i = 0; i < basIsVarianteTable.Length - 1; i++)
            {
                RadioButton basIsRadioButton = new RadioButton();
                basIsRadioButton.AutoSize = true;
                basIsRadioButton.Location = new Point(220, i * 20 + 56);
                basIsRadioButton.Click += new EventHandler(RadioButton_Click);
                basIsRadioButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
                basIsRadioButton.Text = basIsVarianteTable[i];
                varriantPanel.Controls.Add(basIsRadioButton);
            }
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {
            // designing RICHTEXTBOX
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            richTextBox1.Location = new System.Drawing.Point(4, 284);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(413, 278);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";

            panelChildForm.Controls.Add(richTextBox1);
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
                    richTextBox1.AppendText("\n" + errorNumber[i] + " " + errorDescription[i] + "\n");

                }
                else // the rest of variants
                {

                    errorNumber[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject[@name='" + varriant + "']/CaesarGetListElement/ERRORS/DIGetComfortErrorCode[@index='" + i + "']/@result").InnerText;
                    errorText[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject[@name='" + varriant + "']/CaesarGetListElement/ERRORS/DIGetComfortErrorCode[@index='" + i + "']/DIGetErrorText").InnerText; // error text 
                    errorDescription[i] = document.SelectSingleNode("/FILECBF/DIListECU/ECU/DIECUGetInterfaceByIndex/ECUINTERFACE/DIListVariants/VarObject[@name='" + varriant + "']/CaesarGetListElement/ERRORS/DIGetComfortErrorCode[@index='" + i + "']").InnerText; // error description 
                    errorDescription[i] = errorDescription[i].Replace(";", ";" + Environment.NewLine); // converting description to more legible form
                    richTextBox1.AppendText("\n" + errorNumber[i] + " " + errorDescription[i] + " " + "\n\n");

                }
            }
        }
        private void Errors_Click(object sender, EventArgs e)
        {
           // panelChildForm.Controls.Clear();
            try
            {
                if (buttonLoadClicked)
                {
                    openChildForm(new errorsForm(document, errorText, errorNumber));
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
        private void Tests_Click(object sender, EventArgs e)
        {
            openChildForm(new testsForm(document));
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
            saveFile.Dispose();
        }
        private void Adaptations_Click(object sender, EventArgs e)
        {
            openChildForm(new adapatationsForm(document));
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

                for (i = 0; i < nodeList.Count; i++)
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
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // BACKGROUNDWORKER
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
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
