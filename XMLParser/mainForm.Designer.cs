namespace XMLParser
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Adaptations = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tests = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Errors = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Load_XML = new System.Windows.Forms.Button();
            this.treeView1 = new BufferedTreeView();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.Load_XML);
            this.panel1.Controls.Add(this.Adaptations);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Tests);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Errors);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 562);
            this.panel1.TabIndex = 15;
            // 
            // Adaptations
            // 
            this.Adaptations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Adaptations.FlatAppearance.BorderSize = 0;
            this.Adaptations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adaptations.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Adaptations.ForeColor = System.Drawing.Color.Gray;
            this.Adaptations.Location = new System.Drawing.Point(0, 244);
            this.Adaptations.Name = "Adaptations";
            this.Adaptations.Size = new System.Drawing.Size(170, 35);
            this.Adaptations.TabIndex = 22;
            this.Adaptations.Text = "VIEW ADAPTATIONS";
            this.Adaptations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adaptations.UseVisualStyleBackColor = false;
            this.Adaptations.Click += new System.EventHandler(this.Adaptations_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "ECU";
            // 
            // Tests
            // 
            this.Tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Tests.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Tests.FlatAppearance.BorderSize = 0;
            this.Tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tests.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tests.ForeColor = System.Drawing.Color.Gray;
            this.Tests.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tests.Location = new System.Drawing.Point(0, 209);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(170, 38);
            this.Tests.TabIndex = 21;
            this.Tests.Text = "VIEW TESTS";
            this.Tests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tests.UseVisualStyleBackColor = false;
            this.Tests.Click += new System.EventHandler(this.Tests_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "MAXI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Save.ForeColor = System.Drawing.Color.Gray;
            this.Save.Location = new System.Drawing.Point(0, 275);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(170, 35);
            this.Save.TabIndex = 13;
            this.Save.Text = "SAVE DESCRIPTION";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Errors
            // 
            this.Errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Errors.FlatAppearance.BorderSize = 0;
            this.Errors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Errors.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Errors.ForeColor = System.Drawing.Color.Gray;
            this.Errors.Location = new System.Drawing.Point(0, 177);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(170, 35);
            this.Errors.TabIndex = 8;
            this.Errors.Text = "VIEW ERRORS";
            this.Errors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Errors.UseVisualStyleBackColor = false;
            this.Errors.Click += new System.EventHandler(this.Errors_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close.ForeColor = System.Drawing.Color.Gray;
            this.Close.Image = global::XMLParser.Properties.Resources._switch;
            this.Close.Location = new System.Drawing.Point(3, 347);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(170, 35);
            this.Close.TabIndex = 9;
            this.Close.Text = "CLOSE APP";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "MENU";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Controls.Add(this.treeView1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(170, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(779, 562);
            this.panelChildForm.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 54);
            this.panel2.TabIndex = 1;
            // 
            // Load_XML
            // 
            this.Load_XML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Load_XML.FlatAppearance.BorderSize = 0;
            this.Load_XML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_XML.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Load_XML.ForeColor = System.Drawing.Color.Gray;
            this.Load_XML.Location = new System.Drawing.Point(0, 142);
            this.Load_XML.Name = "Load_XML";
            this.Load_XML.Size = new System.Drawing.Size(170, 35);
            this.Load_XML.TabIndex = 23;
            this.Load_XML.Text = "LOAD XML";
            this.Load_XML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load_XML.UseVisualStyleBackColor = false;
            this.Load_XML.Click += new System.EventHandler(this.Load_XML_Click);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(414, 57);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(365, 505);
            this.treeView1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 562);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(965, 601);
            this.Name = "mainForm";
            this.Text = "Parser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Tests;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Errors;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChildForm;
        private BufferedTreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Adaptations;
        private System.Windows.Forms.Button Load_XML;
    }
}