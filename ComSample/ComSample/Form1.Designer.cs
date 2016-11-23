namespace GeneralLogger
{
    partial class GeneralLogger
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
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.refreshLogcat = new System.Windows.Forms.Button();
            this.comboBoxCaptureLogcat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPrefixLogcat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPrefix = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBitSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.refreshLogcat);
            this.groupBoxSettings.Controls.Add(this.comboBoxCaptureLogcat);
            this.groupBoxSettings.Controls.Add(this.label6);
            this.groupBoxSettings.Controls.Add(this.comboBoxPrefixLogcat);
            this.groupBoxSettings.Controls.Add(this.label5);
            this.groupBoxSettings.Controls.Add(this.comboBoxPrefix);
            this.groupBoxSettings.Controls.Add(this.label4);
            this.groupBoxSettings.Controls.Add(this.buttonClosePort);
            this.groupBoxSettings.Controls.Add(this.buttonOpenPort);
            this.groupBoxSettings.Controls.Add(this.label3);
            this.groupBoxSettings.Controls.Add(this.comboBoxBitSet);
            this.groupBoxSettings.Controls.Add(this.label2);
            this.groupBoxSettings.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.comboBoxCom);
            this.groupBoxSettings.Location = new System.Drawing.Point(17, 16);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSettings.Size = new System.Drawing.Size(267, 424);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Port Settings";
            // 
            // refreshLogcat
            // 
            this.refreshLogcat.Location = new System.Drawing.Point(8, 333);
            this.refreshLogcat.Margin = new System.Windows.Forms.Padding(4);
            this.refreshLogcat.Name = "refreshLogcat";
            this.refreshLogcat.Size = new System.Drawing.Size(250, 28);
            this.refreshLogcat.TabIndex = 16;
            this.refreshLogcat.Text = "Start / Refresh Logcat";
            this.refreshLogcat.UseVisualStyleBackColor = true;
            this.refreshLogcat.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCaptureLogcat
            // 
            this.comboBoxCaptureLogcat.FormattingEnabled = true;
            this.comboBoxCaptureLogcat.Location = new System.Drawing.Point(112, 277);
            this.comboBoxCaptureLogcat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCaptureLogcat.Name = "comboBoxCaptureLogcat";
            this.comboBoxCaptureLogcat.Size = new System.Drawing.Size(146, 24);
            this.comboBoxCaptureLogcat.TabIndex = 13;
            this.comboBoxCaptureLogcat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Capture Logcat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxPrefixLogcat
            // 
            this.comboBoxPrefixLogcat.FormattingEnabled = true;
            this.comboBoxPrefixLogcat.Location = new System.Drawing.Point(112, 235);
            this.comboBoxPrefixLogcat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPrefixLogcat.Name = "comboBoxPrefixLogcat";
            this.comboBoxPrefixLogcat.Size = new System.Drawing.Size(146, 24);
            this.comboBoxPrefixLogcat.TabIndex = 11;
            this.comboBoxPrefixLogcat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prefix Logcat";
            // 
            // comboBoxPrefix
            // 
            this.comboBoxPrefix.FormattingEnabled = true;
            this.comboBoxPrefix.Location = new System.Drawing.Point(113, 169);
            this.comboBoxPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPrefix.Name = "comboBoxPrefix";
            this.comboBoxPrefix.Size = new System.Drawing.Size(144, 24);
            this.comboBoxPrefix.TabIndex = 9;
            this.comboBoxPrefix.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prefix VSIM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.Enabled = false;
            this.buttonClosePort.Location = new System.Drawing.Point(139, 381);
            this.buttonClosePort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(119, 28);
            this.buttonClosePort.TabIndex = 7;
            this.buttonClosePort.Text = "Close";
            this.buttonClosePort.UseVisualStyleBackColor = true;
            this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(8, 381);
            this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(123, 28);
            this.buttonOpenPort.TabIndex = 6;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bit Set";
            // 
            // comboBoxBitSet
            // 
            this.comboBoxBitSet.FormattingEnabled = true;
            this.comboBoxBitSet.Location = new System.Drawing.Point(113, 128);
            this.comboBoxBitSet.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBitSet.Name = "comboBoxBitSet";
            this.comboBoxBitSet.Size = new System.Drawing.Size(144, 24);
            this.comboBoxBitSet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(113, 82);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(144, 24);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ComPort";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(113, 37);
            this.comboBoxCom.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(144, 24);
            this.comboBoxCom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reboot Device";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneralLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxSettings);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneralLogger";
            this.Text = "GeneralLogger";
            this.Load += new System.EventHandler(this.GeneralLogger_Load);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonClosePort;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBitSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPrefix;
        private System.Windows.Forms.ComboBox comboBoxPrefixLogcat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCaptureLogcat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshLogcat;
        private System.Windows.Forms.Button button1;
    }
}

