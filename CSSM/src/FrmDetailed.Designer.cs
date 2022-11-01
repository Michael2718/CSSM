namespace ComputingSystem
{
    partial class FrmDetailed
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
            this.queueToCPU = new System.Windows.Forms.TextBox();
            this.queueToDevice = new System.Windows.Forms.TextBox();
            this.CPU = new System.Windows.Forms.TextBox();
            this.Device = new System.Windows.Forms.TextBox();
            this.intensity = new System.Windows.Forms.DomainUpDown();
            this.save = new System.Windows.Forms.Button();
            this.workingCycle = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.manualMode = new System.Windows.Forms.RadioButton();
            this.autoMode = new System.Windows.Forms.RadioButton();
            this.typeOfWork = new System.Windows.Forms.TextBox();
            this.freeSize = new System.Windows.Forms.TextBox();
            this.occupiedSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // queueToCPU
            // 
            this.queueToCPU.Location = new System.Drawing.Point(9, 33);
            this.queueToCPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queueToCPU.Multiline = true;
            this.queueToCPU.Name = "queueToCPU";
            this.queueToCPU.Size = new System.Drawing.Size(431, 219);
            this.queueToCPU.TabIndex = 0;
            // 
            // queueToDevice
            // 
            this.queueToDevice.Location = new System.Drawing.Point(6, 33);
            this.queueToDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queueToDevice.Multiline = true;
            this.queueToDevice.Name = "queueToDevice";
            this.queueToDevice.Size = new System.Drawing.Size(431, 219);
            this.queueToDevice.TabIndex = 1;
            // 
            // CPU
            // 
            this.CPU.Location = new System.Drawing.Point(6, 28);
            this.CPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            this.CPU.Size = new System.Drawing.Size(434, 27);
            this.CPU.TabIndex = 2;
            // 
            // Device
            // 
            this.Device.Location = new System.Drawing.Point(6, 28);
            this.Device.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Device.Name = "Device";
            this.Device.ReadOnly = true;
            this.Device.Size = new System.Drawing.Size(431, 27);
            this.Device.TabIndex = 3;
            // 
            // intensity
            // 
            this.intensity.Location = new System.Drawing.Point(6, 111);
            this.intensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intensity.Name = "intensity";
            this.intensity.Size = new System.Drawing.Size(138, 27);
            this.intensity.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(418, 28);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 61);
            this.save.TabIndex = 11;
            this.save.Text = "Сохранение настроек";
            this.save.UseVisualStyleBackColor = true;
            // 
            // workingCycle
            // 
            this.workingCycle.Location = new System.Drawing.Point(549, 28);
            this.workingCycle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workingCycle.Name = "workingCycle";
            this.workingCycle.Size = new System.Drawing.Size(126, 61);
            this.workingCycle.TabIndex = 12;
            this.workingCycle.Text = "Рабочий такт";
            this.workingCycle.UseVisualStyleBackColor = true;
            this.workingCycle.Click += new System.EventHandler(this.workingCycle_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(681, 28);
            this.end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(120, 61);
            this.end.TabIndex = 13;
            this.end.Text = "Завершение сеанса";
            this.end.UseVisualStyleBackColor = true;
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(807, 28);
            this.statistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(117, 61);
            this.statistics.TabIndex = 14;
            this.statistics.Text = "Статистика";
            this.statistics.UseVisualStyleBackColor = true;
            // 
            // manualMode
            // 
            this.manualMode.AutoSize = true;
            this.manualMode.Location = new System.Drawing.Point(109, 61);
            this.manualMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manualMode.Name = "manualMode";
            this.manualMode.Size = new System.Drawing.Size(80, 24);
            this.manualMode.TabIndex = 15;
            this.manualMode.TabStop = true;
            this.manualMode.Text = "Ручной";
            this.manualMode.UseVisualStyleBackColor = true;
            // 
            // autoMode
            // 
            this.autoMode.AutoSize = true;
            this.autoMode.Location = new System.Drawing.Point(192, 61);
            this.autoMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoMode.Name = "autoMode";
            this.autoMode.Size = new System.Drawing.Size(145, 24);
            this.autoMode.TabIndex = 16;
            this.autoMode.TabStop = true;
            this.autoMode.Text = "Автоматический";
            this.autoMode.UseVisualStyleBackColor = true;
            // 
            // typeOfWork
            // 
            this.typeOfWork.Location = new System.Drawing.Point(9, 45);
            this.typeOfWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeOfWork.Name = "typeOfWork";
            this.typeOfWork.ReadOnly = true;
            this.typeOfWork.Size = new System.Drawing.Size(78, 27);
            this.typeOfWork.TabIndex = 17;
            // 
            // freeSize
            // 
            this.freeSize.Location = new System.Drawing.Point(224, 27);
            this.freeSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.freeSize.Name = "freeSize";
            this.freeSize.ReadOnly = true;
            this.freeSize.Size = new System.Drawing.Size(216, 27);
            this.freeSize.TabIndex = 18;
            // 
            // occupiedSize
            // 
            this.occupiedSize.Location = new System.Drawing.Point(750, 24);
            this.occupiedSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.occupiedSize.Name = "occupiedSize";
            this.occupiedSize.ReadOnly = true;
            this.occupiedSize.Size = new System.Drawing.Size(174, 27);
            this.occupiedSize.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 83);
            this.label1.TabIndex = 20;
            this.label1.Text = "Интенсивность поступления процессов";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Центральный процессор";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Внешнее устройство";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Очередь к центральному процессору";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(486, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Очередь к внешнему устройству";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Оперативная память";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 27);
            this.label12.TabIndex = 31;
            this.label12.Text = "Размер свободной памяти:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(468, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(276, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Размер памяти, занятой процессами:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(109, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Режим работы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intensity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(150, 147);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.occupiedSize);
            this.groupBox7.Controls.Add(this.freeSize);
            this.groupBox7.Location = new System.Drawing.Point(10, 520);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(930, 67);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.typeOfWork);
            this.groupBox8.Controls.Add(this.autoMode);
            this.groupBox8.Controls.Add(this.manualMode);
            this.groupBox8.Controls.Add(this.statistics);
            this.groupBox8.Controls.Add(this.end);
            this.groupBox8.Controls.Add(this.workingCycle);
            this.groupBox8.Controls.Add(this.save);
            this.groupBox8.Location = new System.Drawing.Point(10, 595);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(930, 107);
            this.groupBox8.TabIndex = 41;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.Device);
            this.groupBox9.Location = new System.Drawing.Point(478, 155);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(462, 66);
            this.groupBox9.TabIndex = 42;
            this.groupBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.CPU);
            this.groupBox10.Location = new System.Drawing.Point(10, 155);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(462, 66);
            this.groupBox10.TabIndex = 43;
            this.groupBox10.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.queueToCPU);
            this.groupBox11.Location = new System.Drawing.Point(10, 252);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Size = new System.Drawing.Size(462, 260);
            this.groupBox11.TabIndex = 44;
            this.groupBox11.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.queueToDevice);
            this.groupBox12.Location = new System.Drawing.Point(478, 252);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Size = new System.Drawing.Size(462, 260);
            this.groupBox12.TabIndex = 45;
            this.groupBox12.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.domainUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(166, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(150, 147);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(6, 111);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(138, 27);
            this.domainUpDown1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 83);
            this.label2.TabIndex = 20;
            this.label2.Text = "Минимальное значение промежутка работы на ЦП\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.domainUpDown2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(322, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(150, 147);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(6, 111);
            this.domainUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(138, 27);
            this.domainUpDown2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 83);
            this.label3.TabIndex = 20;
            this.label3.Text = "Максимальное значение промежутка работы на ЦП";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.domainUpDown3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(478, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(150, 147);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(6, 111);
            this.domainUpDown3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(138, 27);
            this.domainUpDown3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 83);
            this.label4.TabIndex = 20;
            this.label4.Text = "Размер оперативной памяти";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.domainUpDown4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(634, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(150, 147);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Location = new System.Drawing.Point(6, 111);
            this.domainUpDown4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(138, 27);
            this.domainUpDown4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 83);
            this.label5.TabIndex = 20;
            this.label5.Text = "Минимальный размер адресного пространства процесса";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.domainUpDown5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(790, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(150, 147);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.Location = new System.Drawing.Point(6, 111);
            this.domainUpDown5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.Size = new System.Drawing.Size(138, 27);
            this.domainUpDown5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 83);
            this.label6.TabIndex = 20;
            this.label6.Text = "Максимальный размер адресного пространства процесса";
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 709);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDetailed";
            this.Text = "Системное программное обеспечение: курсовая работа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox queueToCPU;
        private System.Windows.Forms.TextBox queueToDevice;
        private System.Windows.Forms.TextBox CPU;
        private System.Windows.Forms.TextBox Device;
        private System.Windows.Forms.DomainUpDown intensity;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button workingCycle;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.RadioButton manualMode;
        private System.Windows.Forms.RadioButton autoMode;
        private System.Windows.Forms.TextBox typeOfWork;
        private System.Windows.Forms.TextBox freeSize;
        private System.Windows.Forms.TextBox occupiedSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private GroupBox groupBox2;
        private DomainUpDown domainUpDown1;
        private Label label2;
        private GroupBox groupBox3;
        private DomainUpDown domainUpDown2;
        private Label label3;
        private GroupBox groupBox4;
        private DomainUpDown domainUpDown3;
        private Label label4;
        private GroupBox groupBox5;
        private DomainUpDown domainUpDown4;
        private Label label5;
        private GroupBox groupBox6;
        private DomainUpDown domainUpDown5;
        private Label label6;
    }
}

