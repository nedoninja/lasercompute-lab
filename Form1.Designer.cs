namespace LaserComputeLab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.managerCOM = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectedStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.correct = new System.Windows.Forms.GroupBox();
            this.roof1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.floor1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.groupDebug = new System.Windows.Forms.GroupBox();
            this.clearDebug = new System.Windows.Forms.Button();
            this.debugInput = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.computeAccuracy = new System.Windows.Forms.Button();
            this.accuracy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultProb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.lblnumB = new System.Windows.Forms.Label();
            this.lblnumA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labindex = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panel0.SuspendLayout();
            this.correct.SuspendLayout();
            this.groupDebug.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools,
            this.toolStripSeparator1,
            this.connectedStatus,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tools
            // 
            this.tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerCOM,
            this.debugToolStrip});
            this.tools.Image = ((System.Drawing.Image)(resources.GetObject("tools.Image")));
            this.tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(117, 24);
            this.tools.Text = "Инструменты";
            // 
            // managerCOM
            // 
            this.managerCOM.Name = "managerCOM";
            this.managerCOM.Size = new System.Drawing.Size(303, 26);
            this.managerCOM.Text = "Менеджер подключений COM";
            this.managerCOM.Click += new System.EventHandler(this.managerCOM_Click);
            // 
            // debugToolStrip
            // 
            this.debugToolStrip.CheckOnClick = true;
            this.debugToolStrip.Name = "debugToolStrip";
            this.debugToolStrip.Size = new System.Drawing.Size(303, 26);
            this.debugToolStrip.Text = "Отладчик";
            this.debugToolStrip.CheckedChanged += new System.EventHandler(this.debugToolStrip_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // connectedStatus
            // 
            this.connectedStatus.Name = "connectedStatus";
            this.connectedStatus.Size = new System.Drawing.Size(119, 24);
            this.connectedStatus.Text = "Не подключено";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(168, 24);
            this.toolStripButton1.Text = "Запуск вычисления";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelBase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labindex);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 638);
            this.splitContainer1.SplitterDistance = 779;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panel0);
            this.panelBase.Controls.Add(this.label4);
            this.panelBase.Controls.Add(this.label3);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(779, 638);
            this.panelBase.TabIndex = 11;
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.correct);
            this.panel0.Controls.Add(this.groupDebug);
            this.panel0.Controls.Add(this.groupBox3);
            this.panel0.Controls.Add(this.groupBox2);
            this.panel0.Controls.Add(this.groupBox1);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(0, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(779, 638);
            this.panel0.TabIndex = 0;
            this.panel0.Visible = false;
            // 
            // correct
            // 
            this.correct.Controls.Add(this.roof1);
            this.correct.Controls.Add(this.label6);
            this.correct.Controls.Add(this.floor1);
            this.correct.Controls.Add(this.label5);
            this.correct.Controls.Add(this.btnCorrect);
            this.correct.Location = new System.Drawing.Point(12, 270);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(748, 86);
            this.correct.TabIndex = 10;
            this.correct.TabStop = false;
            this.correct.Text = "Коректировка";
            // 
            // roof1
            // 
            this.roof1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roof1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roof1.Location = new System.Drawing.Point(616, 35);
            this.roof1.Name = "roof1";
            this.roof1.ReadOnly = true;
            this.roof1.Size = new System.Drawing.Size(61, 22);
            this.roof1.TabIndex = 14;
            this.roof1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Пол единицы:";
            // 
            // floor1
            // 
            this.floor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floor1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.floor1.Location = new System.Drawing.Point(417, 35);
            this.floor1.Name = "floor1";
            this.floor1.ReadOnly = true;
            this.floor1.Size = new System.Drawing.Size(61, 22);
            this.floor1.TabIndex = 12;
            this.floor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Потолок единицы:";
            // 
            // btnCorrect
            // 
            this.btnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrect.Location = new System.Drawing.Point(9, 32);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(271, 28);
            this.btnCorrect.TabIndex = 12;
            this.btnCorrect.Text = "Провести корректировку";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // groupDebug
            // 
            this.groupDebug.Controls.Add(this.clearDebug);
            this.groupDebug.Controls.Add(this.debugInput);
            this.groupDebug.Location = new System.Drawing.Point(12, 362);
            this.groupDebug.Name = "groupDebug";
            this.groupDebug.Size = new System.Drawing.Size(748, 267);
            this.groupDebug.TabIndex = 9;
            this.groupDebug.TabStop = false;
            this.groupDebug.Text = "Debug-информация";
            this.groupDebug.Visible = false;
            // 
            // clearDebug
            // 
            this.clearDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDebug.Location = new System.Drawing.Point(601, 230);
            this.clearDebug.Name = "clearDebug";
            this.clearDebug.Size = new System.Drawing.Size(132, 28);
            this.clearDebug.TabIndex = 15;
            this.clearDebug.Text = "Очистить";
            this.clearDebug.UseVisualStyleBackColor = true;
            this.clearDebug.Click += new System.EventHandler(this.clearDebug_Click);
            // 
            // debugInput
            // 
            this.debugInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.debugInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugInput.Location = new System.Drawing.Point(0, 21);
            this.debugInput.Name = "debugInput";
            this.debugInput.ReadOnly = true;
            this.debugInput.Size = new System.Drawing.Size(733, 203);
            this.debugInput.TabIndex = 0;
            this.debugInput.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 96);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выходные данные";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(9, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.computeAccuracy);
            this.groupBox2.Controls.Add(this.accuracy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.resultProb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(321, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 148);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прогнозирование";
            // 
            // computeAccuracy
            // 
            this.computeAccuracy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeAccuracy.Location = new System.Drawing.Point(9, 89);
            this.computeAccuracy.Name = "computeAccuracy";
            this.computeAccuracy.Size = new System.Drawing.Size(311, 28);
            this.computeAccuracy.TabIndex = 11;
            this.computeAccuracy.Text = "Проверка на точность";
            this.computeAccuracy.UseVisualStyleBackColor = true;
            // 
            // accuracy
            // 
            this.accuracy.BackColor = System.Drawing.SystemColors.Control;
            this.accuracy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accuracy.Enabled = false;
            this.accuracy.Location = new System.Drawing.Point(220, 52);
            this.accuracy.Name = "accuracy";
            this.accuracy.ReadOnly = true;
            this.accuracy.Size = new System.Drawing.Size(100, 22);
            this.accuracy.TabIndex = 10;
            this.accuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Точность";
            // 
            // resultProb
            // 
            this.resultProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultProb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultProb.Location = new System.Drawing.Point(220, 25);
            this.resultProb.Name = "resultProb";
            this.resultProb.ReadOnly = true;
            this.resultProb.Size = new System.Drawing.Size(100, 22);
            this.resultProb.TabIndex = 8;
            this.resultProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Прогнозируемый результат:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.numB);
            this.groupBox1.Controls.Add(this.numA);
            this.groupBox1.Controls.Add(this.lblnumB);
            this.groupBox1.Controls.Add(this.lblnumA);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вводимые данные";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Location = new System.Drawing.Point(242, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(38, 73);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "      A\n+    B\n--------\n   C S";
            // 
            // numB
            // 
            this.numB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numB.Location = new System.Drawing.Point(75, 62);
            this.numB.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(66, 22);
            this.numB.TabIndex = 5;
            this.numB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numA
            // 
            this.numA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numA.Location = new System.Drawing.Point(75, 27);
            this.numA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(66, 22);
            this.numA.TabIndex = 4;
            this.numA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnumB
            // 
            this.lblnumB.AutoSize = true;
            this.lblnumB.Location = new System.Drawing.Point(6, 64);
            this.lblnumB.Name = "lblnumB";
            this.lblnumB.Size = new System.Drawing.Size(63, 16);
            this.lblnumB.TabIndex = 1;
            this.lblnumB.Text = "Цифра B";
            // 
            // lblnumA
            // 
            this.lblnumA.AutoSize = true;
            this.lblnumA.Location = new System.Drawing.Point(6, 29);
            this.lblnumA.Name = "lblnumA";
            this.lblnumA.Size = new System.Drawing.Size(63, 16);
            this.lblnumA.TabIndex = 0;
            this.lblnumA.Text = "Цифра A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 175);
            this.label4.TabIndex = 1;
            this.label4.Text = "Программа выполнения лабороторных опытов и тестирования \r\nвычислительных систем н" +
    "а лазерах.\r\n\r\nАвторы научной работы:\r\nГорлов Тимофей\r\nСеменов Святослав\r\nЛангас " +
    "Владислав";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Laser Compute Lab v1.0";
            // 
            // labindex
            // 
            this.labindex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labindex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labindex.FormattingEnabled = true;
            this.labindex.ItemHeight = 16;
            this.labindex.Items.AddRange(new object[] {
            "Стартовый экран",
            "1-разрядный сумматор"});
            this.labindex.Location = new System.Drawing.Point(0, 0);
            this.labindex.Name = "labindex";
            this.labindex.Size = new System.Drawing.Size(253, 638);
            this.labindex.TabIndex = 0;
            this.labindex.SelectedIndexChanged += new System.EventHandler(this.labindex_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Laser Compute Lab";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.panel0.ResumeLayout(false);
            this.correct.ResumeLayout(false);
            this.correct.PerformLayout();
            this.groupDebug.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox labindex;
        private System.Windows.Forms.ToolStripDropDownButton tools;
        private System.Windows.Forms.ToolStripMenuItem managerCOM;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel connectedStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label lblnumB;
        private System.Windows.Forms.Label lblnumA;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox resultProb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button computeAccuracy;
        private System.Windows.Forms.TextBox accuracy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupDebug;
        private System.Windows.Forms.RichTextBox debugInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox correct;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roof1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox floor1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearDebug;
        private System.Windows.Forms.ToolStripMenuItem debugToolStrip;
    }
}

