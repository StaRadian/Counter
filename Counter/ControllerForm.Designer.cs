namespace Counter
{
    partial class ControllerForm
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
            this.contestComboBox = new System.Windows.Forms.ComboBox();
            this.contestApplyButton = new System.Windows.Forms.Button();
            this.contestSelectPanel = new System.Windows.Forms.Panel();
            this.contestFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentPlayerIndexLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.nextPlayerButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.recordsListBox = new System.Windows.Forms.ListBox();
            this.resultSavePanel = new System.Windows.Forms.Panel();
            this.fileApplyButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.debugButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.bRecordButton = new System.Windows.Forms.Button();
            this.debugEnableButton = new System.Windows.Forms.Button();
            this.tRecordButton = new System.Windows.Forms.Button();
            this.bStartButton = new System.Windows.Forms.Button();
            this.tStartButton = new System.Windows.Forms.Button();
            this.bStopButton = new System.Windows.Forms.Button();
            this.tStopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.bResetButton = new System.Windows.Forms.Button();
            this.tResetButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.connectPanel = new System.Windows.Forms.Panel();
            this.sensor2StateLabel = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.sensor1StateLabel = new System.Windows.Forms.Label();
            this.sensor2Label = new System.Windows.Forms.Label();
            this.sensor1Label = new System.Windows.Forms.Label();
            this.contestSelectPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.resultSavePanel.SuspendLayout();
            this.debugButtonGroupBox.SuspendLayout();
            this.connectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contestComboBox
            // 
            this.contestComboBox.FormattingEnabled = true;
            this.contestComboBox.Location = new System.Drawing.Point(0, 0);
            this.contestComboBox.Name = "contestComboBox";
            this.contestComboBox.Size = new System.Drawing.Size(313, 20);
            this.contestComboBox.TabIndex = 6;
            this.contestComboBox.SelectedIndexChanged += new System.EventHandler(this.contestComboBox_SelectedIndexChanged);
            // 
            // contestApplyButton
            // 
            this.contestApplyButton.Location = new System.Drawing.Point(319, 0);
            this.contestApplyButton.Name = "contestApplyButton";
            this.contestApplyButton.Size = new System.Drawing.Size(76, 20);
            this.contestApplyButton.TabIndex = 7;
            this.contestApplyButton.Text = "대회 선택";
            this.contestApplyButton.UseVisualStyleBackColor = true;
            this.contestApplyButton.Click += new System.EventHandler(this.contestApplyButton_Click);
            // 
            // contestSelectPanel
            // 
            this.contestSelectPanel.Controls.Add(this.contestApplyButton);
            this.contestSelectPanel.Controls.Add(this.contestComboBox);
            this.contestSelectPanel.Location = new System.Drawing.Point(0, 52);
            this.contestSelectPanel.Name = "contestSelectPanel";
            this.contestSelectPanel.Size = new System.Drawing.Size(395, 20);
            this.contestSelectPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentPlayerIndexLabel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.playerListBox);
            this.panel1.Location = new System.Drawing.Point(1, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 247);
            this.panel1.TabIndex = 10;
            // 
            // currentPlayerIndexLabel
            // 
            this.currentPlayerIndexLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerIndexLabel.Location = new System.Drawing.Point(237, 111);
            this.currentPlayerIndexLabel.Name = "currentPlayerIndexLabel";
            this.currentPlayerIndexLabel.Size = new System.Drawing.Size(154, 22);
            this.currentPlayerIndexLabel.TabIndex = 12;
            this.currentPlayerIndexLabel.Text = "???";
            this.currentPlayerIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(233, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 21);
            this.button5.TabIndex = 11;
            this.button5.Text = "다음 순서로 이동";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 21);
            this.button4.TabIndex = 10;
            this.button4.Text = "마지막 순서로 이동";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 21);
            this.button3.TabIndex = 9;
            this.button3.Text = "유저 삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "저장";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(233, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "유저 추가";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(6, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 21);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "순서 입력";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "선수 이름 입력";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(6, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "로봇 이름 입력";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 12;
            this.playerListBox.Location = new System.Drawing.Point(0, 0);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(227, 244);
            this.playerListBox.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.button11);
            this.buttonPanel.Controls.Add(this.button10);
            this.buttonPanel.Controls.Add(this.nextPlayerButton);
            this.buttonPanel.Controls.Add(this.button7);
            this.buttonPanel.Location = new System.Drawing.Point(1, 438);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(394, 56);
            this.buttonPanel.TabIndex = 11;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(201, 30);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 21);
            this.button11.TabIndex = 12;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 30);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(192, 21);
            this.button10.TabIndex = 11;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // nextPlayerButton
            // 
            this.nextPlayerButton.Location = new System.Drawing.Point(201, 4);
            this.nextPlayerButton.Name = "nextPlayerButton";
            this.nextPlayerButton.Size = new System.Drawing.Size(192, 21);
            this.nextPlayerButton.TabIndex = 10;
            this.nextPlayerButton.Text = "다음 순서";
            this.nextPlayerButton.UseVisualStyleBackColor = true;
            this.nextPlayerButton.Click += new System.EventHandler(this.nextPlayerButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 21);
            this.button7.TabIndex = 9;
            this.button7.Text = "준비";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.Enabled = false;
            this.recordButton.Location = new System.Drawing.Point(303, 20);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(89, 21);
            this.recordButton.TabIndex = 13;
            this.recordButton.Text = "기록";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(99, 20);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(89, 21);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "중지";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(0, 20);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(89, 21);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "시작";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.recordsListBox);
            this.panel2.Location = new System.Drawing.Point(2, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 80);
            this.panel2.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(305, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 21);
            this.button6.TabIndex = 11;
            this.button6.Text = "기록 비허용";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(305, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 21);
            this.button8.TabIndex = 10;
            this.button8.Text = "기록 삭제";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // recordsListBox
            // 
            this.recordsListBox.FormattingEnabled = true;
            this.recordsListBox.ItemHeight = 12;
            this.recordsListBox.Location = new System.Drawing.Point(0, 0);
            this.recordsListBox.Name = "recordsListBox";
            this.recordsListBox.Size = new System.Drawing.Size(299, 76);
            this.recordsListBox.TabIndex = 0;
            // 
            // resultSavePanel
            // 
            this.resultSavePanel.Controls.Add(this.fileApplyButton);
            this.resultSavePanel.Controls.Add(this.comboBox1);
            this.resultSavePanel.Location = new System.Drawing.Point(0, 80);
            this.resultSavePanel.Name = "resultSavePanel";
            this.resultSavePanel.Size = new System.Drawing.Size(394, 20);
            this.resultSavePanel.TabIndex = 14;
            // 
            // fileApplyButton
            // 
            this.fileApplyButton.Location = new System.Drawing.Point(274, -1);
            this.fileApplyButton.Name = "fileApplyButton";
            this.fileApplyButton.Size = new System.Drawing.Size(123, 20);
            this.fileApplyButton.TabIndex = 8;
            this.fileApplyButton.Text = "결과파일위치 선택";
            this.fileApplyButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // debugButtonGroupBox
            // 
            this.debugButtonGroupBox.Controls.Add(this.bRecordButton);
            this.debugButtonGroupBox.Controls.Add(this.debugEnableButton);
            this.debugButtonGroupBox.Controls.Add(this.tRecordButton);
            this.debugButtonGroupBox.Controls.Add(this.bStartButton);
            this.debugButtonGroupBox.Controls.Add(this.tStartButton);
            this.debugButtonGroupBox.Controls.Add(this.bStopButton);
            this.debugButtonGroupBox.Controls.Add(this.tStopButton);
            this.debugButtonGroupBox.Controls.Add(this.ResetButton);
            this.debugButtonGroupBox.Controls.Add(this.bResetButton);
            this.debugButtonGroupBox.Controls.Add(this.tResetButton);
            this.debugButtonGroupBox.Controls.Add(this.recordButton);
            this.debugButtonGroupBox.Controls.Add(this.stopButton);
            this.debugButtonGroupBox.Controls.Add(this.startButton);
            this.debugButtonGroupBox.Location = new System.Drawing.Point(1, 495);
            this.debugButtonGroupBox.Name = "debugButtonGroupBox";
            this.debugButtonGroupBox.Size = new System.Drawing.Size(393, 128);
            this.debugButtonGroupBox.TabIndex = 15;
            this.debugButtonGroupBox.TabStop = false;
            this.debugButtonGroupBox.Text = "Debug";
            // 
            // bRecordButton
            // 
            this.bRecordButton.Enabled = false;
            this.bRecordButton.Location = new System.Drawing.Point(303, 74);
            this.bRecordButton.Name = "bRecordButton";
            this.bRecordButton.Size = new System.Drawing.Size(89, 21);
            this.bRecordButton.TabIndex = 22;
            this.bRecordButton.Text = "B 기록";
            this.bRecordButton.UseVisualStyleBackColor = true;
            this.bRecordButton.Click += new System.EventHandler(this.bRecordButton_Click);
            // 
            // debugEnableButton
            // 
            this.debugEnableButton.Location = new System.Drawing.Point(1, 101);
            this.debugEnableButton.Name = "debugEnableButton";
            this.debugEnableButton.Size = new System.Drawing.Size(393, 21);
            this.debugEnableButton.TabIndex = 23;
            this.debugEnableButton.Text = "Debug버튼(비활성화)";
            this.debugEnableButton.UseVisualStyleBackColor = true;
            this.debugEnableButton.Click += new System.EventHandler(this.debugEnableButton_Click);
            // 
            // tRecordButton
            // 
            this.tRecordButton.Enabled = false;
            this.tRecordButton.Location = new System.Drawing.Point(303, 47);
            this.tRecordButton.Name = "tRecordButton";
            this.tRecordButton.Size = new System.Drawing.Size(89, 21);
            this.tRecordButton.TabIndex = 21;
            this.tRecordButton.Text = "T 기록";
            this.tRecordButton.UseVisualStyleBackColor = true;
            this.tRecordButton.Click += new System.EventHandler(this.tRecordButton_Click);
            // 
            // bStartButton
            // 
            this.bStartButton.Enabled = false;
            this.bStartButton.Location = new System.Drawing.Point(0, 74);
            this.bStartButton.Name = "bStartButton";
            this.bStartButton.Size = new System.Drawing.Size(89, 21);
            this.bStartButton.TabIndex = 20;
            this.bStartButton.Text = "B 시작";
            this.bStartButton.UseVisualStyleBackColor = true;
            this.bStartButton.Click += new System.EventHandler(this.bStartButton_Click);
            // 
            // tStartButton
            // 
            this.tStartButton.Enabled = false;
            this.tStartButton.Location = new System.Drawing.Point(0, 47);
            this.tStartButton.Name = "tStartButton";
            this.tStartButton.Size = new System.Drawing.Size(89, 21);
            this.tStartButton.TabIndex = 19;
            this.tStartButton.Text = "T 시작";
            this.tStartButton.UseVisualStyleBackColor = true;
            this.tStartButton.Click += new System.EventHandler(this.tStartButton_Click);
            // 
            // bStopButton
            // 
            this.bStopButton.Enabled = false;
            this.bStopButton.Location = new System.Drawing.Point(99, 74);
            this.bStopButton.Name = "bStopButton";
            this.bStopButton.Size = new System.Drawing.Size(89, 21);
            this.bStopButton.TabIndex = 18;
            this.bStopButton.Text = "B 중지";
            this.bStopButton.UseVisualStyleBackColor = true;
            this.bStopButton.Click += new System.EventHandler(this.bStopButton_Click);
            // 
            // tStopButton
            // 
            this.tStopButton.Enabled = false;
            this.tStopButton.Location = new System.Drawing.Point(99, 47);
            this.tStopButton.Name = "tStopButton";
            this.tStopButton.Size = new System.Drawing.Size(89, 21);
            this.tStopButton.TabIndex = 17;
            this.tStopButton.Text = "T 중지";
            this.tStopButton.UseVisualStyleBackColor = true;
            this.tStopButton.Click += new System.EventHandler(this.tStopButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(204, 20);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(89, 21);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "리셋";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // bResetButton
            // 
            this.bResetButton.Enabled = false;
            this.bResetButton.Location = new System.Drawing.Point(204, 74);
            this.bResetButton.Name = "bResetButton";
            this.bResetButton.Size = new System.Drawing.Size(90, 21);
            this.bResetButton.TabIndex = 15;
            this.bResetButton.Text = "B 리셋";
            this.bResetButton.UseVisualStyleBackColor = true;
            this.bResetButton.Click += new System.EventHandler(this.bResetButton_Click);
            // 
            // tResetButton
            // 
            this.tResetButton.Enabled = false;
            this.tResetButton.Location = new System.Drawing.Point(204, 47);
            this.tResetButton.Name = "tResetButton";
            this.tResetButton.Size = new System.Drawing.Size(90, 21);
            this.tResetButton.TabIndex = 14;
            this.tResetButton.Text = "T 리셋";
            this.tResetButton.UseVisualStyleBackColor = true;
            this.tResetButton.Click += new System.EventHandler(this.tResetButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // connectPanel
            // 
            this.connectPanel.Controls.Add(this.sensor1Label);
            this.connectPanel.Controls.Add(this.sensor2Label);
            this.connectPanel.Controls.Add(this.sensor1StateLabel);
            this.connectPanel.Controls.Add(this.sensor2StateLabel);
            this.connectPanel.Controls.Add(this.button9);
            this.connectPanel.Controls.Add(this.serialTextBox);
            this.connectPanel.Controls.Add(this.portComboBox);
            this.connectPanel.Controls.Add(this.connectButton);
            this.connectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectPanel.Location = new System.Drawing.Point(0, 0);
            this.connectPanel.Name = "connectPanel";
            this.connectPanel.Size = new System.Drawing.Size(395, 46);
            this.connectPanel.TabIndex = 8;
            // 
            // sensor2StateLabel
            // 
            this.sensor2StateLabel.BackColor = System.Drawing.Color.Gray;
            this.sensor2StateLabel.Location = new System.Drawing.Point(190, 23);
            this.sensor2StateLabel.Name = "sensor2StateLabel";
            this.sensor2StateLabel.Size = new System.Drawing.Size(79, 20);
            this.sensor2StateLabel.TabIndex = 14;
            this.sensor2StateLabel.Text = "연결 안됨";
            this.sensor2StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("굴림", 9F);
            this.button9.Location = new System.Drawing.Point(275, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 20);
            this.button9.TabIndex = 13;
            this.button9.Text = "센서Setting";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(0, -1);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(183, 21);
            this.serialTextBox.TabIndex = 12;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(189, 0);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(79, 20);
            this.portComboBox.TabIndex = 8;
            this.portComboBox.DropDown += new System.EventHandler(this.portComboBox_DropDown);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("굴림", 9F);
            this.connectButton.Location = new System.Drawing.Point(274, 0);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(122, 20);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "접속 안됨";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // sensor1StateLabel
            // 
            this.sensor1StateLabel.BackColor = System.Drawing.Color.Gray;
            this.sensor1StateLabel.Location = new System.Drawing.Point(55, 23);
            this.sensor1StateLabel.Name = "sensor1StateLabel";
            this.sensor1StateLabel.Size = new System.Drawing.Size(79, 20);
            this.sensor1StateLabel.TabIndex = 15;
            this.sensor1StateLabel.Text = "연결 안됨";
            this.sensor1StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sensor2Label
            // 
            this.sensor2Label.Location = new System.Drawing.Point(140, 23);
            this.sensor2Label.Name = "sensor2Label";
            this.sensor2Label.Size = new System.Drawing.Size(43, 20);
            this.sensor2Label.TabIndex = 16;
            this.sensor2Label.Text = "End";
            this.sensor2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sensor1Label
            // 
            this.sensor1Label.Location = new System.Drawing.Point(6, 23);
            this.sensor1Label.Name = "sensor1Label";
            this.sensor1Label.Size = new System.Drawing.Size(43, 20);
            this.sensor1Label.TabIndex = 17;
            this.sensor1Label.Text = "Start";
            this.sensor1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 650);
            this.Controls.Add(this.connectPanel);
            this.Controls.Add(this.debugButtonGroupBox);
            this.Controls.Add(this.resultSavePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contestSelectPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ControllerForm";
            this.Text = "Controller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControllerForm_FormClosing);
            this.Load += new System.EventHandler(this.Controller_Load);
            this.contestSelectPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.resultSavePanel.ResumeLayout(false);
            this.debugButtonGroupBox.ResumeLayout(false);
            this.connectPanel.ResumeLayout(false);
            this.connectPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox contestComboBox;
        private System.Windows.Forms.Button contestApplyButton;
        private System.Windows.Forms.Panel contestSelectPanel;
        private System.Windows.Forms.OpenFileDialog contestFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label currentPlayerIndexLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button nextPlayerButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox recordsListBox;
        private System.Windows.Forms.Panel resultSavePanel;
        private System.Windows.Forms.Button fileApplyButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox debugButtonGroupBox;
        private System.Windows.Forms.Button bRecordButton;
        private System.Windows.Forms.Button tRecordButton;
        private System.Windows.Forms.Button bStartButton;
        private System.Windows.Forms.Button tStartButton;
        private System.Windows.Forms.Button bStopButton;
        private System.Windows.Forms.Button tStopButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button bResetButton;
        private System.Windows.Forms.Button tResetButton;
        private System.Windows.Forms.Button debugEnableButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel connectPanel;
        private System.Windows.Forms.Button connectButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label sensor2StateLabel;
        private System.Windows.Forms.Label sensor2Label;
        private System.Windows.Forms.Label sensor1StateLabel;
        private System.Windows.Forms.Label sensor1Label;
    }
}