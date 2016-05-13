namespace TestPID
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KI = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.KD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SP = new System.Windows.Forms.NumericUpDown();
            this.Run = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ShowMV = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.KP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KP
            // 
            this.KP.DecimalPlaces = 2;
            this.KP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.KP.Location = new System.Drawing.Point(457, 187);
            this.KP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.KP.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.KP.Name = "KP";
            this.KP.Size = new System.Drawing.Size(54, 21);
            this.KP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "KP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "KI";
            // 
            // KI
            // 
            this.KI.DecimalPlaces = 2;
            this.KI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.KI.Location = new System.Drawing.Point(457, 214);
            this.KI.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.KI.Name = "KI";
            this.KI.Size = new System.Drawing.Size(54, 21);
            this.KI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "KD";
            // 
            // KD
            // 
            this.KD.DecimalPlaces = 2;
            this.KD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.KD.Location = new System.Drawing.Point(457, 242);
            this.KD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.KD.Name = "KD";
            this.KD.Size = new System.Drawing.Size(54, 21);
            this.KD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "SP";
            // 
            // SP
            // 
            this.SP.Location = new System.Drawing.Point(457, 269);
            this.SP.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(54, 21);
            this.SP.TabIndex = 11;
            this.SP.ValueChanged += new System.EventHandler(this.SP_ValueChanged);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(517, 257);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 33);
            this.Run.TabIndex = 13;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Black;
            this.Canvas.Location = new System.Drawing.Point(12, 9);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(580, 155);
            this.Canvas.TabIndex = 16;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 107);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "PV";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(269, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(269, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "MV";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(269, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "SP";
            // 
            // ShowMV
            // 
            this.ShowMV.AutoSize = true;
            this.ShowMV.Location = new System.Drawing.Point(248, 274);
            this.ShowMV.Name = "ShowMV";
            this.ShowMV.Size = new System.Drawing.Size(66, 16);
            this.ShowMV.TabIndex = 26;
            this.ShowMV.Text = "Show MV";
            this.ShowMV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 302);
            this.Controls.Add(this.ShowMV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PID Demo";
            ((System.ComponentModel.ISupportInitialize)(this.KP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown KP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown KI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown KD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SP;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label Canvas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ShowMV;
    }
}

