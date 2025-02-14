namespace LaserComputeLab
{
    partial class ManagerCOM
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
            this.portselector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scanpotrs = new System.Windows.Forms.Button();
            this.chooseport = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.portdisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.speedselector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // portselector
            // 
            this.portselector.Enabled = false;
            this.portselector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portselector.FormattingEnabled = true;
            this.portselector.Items.AddRange(new object[] {
            "Нет"});
            this.portselector.Location = new System.Drawing.Point(233, 25);
            this.portselector.Name = "portselector";
            this.portselector.Size = new System.Drawing.Size(121, 24);
            this.portselector.TabIndex = 0;
            this.portselector.Text = "Нет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбирите рабочий порт";
            // 
            // scanpotrs
            // 
            this.scanpotrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanpotrs.Location = new System.Drawing.Point(15, 130);
            this.scanpotrs.Name = "scanpotrs";
            this.scanpotrs.Size = new System.Drawing.Size(238, 36);
            this.scanpotrs.TabIndex = 2;
            this.scanpotrs.Text = "Сканировать";
            this.scanpotrs.UseVisualStyleBackColor = true;
            this.scanpotrs.Click += new System.EventHandler(this.scanpotrs_Click);
            // 
            // chooseport
            // 
            this.chooseport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseport.Location = new System.Drawing.Point(505, 130);
            this.chooseport.Name = "chooseport";
            this.chooseport.Size = new System.Drawing.Size(238, 36);
            this.chooseport.TabIndex = 3;
            this.chooseport.Text = "Выбрать";
            this.chooseport.UseVisualStyleBackColor = true;
            this.chooseport.Click += new System.EventHandler(this.chooseport_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // portdisconnect
            // 
            this.portdisconnect.Enabled = false;
            this.portdisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portdisconnect.Location = new System.Drawing.Point(259, 130);
            this.portdisconnect.Name = "portdisconnect";
            this.portdisconnect.Size = new System.Drawing.Size(238, 36);
            this.portdisconnect.TabIndex = 4;
            this.portdisconnect.Text = "Отключиться";
            this.portdisconnect.UseVisualStyleBackColor = true;
            this.portdisconnect.Click += new System.EventHandler(this.portdisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выбирите скорость передачи";
            // 
            // speedselector
            // 
            this.speedselector.Enabled = false;
            this.speedselector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedselector.FormattingEnabled = true;
            this.speedselector.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "20000000"});
            this.speedselector.Location = new System.Drawing.Point(233, 74);
            this.speedselector.Name = "speedselector";
            this.speedselector.Size = new System.Drawing.Size(121, 24);
            this.speedselector.TabIndex = 5;
            this.speedselector.Text = "9600";
            this.speedselector.SelectedIndexChanged += new System.EventHandler(this.speedselector_SelectedIndexChanged);
            // 
            // ManagerCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedselector);
            this.Controls.Add(this.portdisconnect);
            this.Controls.Add(this.chooseport);
            this.Controls.Add(this.scanpotrs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portselector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagerCOM";
            this.Text = "Менеджер подключений COM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portselector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scanpotrs;
        private System.Windows.Forms.Button chooseport;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button portdisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox speedselector;
    }
}