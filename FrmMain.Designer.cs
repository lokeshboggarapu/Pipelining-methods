namespace Pipelining_methods
{
    partial class FrmMain
    {
        /// <summary>
        /// Required des variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up of resources  used.
        /// </summary>
        /// <param name="disposing">true if managed resources have to be disposed; otherwise, false.</param>
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
        /// Required method for Designer support
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lstbx_Sender = new System.Windows.Forms.ListBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.grpbx1 = new System.Windows.Forms.GroupBox();
            this.grpbx2 = new System.Windows.Forms.GroupBox();
            this.Lstbx_Receiver = new System.Windows.Forms.ListBox();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.rbn_Selective_Repeat = new System.Windows.Forms.RadioButton();
            this.rbn_goback_N = new System.Windows.Forms.RadioButton();
            this.grpbox_wind_size = new System.Windows.Forms.GroupBox();
            this.num_win_size = new System.Windows.Forms.NumericUpDown();
            this.grpbx3 = new System.Windows.Forms.GroupBox();
            this.txt_Timeout = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.grpbx4 = new System.Windows.Forms.GroupBox();
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_TimeElapsed = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btn_Inc = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpbx6 = new System.Windows.Forms.GroupBox();
            this.Lstbx_Log = new System.Windows.Forms.ListBox();
            this.grpbx1.SuspendLayout();
            this.grpbx2.SuspendLayout();
            this.grpbox_wind_size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_win_size)).BeginInit();
            this.grpbx3.SuspendLayout();
            this.grpbx4.SuspendLayout();
            this.grpbx6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lstbx_Sender
            // 
            this.Lstbx_Sender.FormattingEnabled = true;
            this.Lstbx_Sender.Location = new System.Drawing.Point(55, 47);
            this.Lstbx_Sender.Name = "Lstbx_Sender";
            this.Lstbx_Sender.Size = new System.Drawing.Size(132, 134);
            this.Lstbx_Sender.TabIndex = 0;
            this.Lstbx_Sender.SelectedIndexChanged += new System.EventHandler(this.LBx_Sender_SelectedIndexChanged);
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Location = new System.Drawing.Point(7, 16);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(43, 13);
            this.lbl_sender.TabIndex = 2;
            this.lbl_sender.Text = "Ready";
            // 
            // grpbx1
            // 
            this.grpbx1.Controls.Add(this.Lstbx_Sender);
            this.grpbx1.Controls.Add(this.lbl_sender);
            this.grpbx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbx1.Location = new System.Drawing.Point(3, 16);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Size = new System.Drawing.Size(233, 191);
            this.grpbx1.TabIndex = 3;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Sender";
            // 
            // grpbx2
            // 
            this.grpbx2.Controls.Add(this.Lstbx_Receiver);
            this.grpbx2.Controls.Add(this.lbl_receiver);
            this.grpbx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbx2.Location = new System.Drawing.Point(716, 16);
            this.grpbx2.Name = "grpbx2";
            this.grpbx2.Size = new System.Drawing.Size(258, 191);
            this.grpbx2.TabIndex = 4;
            this.grpbx2.TabStop = false;
            this.grpbx2.Text = "Receiver";
            // 
            // Lstbx_Receiver
            // 
            this.Lstbx_Receiver.FormattingEnabled = true;
            this.Lstbx_Receiver.Location = new System.Drawing.Point(44, 47);
            this.Lstbx_Receiver.Name = "Lstbx_Receiver";
            this.Lstbx_Receiver.Size = new System.Drawing.Size(132, 134);
            this.Lstbx_Receiver.TabIndex = 0;
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Location = new System.Drawing.Point(21, 16);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(43, 13);
            this.lbl_receiver.TabIndex = 2;
            this.lbl_receiver.Text = "Ready";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(520, 389);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(229, 26);
            this.btn_Send.TabIndex = 5;
            this.btn_Send.Text = "S&end";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // rbn_Selective_Repeat
            // 
            this.rbn_Selective_Repeat.AutoSize = true;
            this.rbn_Selective_Repeat.Location = new System.Drawing.Point(635, 29);
            this.rbn_Selective_Repeat.Name = "rbn_Selective_Repeat";
            this.rbn_Selective_Repeat.Size = new System.Drawing.Size(123, 17);
            this.rbn_Selective_Repeat.TabIndex = 7;
            this.rbn_Selective_Repeat.Text = "Selective Repeat";
            this.rbn_Selective_Repeat.UseVisualStyleBackColor = true;
            // 
            // rbn_goback_N
            // 
            this.rbn_goback_N.AutoSize = true;
            this.rbn_goback_N.Checked = true;
            this.rbn_goback_N.Location = new System.Drawing.Point(12, 29);
            this.rbn_goback_N.Name = "rbn_goback_N";
            this.rbn_goback_N.Size = new System.Drawing.Size(87, 17);
            this.rbn_goback_N.TabIndex = 8;
            this.rbn_goback_N.TabStop = true;
            this.rbn_goback_N.Text = "Go Back N";
            this.rbn_goback_N.UseVisualStyleBackColor = true;
            // 
            // grpbox_wind_size
            // 
            this.grpbox_wind_size.Controls.Add(this.num_win_size);
            this.grpbox_wind_size.Location = new System.Drawing.Point(301, 69);
            this.grpbox_wind_size.Name = "grpbox_wind_size";
            this.grpbox_wind_size.Size = new System.Drawing.Size(325, 44);
            this.grpbox_wind_size.TabIndex = 9;
            this.grpbox_wind_size.TabStop = false;
            this.grpbox_wind_size.Text = "Window Size";
            // 
            // num_win_size
            // 
            this.num_win_size.Location = new System.Drawing.Point(24, 16);
            this.num_win_size.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.num_win_size.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_win_size.Name = "num_win_size";
            this.num_win_size.Size = new System.Drawing.Size(251, 20);
            this.num_win_size.TabIndex = 0;
            this.num_win_size.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grpbx3
            // 
            this.grpbx3.Controls.Add(this.rbn_Selective_Repeat);
            this.grpbx3.Controls.Add(this.rbn_goback_N);
            this.grpbx3.Location = new System.Drawing.Point(110, 11);
            this.grpbx3.Name = "grpbx3";
            this.grpbx3.Size = new System.Drawing.Size(788, 52);
            this.grpbx3.TabIndex = 10;
            this.grpbx3.TabStop = false;
            this.grpbx3.Text = "Pipelining Methods";
            // 
            // txt_Timeout
            // 
            this.txt_Timeout.Location = new System.Drawing.Point(549, 430);
            this.txt_Timeout.Name = "txt_Timeout";
            this.txt_Timeout.Size = new System.Drawing.Size(27, 20);
            this.txt_Timeout.TabIndex = 16;
            this.txt_Timeout.Text = "4";
            this.txt_Timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_R_Min_KeyPress);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(490, 433);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 13);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "Timeout";
            // 
            // grpbx4
            // 
            this.grpbx4.Controls.Add(this.simpleOpenGlControl1);
            this.grpbx4.Controls.Add(this.grpbx1);
            this.grpbx4.Controls.Add(this.grpbx2);
            this.grpbx4.Location = new System.Drawing.Point(14, 119);
            this.grpbx4.Name = "grpbx4";
            this.grpbx4.Size = new System.Drawing.Size(977, 210);
            this.grpbx4.TabIndex = 17;
            this.grpbx4.TabStop = false;
            this.grpbx4.Text = "Transfer";
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(236, 16);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(480, 191);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 5;
            this.simpleOpenGlControl1.Visible = false;
            this.simpleOpenGlControl1.Load += new System.EventHandler(this.simpleOpenGlControl1_Load);
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_TimeElapsed
            // 
            this.lbl_TimeElapsed.AutoSize = true;
            this.lbl_TimeElapsed.Location = new System.Drawing.Point(577, 337);
            this.lbl_TimeElapsed.Name = "lbl_TimeElapsed";
            this.lbl_TimeElapsed.Size = new System.Drawing.Size(0, 13);
            this.lbl_TimeElapsed.TabIndex = 18;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(495, 337);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(82, 13);
            this.lbl5.TabIndex = 19;
            this.lbl5.Text = "Time elapsed";
            // 
            // btn_Inc
            // 
            this.btn_Inc.Location = new System.Drawing.Point(23, 17);
            this.btn_Inc.Name = "btn_Inc";
            this.btn_Inc.Size = new System.Drawing.Size(55, 23);
            this.btn_Inc.TabIndex = 20;
            this.btn_Inc.Text = "&Faster";
            this.btn_Inc.UseVisualStyleBackColor = true;
            this.btn_Inc.Click += new System.EventHandler(this.btn_Inc_Click);
            // 
            // btn_Dec
            // 
            this.btn_Dec.Location = new System.Drawing.Point(23, 44);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(55, 23);
            this.btn_Dec.TabIndex = 21;
            this.btn_Dec.Text = "&Slower";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.btn_Dec_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(584, 433);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 13);
            this.lbl1.TabIndex = 22;
            this.lbl1.Text = "seconds";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(315, 389);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 26);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpbx6
            // 
            this.grpbx6.Controls.Add(this.Lstbx_Log);
            this.grpbx6.Location = new System.Drawing.Point(17, 345);
            this.grpbx6.Name = "grpbx6";
            this.grpbx6.Size = new System.Drawing.Size(233, 100);
            this.grpbx6.TabIndex = 25;
            this.grpbx6.TabStop = false;
            this.grpbx6.Text = "Details of Packets";
            // 
            // Lstbx_Log
            // 
            this.Lstbx_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lstbx_Log.FormattingEnabled = true;
            this.Lstbx_Log.Location = new System.Drawing.Point(3, 16);
            this.Lstbx_Log.Name = "Lstbx_Log";
            this.Lstbx_Log.Size = new System.Drawing.Size(227, 81);
            this.Lstbx_Log.TabIndex = 1;
            this.Lstbx_Log.SelectedIndexChanged += new System.EventHandler(this.LBx_Log_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Pipelining_methods.Properties.Resources.CN;
            this.ClientSize = new System.Drawing.Size(990, 756);
            this.Controls.Add(this.grpbx6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl_TimeElapsed);
            this.Controls.Add(this.grpbx4);
            this.Controls.Add(this.txt_Timeout);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.grpbx3);
            this.Controls.Add(this.grpbox_wind_size);
            this.Controls.Add(this.btn_Send);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pipelining_methods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbx1.ResumeLayout(false);
            this.grpbx1.PerformLayout();
            this.grpbx2.ResumeLayout(false);
            this.grpbx2.PerformLayout();
            this.grpbox_wind_size.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_win_size)).EndInit();
            this.grpbx3.ResumeLayout(false);
            this.grpbx3.PerformLayout();
            this.grpbx4.ResumeLayout(false);
            this.grpbx6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lstbx_Sender;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.GroupBox grpbx1;
        private System.Windows.Forms.GroupBox grpbx2;
        private System.Windows.Forms.ListBox Lstbx_Receiver;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Button btn_Send;       
        private System.Windows.Forms.RadioButton rbn_Selective_Repeat;
        private System.Windows.Forms.RadioButton rbn_goback_N;
        private System.Windows.Forms.GroupBox grpbox_wind_size;
        private System.Windows.Forms.NumericUpDown num_win_size;
        private System.Windows.Forms.GroupBox grpbx3;
        private System.Windows.Forms.TextBox txt_Timeout;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox grpbx4;
        private System.Windows.Forms.Timer timer1;
        public Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Label lbl_TimeElapsed;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btn_Inc;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpbx6;
        private System.Windows.Forms.ListBox Lstbx_Log;
    }
}

