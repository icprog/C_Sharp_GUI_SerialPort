namespace GUI_PID
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.CONNECT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GRAPH = new System.Windows.Forms.Button();
            this.Left_speed = new System.Windows.Forms.TextBox();
            this.Recieve = new System.Windows.Forms.Button();
            this.Right_speed = new System.Windows.Forms.TextBox();
            this.Rec_data = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.KP = new System.Windows.Forms.TextBox();
            this.KD = new System.Windows.Forms.TextBox();
            this.KI = new System.Windows.Forms.TextBox();
            this.Left_S = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ASCII = new System.Windows.Forms.CheckBox();
            this.HEX = new System.Windows.Forms.CheckBox();
            this.INT = new System.Windows.Forms.CheckBox();
            this.Uint8 = new System.Windows.Forms.CheckBox();
            this.Send = new System.Windows.Forms.Button();
            this.Send_KI = new System.Windows.Forms.Button();
            this.Send_KD = new System.Windows.Forms.Button();
            this.Send_KP = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Token_val = new System.Windows.Forms.TextBox();
            this.Taken = new System.Windows.Forms.Label();
            this.Send_Token = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(579, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            /*this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;*/
            this.zedGraphControl1.Size = new System.Drawing.Size(496, 453);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // CONNECT
            // 
            this.CONNECT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CONNECT.Location = new System.Drawing.Point(160, 76);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(90, 23);
            this.CONNECT.TabIndex = 1;
            this.CONNECT.Text = "CONNECT";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select"});
            this.comboBox1.Location = new System.Drawing.Point(12, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // GRAPH
            // 
            this.GRAPH.Location = new System.Drawing.Point(1000, 12);
            this.GRAPH.Name = "GRAPH";
            this.GRAPH.Size = new System.Drawing.Size(75, 23);
            this.GRAPH.TabIndex = 4;
            this.GRAPH.Text = "GRAPH";
            this.GRAPH.UseVisualStyleBackColor = true;
            this.GRAPH.Click += new System.EventHandler(this.GRAPH_Click);
            // 
            // Left_speed
            // 
            this.Left_speed.Location = new System.Drawing.Point(267, 28);
            this.Left_speed.Name = "Left_speed";
            this.Left_speed.Size = new System.Drawing.Size(100, 20);
            this.Left_speed.TabIndex = 5;
            this.Left_speed.TextChanged += new System.EventHandler(this.Left_speed_TextChanged);
            // 
            // Recieve
            // 
            this.Recieve.Location = new System.Drawing.Point(12, 153);
            this.Recieve.Name = "Recieve";
            this.Recieve.Size = new System.Drawing.Size(75, 23);
            this.Recieve.TabIndex = 6;
            this.Recieve.Text = "Recieve";
            this.Recieve.UseVisualStyleBackColor = true;
            this.Recieve.Click += new System.EventHandler(this.Recieve_Click);
            // 
            // Right_speed
            // 
            this.Right_speed.Location = new System.Drawing.Point(267, 67);
            this.Right_speed.Name = "Right_speed";
            this.Right_speed.Size = new System.Drawing.Size(100, 20);
            this.Right_speed.TabIndex = 8;
            this.Right_speed.TextChanged += new System.EventHandler(this.Right_speed_TextChanged);
            // 
            // Rec_data
            // 
            this.Rec_data.Location = new System.Drawing.Point(12, 182);
            this.Rec_data.Name = "Rec_data";
            this.Rec_data.Size = new System.Drawing.Size(561, 283);
            this.Rec_data.TabIndex = 9;
            this.Rec_data.Text = "";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Reset.Location = new System.Drawing.Point(919, 12);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // KP
            // 
            this.KP.Location = new System.Drawing.Point(387, 92);
            this.KP.Name = "KP";
            this.KP.Size = new System.Drawing.Size(100, 20);
            this.KP.TabIndex = 11;
            this.KP.TextChanged += new System.EventHandler(this.KP_TextChanged);
            // 
            // KD
            // 
            this.KD.Location = new System.Drawing.Point(387, 53);
            this.KD.Name = "KD";
            this.KD.Size = new System.Drawing.Size(100, 20);
            this.KD.TabIndex = 12;
            this.KD.TextChanged += new System.EventHandler(this.KD_TextChanged);
            // 
            // KI
            // 
            this.KI.Location = new System.Drawing.Point(387, 14);
            this.KI.Name = "KI";
            this.KI.Size = new System.Drawing.Size(100, 20);
            this.KI.TabIndex = 13;
            this.KI.TextChanged += new System.EventHandler(this.KI_TextChanged);
            // 
            // Left_S
            // 
            this.Left_S.AutoSize = true;
            this.Left_S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Left_S.Location = new System.Drawing.Point(283, 12);
            this.Left_S.Name = "Left_S";
            this.Left_S.Size = new System.Drawing.Size(59, 13);
            this.Left_S.TabIndex = 14;
            this.Left_S.Text = "Left Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(283, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Right Speed";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(429, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "KI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(429, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "KD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(430, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "KP";
            // 
            // ASCII
            // 
            this.ASCII.AutoSize = true;
            this.ASCII.Location = new System.Drawing.Point(12, 84);
            this.ASCII.Name = "ASCII";
            this.ASCII.Size = new System.Drawing.Size(53, 17);
            this.ASCII.TabIndex = 19;
            this.ASCII.Text = "ASCII";
            this.ASCII.UseVisualStyleBackColor = true;
            this.ASCII.CheckedChanged += new System.EventHandler(this.ASCII_CheckedChanged);
            // 
            // HEX
            // 
            this.HEX.AutoSize = true;
            this.HEX.Location = new System.Drawing.Point(12, 107);
            this.HEX.Name = "HEX";
            this.HEX.Size = new System.Drawing.Size(48, 17);
            this.HEX.TabIndex = 20;
            this.HEX.Text = "HEX";
            this.HEX.UseVisualStyleBackColor = true;
            this.HEX.CheckedChanged += new System.EventHandler(this.HEX_CheckedChanged);
            // 
            // INT
            // 
            this.INT.AutoSize = true;
            this.INT.Location = new System.Drawing.Point(82, 107);
            this.INT.Name = "INT";
            this.INT.Size = new System.Drawing.Size(44, 17);
            this.INT.TabIndex = 21;
            this.INT.Text = "INT";
            this.INT.UseVisualStyleBackColor = true;
            this.INT.CheckedChanged += new System.EventHandler(this.INT_CheckedChanged);
            // 
            // Uint8
            // 
            this.Uint8.AutoSize = true;
            this.Uint8.Location = new System.Drawing.Point(82, 84);
            this.Uint8.Name = "Uint8";
            this.Uint8.Size = new System.Drawing.Size(51, 17);
            this.Uint8.TabIndex = 22;
            this.Uint8.Text = "Uint8";
            this.Uint8.UseVisualStyleBackColor = true;
            this.Uint8.CheckedChanged += new System.EventHandler(this.Uint8_CheckedChanged);
            // 
            // Send
            // 
            this.Send.ForeColor = System.Drawing.Color.DarkRed;
            this.Send.Location = new System.Drawing.Point(274, 101);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 7;
            this.Send.Text = "SEND";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Send_KI
            // 
            this.Send_KI.Location = new System.Drawing.Point(498, 14);
            this.Send_KI.Name = "Send_KI";
            this.Send_KI.Size = new System.Drawing.Size(75, 23);
            this.Send_KI.TabIndex = 23;
            this.Send_KI.Text = "Send_KI";
            this.Send_KI.UseVisualStyleBackColor = true;
            this.Send_KI.Click += new System.EventHandler(this.Send_KI_Click);
            // 
            // Send_KD
            // 
            this.Send_KD.Location = new System.Drawing.Point(498, 51);
            this.Send_KD.Name = "Send_KD";
            this.Send_KD.Size = new System.Drawing.Size(75, 23);
            this.Send_KD.TabIndex = 24;
            this.Send_KD.Text = "Send_KD";
            this.Send_KD.UseVisualStyleBackColor = true;
            this.Send_KD.Click += new System.EventHandler(this.Send_KD_Click);
            // 
            // Send_KP
            // 
            this.Send_KP.Location = new System.Drawing.Point(498, 89);
            this.Send_KP.Name = "Send_KP";
            this.Send_KP.Size = new System.Drawing.Size(75, 23);
            this.Send_KP.TabIndex = 25;
            this.Send_KP.Text = "Send_KP";
            this.Send_KP.UseVisualStyleBackColor = true;
            this.Send_KP.Click += new System.EventHandler(this.Send_KP_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Location = new System.Drawing.Point(240, 153);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 23);
            this.Clear.TabIndex = 26;
            this.Clear.Text = "Clear Screen";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh.Location = new System.Drawing.Point(12, 9);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 27;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Token_val
            // 
            this.Token_val.Location = new System.Drawing.Point(387, 130);
            this.Token_val.Name = "Token_val";
            this.Token_val.Size = new System.Drawing.Size(100, 20);
            this.Token_val.TabIndex = 28;
            this.Token_val.TextChanged += new System.EventHandler(this.Token_val_TextChanged);
            // 
            // Taken
            // 
            this.Taken.AutoSize = true;
            this.Taken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Taken.Location = new System.Drawing.Point(416, 115);
            this.Taken.Name = "Taken";
            this.Taken.Size = new System.Drawing.Size(38, 13);
            this.Taken.TabIndex = 29;
            this.Taken.Text = "Token";
            // 
            // Send_Token
            // 
            this.Send_Token.Location = new System.Drawing.Point(493, 127);
            this.Send_Token.Name = "Send_Token";
            this.Send_Token.Size = new System.Drawing.Size(85, 23);
            this.Send_Token.TabIndex = 30;
            this.Send_Token.Text = "Send_Token";
            this.Send_Token.UseVisualStyleBackColor = true;
            this.Send_Token.Click += new System.EventHandler(this.Send_Token_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(156, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1087, 481);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Send_Token);
            this.Controls.Add(this.Taken);
            this.Controls.Add(this.Token_val);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Send_KP);
            this.Controls.Add(this.Send_KD);
            this.Controls.Add(this.Send_KI);
            this.Controls.Add(this.Uint8);
            this.Controls.Add(this.INT);
            this.Controls.Add(this.HEX);
            this.Controls.Add(this.ASCII);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Left_S);
            this.Controls.Add(this.KI);
            this.Controls.Add(this.KD);
            this.Controls.Add(this.KP);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Rec_data);
            this.Controls.Add(this.Right_speed);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Recieve);
            this.Controls.Add(this.Left_speed);
            this.Controls.Add(this.GRAPH);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CONNECT);
            this.Controls.Add(this.zedGraphControl1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GRAPH;
        private System.Windows.Forms.TextBox Left_speed;
        private System.Windows.Forms.Button Recieve;
        private System.Windows.Forms.TextBox Right_speed;
        private System.Windows.Forms.RichTextBox Rec_data;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox KP;
        private System.Windows.Forms.TextBox KD;
        private System.Windows.Forms.TextBox KI;
        private System.Windows.Forms.Label Left_S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ASCII;
        private System.Windows.Forms.CheckBox HEX;
        private System.Windows.Forms.CheckBox INT;
        private System.Windows.Forms.CheckBox Uint8;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Send_KI;
        private System.Windows.Forms.Button Send_KD;
        private System.Windows.Forms.Button Send_KP;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox Token_val;
        private System.Windows.Forms.Label Taken;
        private System.Windows.Forms.Button Send_Token;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

