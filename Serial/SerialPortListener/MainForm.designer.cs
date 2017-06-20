﻿namespace SerialPortListener
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label dataBitsLabel;
            System.Windows.Forms.Label parityLabel;
            System.Windows.Forms.Label portNameLabel;
            System.Windows.Forms.Label stopBitsLabel;
            this.inBaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inDataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.inParityComboBox = new System.Windows.Forms.ComboBox();
            this.inPortNameComboBox = new System.Windows.Forms.ComboBox();
            this.inStopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outBaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outPotrNameLabel = new System.Windows.Forms.Label();
            this.outPortNameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            baudRateLabel = new System.Windows.Forms.Label();
            dataBitsLabel = new System.Windows.Forms.Label();
            parityLabel = new System.Windows.Forms.Label();
            portNameLabel = new System.Windows.Forms.Label();
            stopBitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new System.Drawing.Point(10, 59);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(61, 13);
            baudRateLabel.TabIndex = 1;
            baudRateLabel.Text = "Baud Rate:";
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new System.Drawing.Point(10, 86);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            dataBitsLabel.TabIndex = 3;
            dataBitsLabel.Text = "Data Bits:";
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new System.Drawing.Point(10, 113);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new System.Drawing.Size(36, 13);
            parityLabel.TabIndex = 5;
            parityLabel.Text = "Parity:";
            // 
            // portNameLabel
            // 
            portNameLabel.AutoSize = true;
            portNameLabel.Location = new System.Drawing.Point(10, 32);
            portNameLabel.Name = "portNameLabel";
            portNameLabel.Size = new System.Drawing.Size(60, 13);
            portNameLabel.TabIndex = 7;
            portNameLabel.Text = "Port Name:";
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Location = new System.Drawing.Point(10, 140);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            stopBitsLabel.TabIndex = 9;
            stopBitsLabel.Text = "Stop Bits:";
            // 
            // inBaudRateComboBox
            // 
            this.inBaudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inBaudRateComboBox.FormattingEnabled = true;
            this.inBaudRateComboBox.Location = new System.Drawing.Point(77, 56);
            this.inBaudRateComboBox.Name = "inBaudRateComboBox";
            this.inBaudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.inBaudRateComboBox.TabIndex = 2;
            // 
            // serialSettingsBindingSource
            // 
            this.serialSettingsBindingSource.DataSource = typeof(SerialPortListener.Serial.SerialSettings);
            // 
            // inDataBitsComboBox
            // 
            this.inDataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inDataBitsComboBox.FormattingEnabled = true;
            this.inDataBitsComboBox.Location = new System.Drawing.Point(77, 83);
            this.inDataBitsComboBox.Name = "inDataBitsComboBox";
            this.inDataBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.inDataBitsComboBox.TabIndex = 4;
            // 
            // inParityComboBox
            // 
            this.inParityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inParityComboBox.FormattingEnabled = true;
            this.inParityComboBox.Location = new System.Drawing.Point(77, 110);
            this.inParityComboBox.Name = "inParityComboBox";
            this.inParityComboBox.Size = new System.Drawing.Size(121, 21);
            this.inParityComboBox.TabIndex = 6;
            // 
            // inPortNameComboBox
            // 
            this.inPortNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inPortNameComboBox.FormattingEnabled = true;
            this.inPortNameComboBox.Location = new System.Drawing.Point(77, 29);
            this.inPortNameComboBox.Name = "inPortNameComboBox";
            this.inPortNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.inPortNameComboBox.TabIndex = 8;
            // 
            // inStopBitsComboBox
            // 
            this.inStopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inStopBitsComboBox.FormattingEnabled = true;
            this.inStopBitsComboBox.Location = new System.Drawing.Point(77, 137);
            this.inStopBitsComboBox.Name = "inStopBitsComboBox";
            this.inStopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.inStopBitsComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inBaudRateComboBox);
            this.groupBox1.Controls.Add(baudRateLabel);
            this.groupBox1.Controls.Add(this.inStopBitsComboBox);
            this.groupBox1.Controls.Add(stopBitsLabel);
            this.groupBox1.Controls.Add(dataBitsLabel);
            this.groupBox1.Controls.Add(this.inPortNameComboBox);
            this.groupBox1.Controls.Add(this.inDataBitsComboBox);
            this.groupBox1.Controls.Add(portNameLabel);
            this.groupBox1.Controls.Add(parityLabel);
            this.groupBox1.Controls.Add(this.inParityComboBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 171);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(152, 215);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start listening";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbData
            // 
            this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbData.Location = new System.Drawing.Point(12, 260);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(452, 199);
            this.tbData.TabIndex = 13;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(242, 215);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop listening";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outBaudRateComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.outPotrNameLabel);
            this.groupBox2.Controls.Add(this.outPortNameComboBox);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 171);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Settings";
            // 
            // outBaudRateComboBox
            // 
            this.outBaudRateComboBox.FormattingEnabled = true;
            this.outBaudRateComboBox.Location = new System.Drawing.Point(75, 56);
            this.outBaudRateComboBox.Name = "outBaudRateComboBox";
            this.outBaudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.outBaudRateComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // outPotrNameLabel
            // 
            this.outPotrNameLabel.AutoSize = true;
            this.outPotrNameLabel.Location = new System.Drawing.Point(6, 32);
            this.outPotrNameLabel.Name = "outPotrNameLabel";
            this.outPotrNameLabel.Size = new System.Drawing.Size(60, 13);
            this.outPotrNameLabel.TabIndex = 1;
            this.outPotrNameLabel.Text = "Port Name:";
            // 
            // outPortNameComboBox
            // 
            this.outPortNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "OutPortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.outPortNameComboBox.FormattingEnabled = true;
            this.outPortNameComboBox.Location = new System.Drawing.Point(75, 29);
            this.outPortNameComboBox.Name = "outPortNameComboBox";
            this.outPortNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.outPortNameComboBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSLog Plus";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.ComboBox inBaudRateComboBox;
        private System.Windows.Forms.ComboBox inDataBitsComboBox;
        private System.Windows.Forms.ComboBox inParityComboBox;
        private System.Windows.Forms.ComboBox inPortNameComboBox;
        private System.Windows.Forms.ComboBox inStopBitsComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox outPortNameComboBox;
        private System.Windows.Forms.ComboBox outBaudRateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outPotrNameLabel;
        private System.Windows.Forms.Button button1;
    }
}

