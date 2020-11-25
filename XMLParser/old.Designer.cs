namespace XMLParser
{
    partial class old
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadXML = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Errors = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tests = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView1 = new BufferedTreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.varriantPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadXML
            // 
            this.LoadXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LoadXML.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoadXML.FlatAppearance.BorderSize = 0;
            this.LoadXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadXML.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadXML.ForeColor = System.Drawing.Color.Gray;
            this.LoadXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadXML.Location = new System.Drawing.Point(0, 44);
            this.LoadXML.Name = "LoadXML";
            this.LoadXML.Size = new System.Drawing.Size(113, 38);
            this.LoadXML.TabIndex = 0;
            this.LoadXML.Text = "LOAD XML";
            this.LoadXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadXML.UseVisualStyleBackColor = false;
            this.LoadXML.Click += new System.EventHandler(this.LoadXML_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Errors
            // 
            this.Errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Errors.FlatAppearance.BorderSize = 0;
            this.Errors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Errors.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Errors.ForeColor = System.Drawing.Color.Gray;
            this.Errors.Location = new System.Drawing.Point(0, 78);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(113, 35);
            this.Errors.TabIndex = 8;
            this.Errors.Text = "ERRORS";
            this.Errors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Errors.UseVisualStyleBackColor = false;
            this.Errors.Click += new System.EventHandler(this.Errors_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close.ForeColor = System.Drawing.Color.Gray;
            this.Close.Location = new System.Drawing.Point(0, 175);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(113, 35);
            this.Close.TabIndex = 9;
            this.Close.Text = "CLOSE";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "MENU";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Save.ForeColor = System.Drawing.Color.Gray;
            this.Save.Location = new System.Drawing.Point(0, 144);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 35);
            this.Save.TabIndex = 13;
            this.Save.Text = "SAVE";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.Tests);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Errors);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoadXML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 566);
            this.panel1.TabIndex = 14;
            // 
            // Tests
            // 
            this.Tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Tests.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Tests.FlatAppearance.BorderSize = 0;
            this.Tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tests.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tests.ForeColor = System.Drawing.Color.Gray;
            this.Tests.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tests.Location = new System.Drawing.Point(0, 109);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(113, 38);
            this.Tests.TabIndex = 21;
            this.Tests.Text = "TESTS";
            this.Tests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tests.UseVisualStyleBackColor = false;
            this.Tests.Click += new System.EventHandler(this.Tests_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(110, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 219);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.treeView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(471, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 522);
            this.panel4.TabIndex = 17;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(371, 522);
            this.treeView1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.richTextBox1.Location = new System.Drawing.Point(113, 297);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 269);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "VARIANTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(362, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "TREE VIEW";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(113, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 44);
            this.panel2.TabIndex = 15;
            // 
            // varriantPanel
            // 
            this.varriantPanel.AutoScroll = true;
            this.varriantPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.varriantPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.varriantPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varriantPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.varriantPanel.Location = new System.Drawing.Point(113, 44);
            this.varriantPanel.Name = "varriantPanel";
            this.varriantPanel.Size = new System.Drawing.Size(358, 221);
            this.varriantPanel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "FULL DESCRIPTION";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(113, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 32);
            this.panel5.TabIndex = 20;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.varriantPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;    
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private BufferedTreeView treeView1;
        private System.Windows.Forms.Button Errors;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel varriantPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Tests;
        private System.Windows.Forms.Panel panel5;
    }
}

