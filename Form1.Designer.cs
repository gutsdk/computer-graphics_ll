namespace KGLB2_3
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxBrush = new System.Windows.Forms.CheckBox();
            this.checkBoxStop = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxArt = new System.Windows.Forms.CheckBox();
            this.checkBoxPhong = new System.Windows.Forms.CheckBox();
            this.numericRedByte = new System.Windows.Forms.NumericUpDown();
            this.numericGreenByte = new System.Windows.Forms.NumericUpDown();
            this.numericBlueByte = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownOSNS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOSRS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKGP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownITS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownISvOSO = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOSOS = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRedByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreenByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlueByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKGP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownITS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownISvOSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSOS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxBrush
            // 
            this.checkBoxBrush.AutoSize = true;
            this.checkBoxBrush.Location = new System.Drawing.Point(531, 33);
            this.checkBoxBrush.Name = "checkBoxBrush";
            this.checkBoxBrush.Size = new System.Drawing.Size(69, 17);
            this.checkBoxBrush.TabIndex = 1;
            this.checkBoxBrush.Text = "Заливка";
            this.checkBoxBrush.UseVisualStyleBackColor = true;
            this.checkBoxBrush.CheckedChanged += new System.EventHandler(this.checkBoxBrush_CheckedChange);
            // 
            // checkBoxStop
            // 
            this.checkBoxStop.AutoSize = true;
            this.checkBoxStop.Location = new System.Drawing.Point(531, 56);
            this.checkBoxStop.Name = "checkBoxStop";
            this.checkBoxStop.Size = new System.Drawing.Size(50, 17);
            this.checkBoxStop.TabIndex = 2;
            this.checkBoxStop.Text = "Стоп";
            this.checkBoxStop.UseVisualStyleBackColor = true;
            this.checkBoxStop.CheckedChanged += new System.EventHandler(this.checkBoxStop_CheckedChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 544);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxArt
            // 
            this.checkBoxArt.AutoSize = true;
            this.checkBoxArt.Location = new System.Drawing.Point(531, 81);
            this.checkBoxArt.Name = "checkBoxArt";
            this.checkBoxArt.Size = new System.Drawing.Size(132, 17);
            this.checkBoxArt.TabIndex = 4;
            this.checkBoxArt.Text = "Алгоритм художника";
            this.checkBoxArt.UseVisualStyleBackColor = true;
            this.checkBoxArt.CheckedChanged += new System.EventHandler(this.checkBoxArt_CheckedChanged);
            // 
            // checkBoxPhong
            // 
            this.checkBoxPhong.AutoSize = true;
            this.checkBoxPhong.Location = new System.Drawing.Point(531, 104);
            this.checkBoxPhong.Name = "checkBoxPhong";
            this.checkBoxPhong.Size = new System.Drawing.Size(95, 17);
            this.checkBoxPhong.TabIndex = 5;
            this.checkBoxPhong.Text = "Метод Фонга";
            this.checkBoxPhong.UseVisualStyleBackColor = true;
            this.checkBoxPhong.CheckedChanged += new System.EventHandler(this.checkBoxPhong_CheckedChanged);
            // 
            // numericRedByte
            // 
            this.numericRedByte.Location = new System.Drawing.Point(6, 32);
            this.numericRedByte.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRedByte.Name = "numericRedByte";
            this.numericRedByte.Size = new System.Drawing.Size(120, 20);
            this.numericRedByte.TabIndex = 8;
            // 
            // numericGreenByte
            // 
            this.numericGreenByte.Location = new System.Drawing.Point(6, 71);
            this.numericGreenByte.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreenByte.Name = "numericGreenByte";
            this.numericGreenByte.Size = new System.Drawing.Size(120, 20);
            this.numericGreenByte.TabIndex = 9;
            // 
            // numericBlueByte
            // 
            this.numericBlueByte.Location = new System.Drawing.Point(6, 110);
            this.numericBlueByte.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlueByte.Name = "numericBlueByte";
            this.numericBlueByte.Size = new System.Drawing.Size(120, 20);
            this.numericBlueByte.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Красный канал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Зелёный канал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Синий канал";
            // 
            // numericUpDownOSNS
            // 
            this.numericUpDownOSNS.DecimalPlaces = 2;
            this.numericUpDownOSNS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownOSNS.Location = new System.Drawing.Point(2, 46);
            this.numericUpDownOSNS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOSNS.Name = "numericUpDownOSNS";
            this.numericUpDownOSNS.Size = new System.Drawing.Size(358, 20);
            this.numericUpDownOSNS.TabIndex = 14;
            // 
            // numericUpDownOSRS
            // 
            this.numericUpDownOSRS.DecimalPlaces = 2;
            this.numericUpDownOSRS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownOSRS.Location = new System.Drawing.Point(2, 90);
            this.numericUpDownOSRS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOSRS.Name = "numericUpDownOSRS";
            this.numericUpDownOSRS.Size = new System.Drawing.Size(358, 20);
            this.numericUpDownOSRS.TabIndex = 15;
            // 
            // numericUpDownKGP
            // 
            this.numericUpDownKGP.Location = new System.Drawing.Point(2, 133);
            this.numericUpDownKGP.Name = "numericUpDownKGP";
            this.numericUpDownKGP.Size = new System.Drawing.Size(358, 20);
            this.numericUpDownKGP.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDownITS);
            this.groupBox1.Controls.Add(this.numericUpDownISvOSO);
            this.groupBox1.Controls.Add(this.numericUpDownOSOS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDownKGP);
            this.groupBox1.Controls.Add(this.numericUpDownOSRS);
            this.groupBox1.Controls.Add(this.numericUpDownOSNS);
            this.groupBox1.Location = new System.Drawing.Point(531, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 268);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поверхности";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Отражательная способность окружающего света";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Интенсивность света в окружающей среде объекта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Интенсивность точечного света";
            // 
            // numericUpDownITS
            // 
            this.numericUpDownITS.Location = new System.Drawing.Point(2, 245);
            this.numericUpDownITS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownITS.Name = "numericUpDownITS";
            this.numericUpDownITS.Size = new System.Drawing.Size(358, 20);
            this.numericUpDownITS.TabIndex = 18;
            // 
            // numericUpDownISvOSO
            // 
            this.numericUpDownISvOSO.Location = new System.Drawing.Point(2, 207);
            this.numericUpDownISvOSO.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownISvOSO.Name = "numericUpDownISvOSO";
            this.numericUpDownISvOSO.Size = new System.Drawing.Size(358, 20);
            this.numericUpDownISvOSO.TabIndex = 19;
            // 
            // numericUpDownOSOS
            // 
            this.numericUpDownOSOS.DecimalPlaces = 2;
            this.numericUpDownOSOS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownOSOS.Location = new System.Drawing.Point(2, 171);
            this.numericUpDownOSOS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOSOS.Name = "numericUpDownOSOS";
            this.numericUpDownOSOS.Size = new System.Drawing.Size(358, 20);
            this.numericUpDownOSOS.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Отражательная способность направленного света";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Отражательная способность рассеянного света";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Коэффициент гладкости поверхности";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericBlueByte);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericRedByte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericGreenByte);
            this.groupBox2.Location = new System.Drawing.Point(531, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 138);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxPhong);
            this.Controls.Add(this.checkBoxArt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxStop);
            this.Controls.Add(this.checkBoxBrush);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "KGLB2_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRedByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreenByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlueByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKGP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownITS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownISvOSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSOS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxBrush;
        private System.Windows.Forms.CheckBox checkBoxStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.CheckBox checkBoxArt;
        public System.Windows.Forms.CheckBox checkBoxPhong;
        private System.Windows.Forms.NumericUpDown numericRedByte;
        private System.Windows.Forms.NumericUpDown numericGreenByte;
        private System.Windows.Forms.NumericUpDown numericBlueByte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownOSNS;
        private System.Windows.Forms.NumericUpDown numericUpDownOSRS;
        private System.Windows.Forms.NumericUpDown numericUpDownKGP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownITS;
        private System.Windows.Forms.NumericUpDown numericUpDownISvOSO;
        private System.Windows.Forms.NumericUpDown numericUpDownOSOS;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

