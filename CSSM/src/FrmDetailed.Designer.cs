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
            this.CPU = new System.Windows.Forms.TextBox();
            this.Device = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.workingCycle = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
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
            this.procIntensity = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.queueToCPU = new System.Windows.Forms.ListBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.queueToDevice = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minTimeCpu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxTimeCpu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RamSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.minCpuSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.maxCpuSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procIntensity)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeCpu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTimeCpu)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RamSize)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minCpuSize)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCpuSize)).BeginInit();
            this.SuspendLayout();
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
            // save
            // 
            this.save.Location = new System.Drawing.Point(541, 28);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 61);
            this.save.TabIndex = 11;
            this.save.Text = "Зберігти налаштування";
            this.save.UseVisualStyleBackColor = true;
            // 
            // workingCycle
            // 
            this.workingCycle.Location = new System.Drawing.Point(672, 28);
            this.workingCycle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workingCycle.Name = "workingCycle";
            this.workingCycle.Size = new System.Drawing.Size(126, 61);
            this.workingCycle.TabIndex = 12;
            this.workingCycle.Text = "Робочий такт";
            this.workingCycle.UseVisualStyleBackColor = true;
            this.workingCycle.Click += new System.EventHandler(this.workingCycle_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(804, 28);
            this.end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(120, 61);
            this.end.TabIndex = 13;
            this.end.Text = "Завершення роботи";
            this.end.UseVisualStyleBackColor = true;
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
            this.manualMode.Text = "Ручний";
            this.manualMode.UseVisualStyleBackColor = true;
            // 
            // autoMode
            // 
            this.autoMode.AutoSize = true;
            this.autoMode.Location = new System.Drawing.Point(192, 61);
            this.autoMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoMode.Name = "autoMode";
            this.autoMode.Size = new System.Drawing.Size(132, 24);
            this.autoMode.TabIndex = 16;
            this.autoMode.TabStop = true;
            this.autoMode.Text = "Автоматичний";
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
            this.label1.Text = "Інтенсивність надходження процесів";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Центральний процесор";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Зовнішній пристрій";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Черга до центрального процесора";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(486, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Черга до зовнішнього пристрою";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Оперативна пам\'ять";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 27);
            this.label12.TabIndex = 31;
            this.label12.Text = "Розмір вільної пам\'яті:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(468, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(276, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Розмір пам\'яті, зайнятої процесами:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(109, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Режим роботи:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.procIntensity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(150, 147);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // procIntensity
            // 
            this.procIntensity.Location = new System.Drawing.Point(6, 110);
            this.procIntensity.Name = "procIntensity";
            this.procIntensity.Size = new System.Drawing.Size(138, 27);
            this.procIntensity.TabIndex = 21;
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
            this.groupBox11.Controls.Add(this.queueToCPU);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Location = new System.Drawing.Point(10, 252);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Size = new System.Drawing.Size(462, 260);
            this.groupBox11.TabIndex = 44;
            this.groupBox11.TabStop = false;
            // 
            // queueToCPU
            // 
            this.queueToCPU.FormattingEnabled = true;
            this.queueToCPU.ItemHeight = 20;
            this.queueToCPU.Location = new System.Drawing.Point(6, 27);
            this.queueToCPU.Name = "queueToCPU";
            this.queueToCPU.Size = new System.Drawing.Size(434, 224);
            this.queueToCPU.TabIndex = 29;
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
            // queueToDevice
            // 
            this.queueToDevice.FormattingEnabled = true;
            this.queueToDevice.ItemHeight = 20;
            this.queueToDevice.Location = new System.Drawing.Point(6, 27);
            this.queueToDevice.Name = "queueToDevice";
            this.queueToDevice.Size = new System.Drawing.Size(434, 224);
            this.queueToDevice.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minTimeCpu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(166, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(150, 147);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // minTimeCpu
            // 
            this.minTimeCpu.Location = new System.Drawing.Point(6, 110);
            this.minTimeCpu.Name = "minTimeCpu";
            this.minTimeCpu.Size = new System.Drawing.Size(138, 27);
            this.minTimeCpu.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 83);
            this.label2.TabIndex = 20;
            this.label2.Text = "Мінімальне значення проміжку роботи на ЦП";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxTimeCpu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(322, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(150, 147);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // maxTimeCpu
            // 
            this.maxTimeCpu.Location = new System.Drawing.Point(6, 110);
            this.maxTimeCpu.Name = "maxTimeCpu";
            this.maxTimeCpu.Size = new System.Drawing.Size(138, 27);
            this.maxTimeCpu.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 83);
            this.label3.TabIndex = 20;
            this.label3.Text = "Максимальне значення проміжку роботи на ЦП";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RamSize);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(478, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(150, 147);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // RamSize
            // 
            this.RamSize.Location = new System.Drawing.Point(6, 110);
            this.RamSize.Name = "RamSize";
            this.RamSize.Size = new System.Drawing.Size(138, 27);
            this.RamSize.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 83);
            this.label4.TabIndex = 20;
            this.label4.Text = "Розмір оперативної пам\'яті";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.minCpuSize);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(634, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(150, 147);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // minCpuSize
            // 
            this.minCpuSize.Location = new System.Drawing.Point(6, 110);
            this.minCpuSize.Name = "minCpuSize";
            this.minCpuSize.Size = new System.Drawing.Size(138, 27);
            this.minCpuSize.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 83);
            this.label5.TabIndex = 20;
            this.label5.Text = "Мінімальний розмір адресного простору процесу";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maxCpuSize);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(790, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(150, 147);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            // 
            // maxCpuSize
            // 
            this.maxCpuSize.Location = new System.Drawing.Point(6, 110);
            this.maxCpuSize.Name = "maxCpuSize";
            this.maxCpuSize.Size = new System.Drawing.Size(138, 27);
            this.maxCpuSize.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 83);
            this.label6.TabIndex = 20;
            this.label6.Text = "Максимальний розмір адресного простору процесу";
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
            this.Text = "Система CSSM";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.procIntensity)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minTimeCpu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxTimeCpu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RamSize)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minCpuSize)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxCpuSize)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox CPU;
		private System.Windows.Forms.TextBox Device;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button workingCycle;
		private System.Windows.Forms.Button end;
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
		private Label label2;
		private GroupBox groupBox3;
		private Label label3;
		private GroupBox groupBox4;
		private Label label4;
		private GroupBox groupBox5;
		private Label label5;
		private GroupBox groupBox6;
		private Label label6;

		private NumericUpDown procIntensity;
		private NumericUpDown minTimeCpu;
		private NumericUpDown maxTimeCpu;
		private NumericUpDown RamSize;
		private NumericUpDown minCpuSize;
		private NumericUpDown maxCpuSize;
        private ListBox queueToCPU;
        private ListBox queueToDevice;
    }
}

