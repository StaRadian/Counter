namespace Counter
{
    partial class TimerBoardForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerBoardForm));
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.topTimerLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.StarPictureBox = new System.Windows.Forms.PictureBox();
            this.mazeLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bottomTimerLabel = new System.Windows.Forms.Label();
            this.recordGroupBox = new System.Windows.Forms.GroupBox();
            this.recordListBox = new System.Windows.Forms.ListBox();
            this.rankGroupBox = new System.Windows.Forms.GroupBox();
            this.rankPanel = new System.Windows.Forms.Panel();
            this.rankRecordLabel5 = new System.Windows.Forms.Label();
            this.rankNameLabel5 = new System.Windows.Forms.Label();
            this.rankRecordLabel4 = new System.Windows.Forms.Label();
            this.rankNameLabel4 = new System.Windows.Forms.Label();
            this.rankRecordLabel3 = new System.Windows.Forms.Label();
            this.rankNameLabel3 = new System.Windows.Forms.Label();
            this.rankRecordLabel2 = new System.Windows.Forms.Label();
            this.rankNameLabel2 = new System.Windows.Forms.Label();
            this.rankRecordLabel1 = new System.Windows.Forms.Label();
            this.rankNameLabel1 = new System.Windows.Forms.Label();
            this.Rank5IconLabel = new System.Windows.Forms.Label();
            this.Rank4IconLabel = new System.Windows.Forms.Label();
            this.Rank3IconLabel = new System.Windows.Forms.Label();
            this.Rank2IconLabel = new System.Windows.Forms.Label();
            this.Rank1IconLabel = new System.Windows.Forms.Label();
            this.waitingGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingListBox = new System.Windows.Forms.ListBox();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.robotGroupBox = new System.Windows.Forms.GroupBox();
            this.robotLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeLogoPictureBox)).BeginInit();
            this.recordGroupBox.SuspendLayout();
            this.rankGroupBox.SuspendLayout();
            this.rankPanel.SuspendLayout();
            this.waitingGroupBox.SuspendLayout();
            this.playerGroupBox.SuspendLayout();
            this.robotGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 20;
            this.DrawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // topTimerLabel
            // 
            this.topTimerLabel.Font = new System.Drawing.Font("Consolas", 110F);
            this.topTimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.topTimerLabel.Location = new System.Drawing.Point(3, 149);
            this.topTimerLabel.Name = "topTimerLabel";
            this.topTimerLabel.Size = new System.Drawing.Size(728, 171);
            this.topTimerLabel.TabIndex = 0;
            this.topTimerLabel.Text = "00:00:00";
            this.topTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.titlePanel.Controls.Add(this.StarPictureBox);
            this.titlePanel.Controls.Add(this.mazeLogoPictureBox);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(0, 49);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1280, 97);
            this.titlePanel.TabIndex = 1;
            // 
            // StarPictureBox
            // 
            this.StarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StarPictureBox.Image")));
            this.StarPictureBox.Location = new System.Drawing.Point(1046, -33);
            this.StarPictureBox.Name = "StarPictureBox";
            this.StarPictureBox.Size = new System.Drawing.Size(307, 193);
            this.StarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StarPictureBox.TabIndex = 5;
            this.StarPictureBox.TabStop = false;
            // 
            // mazeLogoPictureBox
            // 
            this.mazeLogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mazeLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mazeLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mazeLogoPictureBox.Image")));
            this.mazeLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mazeLogoPictureBox.Name = "mazeLogoPictureBox";
            this.mazeLogoPictureBox.Size = new System.Drawing.Size(186, 98);
            this.mazeLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mazeLogoPictureBox.TabIndex = 3;
            this.mazeLogoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("돋움", 37F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(192, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(836, 96);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "대회 제목";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomTimerLabel
            // 
            this.bottomTimerLabel.Font = new System.Drawing.Font("Consolas", 110F);
            this.bottomTimerLabel.Location = new System.Drawing.Point(3, 309);
            this.bottomTimerLabel.Name = "bottomTimerLabel";
            this.bottomTimerLabel.Size = new System.Drawing.Size(728, 171);
            this.bottomTimerLabel.TabIndex = 2;
            this.bottomTimerLabel.Text = "00:00:00";
            this.bottomTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordGroupBox
            // 
            this.recordGroupBox.Controls.Add(this.recordListBox);
            this.recordGroupBox.Font = new System.Drawing.Font("Consolas", 24F);
            this.recordGroupBox.Location = new System.Drawing.Point(737, 424);
            this.recordGroupBox.Name = "recordGroupBox";
            this.recordGroupBox.Size = new System.Drawing.Size(167, 255);
            this.recordGroupBox.TabIndex = 3;
            this.recordGroupBox.TabStop = false;
            this.recordGroupBox.Text = "Record";
            // 
            // recordListBox
            // 
            this.recordListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.recordListBox.Font = new System.Drawing.Font("Consolas", 23F);
            this.recordListBox.FormattingEnabled = true;
            this.recordListBox.ItemHeight = 37;
            this.recordListBox.Location = new System.Drawing.Point(6, 44);
            this.recordListBox.Name = "recordListBox";
            this.recordListBox.Size = new System.Drawing.Size(155, 189);
            this.recordListBox.TabIndex = 1;
            // 
            // rankGroupBox
            // 
            this.rankGroupBox.Controls.Add(this.rankPanel);
            this.rankGroupBox.Font = new System.Drawing.Font("Consolas", 24F);
            this.rankGroupBox.Location = new System.Drawing.Point(910, 424);
            this.rankGroupBox.Name = "rankGroupBox";
            this.rankGroupBox.Size = new System.Drawing.Size(358, 255);
            this.rankGroupBox.TabIndex = 4;
            this.rankGroupBox.TabStop = false;
            this.rankGroupBox.Text = "Rank";
            // 
            // rankPanel
            // 
            this.rankPanel.Controls.Add(this.rankRecordLabel5);
            this.rankPanel.Controls.Add(this.rankNameLabel5);
            this.rankPanel.Controls.Add(this.rankRecordLabel4);
            this.rankPanel.Controls.Add(this.rankNameLabel4);
            this.rankPanel.Controls.Add(this.rankRecordLabel3);
            this.rankPanel.Controls.Add(this.rankNameLabel3);
            this.rankPanel.Controls.Add(this.rankRecordLabel2);
            this.rankPanel.Controls.Add(this.rankNameLabel2);
            this.rankPanel.Controls.Add(this.rankRecordLabel1);
            this.rankPanel.Controls.Add(this.rankNameLabel1);
            this.rankPanel.Controls.Add(this.Rank5IconLabel);
            this.rankPanel.Controls.Add(this.Rank4IconLabel);
            this.rankPanel.Controls.Add(this.Rank3IconLabel);
            this.rankPanel.Controls.Add(this.Rank2IconLabel);
            this.rankPanel.Controls.Add(this.Rank1IconLabel);
            this.rankPanel.Location = new System.Drawing.Point(6, 44);
            this.rankPanel.Name = "rankPanel";
            this.rankPanel.Size = new System.Drawing.Size(346, 191);
            this.rankPanel.TabIndex = 6;
            // 
            // rankRecordLabel5
            // 
            this.rankRecordLabel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankRecordLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankRecordLabel5.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankRecordLabel5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rankRecordLabel5.Location = new System.Drawing.Point(224, 151);
            this.rankRecordLabel5.Name = "rankRecordLabel5";
            this.rankRecordLabel5.Size = new System.Drawing.Size(119, 38);
            this.rankRecordLabel5.TabIndex = 24;
            this.rankRecordLabel5.Text = "00:00:00";
            this.rankRecordLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankNameLabel5
            // 
            this.rankNameLabel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankNameLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankNameLabel5.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankNameLabel5.Location = new System.Drawing.Point(44, 152);
            this.rankNameLabel5.Name = "rankNameLabel5";
            this.rankNameLabel5.Size = new System.Drawing.Size(174, 38);
            this.rankNameLabel5.TabIndex = 23;
            this.rankNameLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankRecordLabel4
            // 
            this.rankRecordLabel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankRecordLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankRecordLabel4.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankRecordLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rankRecordLabel4.Location = new System.Drawing.Point(224, 114);
            this.rankRecordLabel4.Name = "rankRecordLabel4";
            this.rankRecordLabel4.Size = new System.Drawing.Size(119, 38);
            this.rankRecordLabel4.TabIndex = 22;
            this.rankRecordLabel4.Text = "00:00:00";
            this.rankRecordLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankNameLabel4
            // 
            this.rankNameLabel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankNameLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankNameLabel4.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankNameLabel4.Location = new System.Drawing.Point(44, 114);
            this.rankNameLabel4.Name = "rankNameLabel4";
            this.rankNameLabel4.Size = new System.Drawing.Size(174, 38);
            this.rankNameLabel4.TabIndex = 21;
            this.rankNameLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankRecordLabel3
            // 
            this.rankRecordLabel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankRecordLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankRecordLabel3.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankRecordLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rankRecordLabel3.Location = new System.Drawing.Point(224, 76);
            this.rankRecordLabel3.Name = "rankRecordLabel3";
            this.rankRecordLabel3.Size = new System.Drawing.Size(119, 38);
            this.rankRecordLabel3.TabIndex = 20;
            this.rankRecordLabel3.Text = "00:00:00";
            this.rankRecordLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankNameLabel3
            // 
            this.rankNameLabel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankNameLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankNameLabel3.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankNameLabel3.Location = new System.Drawing.Point(44, 76);
            this.rankNameLabel3.Name = "rankNameLabel3";
            this.rankNameLabel3.Size = new System.Drawing.Size(174, 38);
            this.rankNameLabel3.TabIndex = 19;
            this.rankNameLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankRecordLabel2
            // 
            this.rankRecordLabel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankRecordLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankRecordLabel2.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankRecordLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rankRecordLabel2.Location = new System.Drawing.Point(224, 38);
            this.rankRecordLabel2.Name = "rankRecordLabel2";
            this.rankRecordLabel2.Size = new System.Drawing.Size(119, 38);
            this.rankRecordLabel2.TabIndex = 18;
            this.rankRecordLabel2.Text = "00:00:00";
            this.rankRecordLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankNameLabel2
            // 
            this.rankNameLabel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankNameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankNameLabel2.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankNameLabel2.Location = new System.Drawing.Point(44, 38);
            this.rankNameLabel2.Name = "rankNameLabel2";
            this.rankNameLabel2.Size = new System.Drawing.Size(174, 38);
            this.rankNameLabel2.TabIndex = 17;
            this.rankNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankRecordLabel1
            // 
            this.rankRecordLabel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankRecordLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankRecordLabel1.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankRecordLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rankRecordLabel1.Location = new System.Drawing.Point(224, 0);
            this.rankRecordLabel1.Name = "rankRecordLabel1";
            this.rankRecordLabel1.Size = new System.Drawing.Size(119, 38);
            this.rankRecordLabel1.TabIndex = 16;
            this.rankRecordLabel1.Text = "00:00:00";
            this.rankRecordLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankNameLabel1
            // 
            this.rankNameLabel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rankNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rankNameLabel1.Font = new System.Drawing.Font("Consolas", 16F);
            this.rankNameLabel1.Location = new System.Drawing.Point(44, 0);
            this.rankNameLabel1.Name = "rankNameLabel1";
            this.rankNameLabel1.Size = new System.Drawing.Size(174, 38);
            this.rankNameLabel1.TabIndex = 15;
            this.rankNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rank5IconLabel
            // 
            this.Rank5IconLabel.BackColor = System.Drawing.Color.DarkGray;
            this.Rank5IconLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rank5IconLabel.Font = new System.Drawing.Font("Consolas", 14F);
            this.Rank5IconLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rank5IconLabel.Location = new System.Drawing.Point(0, 152);
            this.Rank5IconLabel.Name = "Rank5IconLabel";
            this.Rank5IconLabel.Size = new System.Drawing.Size(38, 38);
            this.Rank5IconLabel.TabIndex = 9;
            this.Rank5IconLabel.Text = "5";
            this.Rank5IconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rank4IconLabel
            // 
            this.Rank4IconLabel.BackColor = System.Drawing.Color.DarkGray;
            this.Rank4IconLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rank4IconLabel.Font = new System.Drawing.Font("Consolas", 14F);
            this.Rank4IconLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rank4IconLabel.Location = new System.Drawing.Point(0, 114);
            this.Rank4IconLabel.Name = "Rank4IconLabel";
            this.Rank4IconLabel.Size = new System.Drawing.Size(38, 38);
            this.Rank4IconLabel.TabIndex = 8;
            this.Rank4IconLabel.Text = "4";
            this.Rank4IconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rank3IconLabel
            // 
            this.Rank3IconLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Rank3IconLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rank3IconLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.Rank3IconLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rank3IconLabel.Location = new System.Drawing.Point(0, 76);
            this.Rank3IconLabel.Name = "Rank3IconLabel";
            this.Rank3IconLabel.Size = new System.Drawing.Size(38, 38);
            this.Rank3IconLabel.TabIndex = 7;
            this.Rank3IconLabel.Text = "3";
            this.Rank3IconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rank2IconLabel
            // 
            this.Rank2IconLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Rank2IconLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rank2IconLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.Rank2IconLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rank2IconLabel.Location = new System.Drawing.Point(0, 38);
            this.Rank2IconLabel.Name = "Rank2IconLabel";
            this.Rank2IconLabel.Size = new System.Drawing.Size(38, 38);
            this.Rank2IconLabel.TabIndex = 6;
            this.Rank2IconLabel.Text = "2";
            this.Rank2IconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rank1IconLabel
            // 
            this.Rank1IconLabel.BackColor = System.Drawing.Color.Gold;
            this.Rank1IconLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rank1IconLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.Rank1IconLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rank1IconLabel.Location = new System.Drawing.Point(0, 0);
            this.Rank1IconLabel.Name = "Rank1IconLabel";
            this.Rank1IconLabel.Size = new System.Drawing.Size(38, 38);
            this.Rank1IconLabel.TabIndex = 5;
            this.Rank1IconLabel.Text = "1";
            this.Rank1IconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitingGroupBox
            // 
            this.waitingGroupBox.Controls.Add(this.waitingListBox);
            this.waitingGroupBox.Font = new System.Drawing.Font("Consolas", 24F);
            this.waitingGroupBox.Location = new System.Drawing.Point(12, 483);
            this.waitingGroupBox.Name = "waitingGroupBox";
            this.waitingGroupBox.Size = new System.Drawing.Size(719, 196);
            this.waitingGroupBox.TabIndex = 4;
            this.waitingGroupBox.TabStop = false;
            this.waitingGroupBox.Text = "Waiting";
            // 
            // waitingListBox
            // 
            this.waitingListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.waitingListBox.Font = new System.Drawing.Font("Consolas", 20F);
            this.waitingListBox.FormattingEnabled = true;
            this.waitingListBox.ItemHeight = 32;
            this.waitingListBox.Location = new System.Drawing.Point(6, 40);
            this.waitingListBox.Name = "waitingListBox";
            this.waitingListBox.Size = new System.Drawing.Size(707, 132);
            this.waitingListBox.TabIndex = 0;
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.playerLabel);
            this.playerGroupBox.Font = new System.Drawing.Font("Consolas", 24F);
            this.playerGroupBox.Location = new System.Drawing.Point(737, 152);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(531, 128);
            this.playerGroupBox.TabIndex = 4;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "Player";
            // 
            // playerLabel
            // 
            this.playerLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.playerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerLabel.Font = new System.Drawing.Font("Consolas", 34F);
            this.playerLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.playerLabel.Location = new System.Drawing.Point(6, 41);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(519, 76);
            this.playerLabel.TabIndex = 29;
            this.playerLabel.Text = "Empty Player";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // robotGroupBox
            // 
            this.robotGroupBox.Controls.Add(this.robotLabel);
            this.robotGroupBox.Font = new System.Drawing.Font("Consolas", 24F);
            this.robotGroupBox.Location = new System.Drawing.Point(737, 286);
            this.robotGroupBox.Name = "robotGroupBox";
            this.robotGroupBox.Size = new System.Drawing.Size(531, 128);
            this.robotGroupBox.TabIndex = 30;
            this.robotGroupBox.TabStop = false;
            this.robotGroupBox.Text = "Robot";
            // 
            // robotLabel
            // 
            this.robotLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.robotLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.robotLabel.Font = new System.Drawing.Font("Consolas", 34F);
            this.robotLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.robotLabel.Location = new System.Drawing.Point(6, 35);
            this.robotLabel.Name = "robotLabel";
            this.robotLabel.Size = new System.Drawing.Size(519, 76);
            this.robotLabel.TabIndex = 29;
            this.robotLabel.Text = "Empty Robot";
            this.robotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.robotGroupBox);
            this.Controls.Add(this.playerGroupBox);
            this.Controls.Add(this.waitingGroupBox);
            this.Controls.Add(this.rankGroupBox);
            this.Controls.Add(this.recordGroupBox);
            this.Controls.Add(this.bottomTimerLabel);
            this.Controls.Add(this.topTimerLabel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerBoardForm";
            this.Text = "MazeBoard";
            this.Load += new System.EventHandler(this.TimerBoardForm_Load);
            this.Resize += new System.EventHandler(this.Resize_TimerBoardFrom);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeLogoPictureBox)).EndInit();
            this.recordGroupBox.ResumeLayout(false);
            this.rankGroupBox.ResumeLayout(false);
            this.rankPanel.ResumeLayout(false);
            this.waitingGroupBox.ResumeLayout(false);
            this.playerGroupBox.ResumeLayout(false);
            this.robotGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Label topTimerLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label bottomTimerLabel;
        private System.Windows.Forms.PictureBox mazeLogoPictureBox;
        private System.Windows.Forms.GroupBox recordGroupBox;
        private System.Windows.Forms.GroupBox rankGroupBox;
        private System.Windows.Forms.GroupBox waitingGroupBox;
        private System.Windows.Forms.ListBox recordListBox;
        private System.Windows.Forms.ListBox waitingListBox;
        private System.Windows.Forms.PictureBox StarPictureBox;
        private System.Windows.Forms.Panel rankPanel;
        private System.Windows.Forms.Label Rank1IconLabel;
        private System.Windows.Forms.Label Rank5IconLabel;
        private System.Windows.Forms.Label Rank4IconLabel;
        private System.Windows.Forms.Label Rank3IconLabel;
        private System.Windows.Forms.Label Rank2IconLabel;
        private System.Windows.Forms.Label rankRecordLabel5;
        private System.Windows.Forms.Label rankNameLabel5;
        private System.Windows.Forms.Label rankRecordLabel4;
        private System.Windows.Forms.Label rankNameLabel4;
        private System.Windows.Forms.Label rankRecordLabel3;
        private System.Windows.Forms.Label rankNameLabel3;
        private System.Windows.Forms.Label rankRecordLabel2;
        private System.Windows.Forms.Label rankNameLabel2;
        private System.Windows.Forms.Label rankRecordLabel1;
        private System.Windows.Forms.Label rankNameLabel1;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.GroupBox robotGroupBox;
        private System.Windows.Forms.Label robotLabel;
    }
}

