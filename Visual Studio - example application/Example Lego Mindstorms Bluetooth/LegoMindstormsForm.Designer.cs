namespace Example_Lego_Mindstorms_Bluetooth
{
    partial class LegoMindstormsForm
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
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputlistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btStopD = new System.Windows.Forms.Button();
            this.btStartD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDP = new System.Windows.Forms.Button();
            this.btStartP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.connectionGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.refreshButton);
            this.connectionGroupBox.Controls.Add(this.label1);
            this.connectionGroupBox.Controls.Add(this.portListBox);
            this.connectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.Location = new System.Drawing.Point(18, 18);
            this.connectionGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionGroupBox.Size = new System.Drawing.Size(609, 202);
            this.connectionGroupBox.TabIndex = 4;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(412, 143);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(180, 35);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(412, 98);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(180, 35);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(412, 54);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(180, 35);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Referesh ports";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port for blutooth connection";
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.FormattingEnabled = true;
            this.portListBox.ItemHeight = 20;
            this.portListBox.Location = new System.Drawing.Point(14, 54);
            this.portListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(388, 124);
            this.portListBox.TabIndex = 5;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.labelInstructions);
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Controls.Add(this.inputButton);
            this.inputGroupBox.Enabled = false;
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.Location = new System.Drawing.Point(18, 232);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputGroupBox.Size = new System.Drawing.Size(300, 220);
            this.inputGroupBox.TabIndex = 5;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(16, 79);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(276, 41);
            this.labelInstructions.TabIndex = 4;
            this.labelInstructions.Text = "Input command:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(14, 125);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(274, 26);
            this.inputTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton.Location = new System.Drawing.Point(14, 171);
            this.inputButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(276, 35);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Send message";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputButton);
            this.outputGroupBox.Controls.Add(this.outputlistBox);
            this.outputGroupBox.Enabled = false;
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroupBox.Location = new System.Drawing.Point(327, 232);
            this.outputGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputGroupBox.Size = new System.Drawing.Size(300, 220);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(9, 171);
            this.outputButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(280, 35);
            this.outputButton.TabIndex = 0;
            this.outputButton.Text = "Read message";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputlistBox
            // 
            this.outputlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistBox.FormattingEnabled = true;
            this.outputlistBox.ItemHeight = 20;
            this.outputlistBox.Location = new System.Drawing.Point(10, 29);
            this.outputlistBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputlistBox.Name = "outputlistBox";
            this.outputlistBox.Size = new System.Drawing.Size(278, 124);
            this.outputlistBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btStopD);
            this.groupBox1.Controls.Add(this.btStartD);
            this.groupBox1.Location = new System.Drawing.Point(674, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "turn right";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "turn left";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btStopD
            // 
            this.btStopD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStopD.Location = new System.Drawing.Point(20, 122);
            this.btStopD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStopD.Name = "btStopD";
            this.btStopD.Size = new System.Drawing.Size(180, 35);
            this.btStopD.TabIndex = 10;
            this.btStopD.Text = "Stop driving";
            this.btStopD.UseVisualStyleBackColor = true;
            this.btStopD.Click += new System.EventHandler(this.btStopD_Click);
            // 
            // btStartD
            // 
            this.btStartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartD.Location = new System.Drawing.Point(20, 39);
            this.btStartD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStartD.Name = "btStartD";
            this.btStartD.Size = new System.Drawing.Size(180, 35);
            this.btStartD.TabIndex = 9;
            this.btStartD.Text = "Start driving";
            this.btStartD.UseVisualStyleBackColor = true;
            this.btStartD.Click += new System.EventHandler(this.btStartD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDP);
            this.groupBox2.Controls.Add(this.btStartP);
            this.groupBox2.Location = new System.Drawing.Point(674, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 191);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picking";
            // 
            // btDP
            // 
            this.btDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDP.Location = new System.Drawing.Point(20, 123);
            this.btDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDP.Name = "btDP";
            this.btDP.Size = new System.Drawing.Size(180, 54);
            this.btDP.TabIndex = 14;
            this.btDP.Text = "Drop off";
            this.btDP.UseVisualStyleBackColor = true;
            this.btDP.Click += new System.EventHandler(this.btDP_Click);
            // 
            // btStartP
            // 
            this.btStartP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartP.Location = new System.Drawing.Point(20, 41);
            this.btStartP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStartP.Name = "btStartP";
            this.btStartP.Size = new System.Drawing.Size(180, 57);
            this.btStartP.TabIndex = 13;
            this.btStartP.Text = "Start picking";
            this.btStartP.UseVisualStyleBackColor = true;
            this.btStartP.Click += new System.EventHandler(this.btStartP_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "go back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(12, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automating";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start following";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(375, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 52);
            this.button5.TabIndex = 1;
            this.button5.Text = "Pause";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(609, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 52);
            this.button6.TabIndex = 2;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LegoMindstormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LegoMindstormsForm";
            this.Text = "LEGO GROUP-A";
            this.Load += new System.EventHandler(this.LegoMindstormsForm_Load);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ListBox outputlistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btStopD;
        private System.Windows.Forms.Button btStartD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btStartP;
        private System.Windows.Forms.Button btDP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

