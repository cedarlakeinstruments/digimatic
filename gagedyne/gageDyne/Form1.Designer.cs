namespace gageDyne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            buttonConnect = new Button();
            listBoxPorts = new ListBox();
            panel1 = new Panel();
            labelUnits = new Label();
            labelData = new Label();
            comboBoxSides = new ComboBox();
            buttonRecord = new Button();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(comboBoxSides);
            flowLayoutPanel1.Controls.Add(buttonRecord);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(814, 531);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonConnect);
            groupBox1.Controls.Add(listBoxPorts);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Communications";
            // 
            // buttonConnect
            // 
            buttonConnect.Enabled = false;
            buttonConnect.Location = new Point(6, 59);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(149, 41);
            buttonConnect.TabIndex = 1;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // listBoxPorts
            // 
            listBoxPorts.FormattingEnabled = true;
            listBoxPorts.ItemHeight = 21;
            listBoxPorts.Location = new Point(6, 28);
            listBoxPorts.Name = "listBoxPorts";
            listBoxPorts.Size = new Size(149, 25);
            listBoxPorts.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelUnits);
            panel1.Controls.Add(labelData);
            panel1.Location = new Point(164, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 219);
            panel1.TabIndex = 1;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUnits.Location = new Point(406, 102);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(76, 45);
            labelUnits.TabIndex = 1;
            labelUnits.Text = "mm";
            labelUnits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelData.Location = new Point(65, 35);
            labelData.Name = "labelData";
            labelData.Size = new Size(335, 128);
            labelData.TabIndex = 0;
            labelData.Text = "1.2345";
            labelData.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxSides
            // 
            comboBoxSides.FormattingEnabled = true;
            comboBoxSides.Location = new Point(3, 228);
            comboBoxSides.Name = "comboBoxSides";
            comboBoxSides.Size = new Size(478, 29);
            comboBoxSides.TabIndex = 2;
            // 
            // buttonRecord
            // 
            buttonRecord.Location = new Point(487, 228);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(148, 29);
            buttonRecord.TabIndex = 3;
            buttonRecord.Text = "Save";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(814, 531);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Gage Display";
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private ListBox listBoxPorts;
        private Panel panel1;
        private Button buttonConnect;
        private Label labelData;
        private Label labelUnits;
        private ComboBox comboBoxSides;
        private Button buttonRecord;
    }
}
