using Counter.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Counter
{
    public struct TimerBoardData
    {
        public String title;
        public String player;
        public String robot;
        public TImerManager topTimer;
        public TImerManager bottomTimer;
        public List<TimeUnit> record;
        public List<(String name, TimeUnit time)> rank;
        public List<String> wait;
    }
    public partial class TimerBoardForm : Form
    {
        private TimerBoardData data;

        public TimerBoardForm()
        {
            InitializeComponent();
            data.topTimer = new TImerManager();
            data.bottomTimer = new TImerManager();
        }
        
        public TimerBoardForm(TimerBoardData data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void TimerBoardForm_Load(object sender, EventArgs e)
        {
            OriginalSizeSet();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            DataUpdate();
            DrawTimer.Start(); //timer 시작
        }

        public void TopTimerSet(TImerManager topTimer)
        {
            data.topTimer = topTimer;
        }
        public void BottomTimerSet(TImerManager bottomTimer)
        {
            data.bottomTimer = bottomTimer;
        }
        private string TimeUnit2TimerText(TimeUnit timeUnit)
        {
            string result = 
                (timeUnit.Minute % 60).ToString("D2") + ":" +
                (timeUnit.Second % 60).ToString("D2") + ":" +
                ((timeUnit.Millisecond / 10) % 100).ToString("D2");
            return result;
                
        }
        public void TitleUpdate()
        {
            titleLabel.Text = data.title;
        }
        public void PlayerUpdate()
        {
            if (data.player == null)
            {
                playerLabel.ForeColor = SystemColors.GrayText;
                playerLabel.Text = "Empty Player";
            }
            else
            {
                playerLabel.ForeColor = SystemColors.ControlText;
                playerLabel.Text = data.player;
            }
        }
        public void RobotUpdate()
        {
            if (data.robot == null)
            {
                robotLabel.ForeColor = SystemColors.GrayText;
                robotLabel.Text = "Empty Robot";
            }
            else
            {
                robotLabel.ForeColor = SystemColors.ControlText;
                robotLabel.Text = data.robot;
            }
        }
        public void TimerUpdate()
        {
            if (data.topTimer.UpdateState())
            {
                data.topTimer.Update();
                topTimerLabel.Text = TimeUnit2TimerText(data.topTimer.GetTimeUnit());
            }
            if (data.bottomTimer.UpdateState())
            {
                data.bottomTimer.Update();
                bottomTimerLabel.Text = TimeUnit2TimerText(data.bottomTimer.GetTimeUnit());
            }
        }
        public void RecordUpdate()
        {
            recordListBox.Items.Clear();
            if (data.record == null) return;
            foreach (var item in data.record)
            {
                recordListBox.Items.Add(TimeUnit2TimerText(item));
            }
        }
        public void RecordUpdate(List<TimeUnit> data)
        {
            this.data.record = data;
            RecordUpdate();
        }
        public void RankUpdate()
        {
            if (data.rank == null) return;
            if (data.rank.Count == 0)
            {
                rankRecordLabel1.ForeColor = SystemColors.GrayText;
                rankRecordLabel2.ForeColor = SystemColors.GrayText;
                rankRecordLabel3.ForeColor = SystemColors.GrayText;
                rankRecordLabel4.ForeColor = SystemColors.GrayText;
                rankRecordLabel5.ForeColor = SystemColors.GrayText;
                rankRecordLabel1.Text = "00:00:00";
                rankRecordLabel2.Text = "00:00:00";
                rankRecordLabel3.Text = "00:00:00";
                rankRecordLabel4.Text = "00:00:00";
                rankRecordLabel5.Text = "00:00:00";
            }
            else if(data.rank.Count == 1)
            {
                rankNameLabel1.Text = data.rank[0].name;
                rankRecordLabel1.ForeColor = SystemColors.ControlText;
                rankRecordLabel2.ForeColor = SystemColors.GrayText;
                rankRecordLabel3.ForeColor = SystemColors.GrayText;
                rankRecordLabel4.ForeColor = SystemColors.GrayText;
                rankRecordLabel5.ForeColor = SystemColors.GrayText;
                rankRecordLabel1.Text = TimeUnit2TimerText(data.rank[0].time);
                rankRecordLabel2.Text = "00:00:00";
                rankRecordLabel3.Text = "00:00:00";
                rankRecordLabel4.Text = "00:00:00";
                rankRecordLabel5.Text = "00:00:00";
            }
            else if(data.rank.Count == 2)
            {
                rankNameLabel1.Text = data.rank[0].name;
                rankNameLabel2.Text = data.rank[1].name;
                rankRecordLabel1.ForeColor = SystemColors.ControlText;
                rankRecordLabel2.ForeColor = SystemColors.ControlText;
                rankRecordLabel3.ForeColor = SystemColors.GrayText;
                rankRecordLabel4.ForeColor = SystemColors.GrayText;
                rankRecordLabel5.ForeColor = SystemColors.GrayText;
                rankRecordLabel1.Text = TimeUnit2TimerText(data.rank[0].time);
                rankRecordLabel2.Text = TimeUnit2TimerText(data.rank[1].time);
                rankRecordLabel3.Text = "00:00:00";
                rankRecordLabel4.Text = "00:00:00";
                rankRecordLabel5.Text = "00:00:00";
            }
            else if(data.rank.Count == 3)
            {
                rankNameLabel1.Text = data.rank[0].name;
                rankNameLabel2.Text = data.rank[1].name;
                rankNameLabel3.Text = data.rank[2].name;
                rankRecordLabel1.ForeColor = SystemColors.ControlText;
                rankRecordLabel2.ForeColor = SystemColors.ControlText;
                rankRecordLabel3.ForeColor = SystemColors.ControlText;
                rankRecordLabel4.ForeColor = SystemColors.GrayText;
                rankRecordLabel5.ForeColor = SystemColors.GrayText;
                rankRecordLabel1.Text = TimeUnit2TimerText(data.rank[0].time);
                rankRecordLabel2.Text = TimeUnit2TimerText(data.rank[1].time);
                rankRecordLabel3.Text = TimeUnit2TimerText(data.rank[2].time);
                rankRecordLabel4.Text = "00:00:00";
                rankRecordLabel5.Text = "00:00:00";
            }
            else if(data.rank.Count == 4)
            {
                rankNameLabel1.Text = data.rank[0].name;
                rankNameLabel2.Text = data.rank[1].name;
                rankNameLabel3.Text = data.rank[2].name;
                rankNameLabel4.Text = data.rank[3].name;
                rankRecordLabel1.ForeColor = SystemColors.ControlText;
                rankRecordLabel2.ForeColor = SystemColors.ControlText;
                rankRecordLabel3.ForeColor = SystemColors.ControlText;
                rankRecordLabel4.ForeColor = SystemColors.ControlText;
                rankRecordLabel5.ForeColor = SystemColors.GrayText;
                rankRecordLabel1.Text = TimeUnit2TimerText(data.rank[0].time);
                rankRecordLabel2.Text = TimeUnit2TimerText(data.rank[1].time);
                rankRecordLabel3.Text = TimeUnit2TimerText(data.rank[2].time);
                rankRecordLabel4.Text = TimeUnit2TimerText(data.rank[3].time);
                rankRecordLabel5.Text = "00:00:00";
            }
            else
            {
                rankNameLabel1.Text = data.rank[0].name;
                rankNameLabel2.Text = data.rank[1].name;
                rankNameLabel3.Text = data.rank[2].name;
                rankNameLabel4.Text = data.rank[3].name;
                rankNameLabel5.Text = data.rank[4].name;
                rankRecordLabel1.ForeColor = SystemColors.ControlText;
                rankRecordLabel2.ForeColor = SystemColors.ControlText;
                rankRecordLabel3.ForeColor = SystemColors.ControlText;
                rankRecordLabel4.ForeColor = SystemColors.ControlText;
                rankRecordLabel5.ForeColor = SystemColors.ControlText;
                rankRecordLabel1.Text = TimeUnit2TimerText(data.rank[0].time);
                rankRecordLabel2.Text = TimeUnit2TimerText(data.rank[1].time);
                rankRecordLabel3.Text = TimeUnit2TimerText(data.rank[2].time);
                rankRecordLabel4.Text = TimeUnit2TimerText(data.rank[3].time);
                rankRecordLabel5.Text = TimeUnit2TimerText(data.rank[4].time);
            }
        }
        public void RankUpdate(List<(String name, TimeUnit time)> rank)
        {
            this.data.rank = rank;
            RankUpdate();
        }
        public void WaitingUpdate()
        {
            waitingListBox.Items.Clear();
            if (data.wait == null) return;
            if(data.wait.Count > 0)
            {
                waitingListBox.Items.Add("1." + data.wait[0] + " - NextPlayer");
                int dataWaitCountMax = data.wait.Count;
                if (dataWaitCountMax > 4)
                    dataWaitCountMax = 4;
                for(int i = 1; i < dataWaitCountMax; i++)
                {
                    waitingListBox.Items.Add((i+1).ToString() + "." + data.wait[i]);
                }
            }
        }
        public void DataUpdate()
        {
            TitleUpdate();
            PlayerUpdate();
            RobotUpdate();
            TimerUpdate();
            RecordUpdate();
            RankUpdate();
            WaitingUpdate();
        }

        public void DataUpdate(TimerBoardData data)
        {
            this.data = data;
            DataUpdate();
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            TimerUpdate();
        }
        ///////////////////////////////////////////////////////////////Resize
        private struct RectFont
        {
            public Rectangle rect;
            public Font font;
            public RectFont(Rectangle rect, Font font)
            {
                this.rect = rect;
                this.font = font;
            }
        }
        private struct ObjectRectangle
        {
            public RectFont Form;              //Form
            public RectFont topTimerLabel;     //topTimerLabel
            public RectFont titlePanel;        //titlePanel       
            public RectFont StarPictureBox;    //StarPictureBox   
            public RectFont mazeLogoPictureBox;//mazeLogoPictureBox
            public RectFont titleLabel;        //titleLabel 
            public RectFont bottomTimerLabel;  //bottomTimerLabel 
            public RectFont recordGroupBox;    //recordGroupBox   
            public RectFont recordListBox;     //recordListBox    
            public RectFont rankGroupBox;      //rankGroupBox    
            public RectFont rankPanel;         //rankPanel       
            public RectFont rankRecordLabel5;  //rankRecordLabel5
            public RectFont rankNameLabel5;    //rankNameLabel5  
            public RectFont rankRecordLabel4;  //rankRecordLabel4
            public RectFont rankNameLabel4;    //rankNameLabel4  
            public RectFont rankRecordLabel3;  //rankRecordLabel3
            public RectFont rankNameLabel3;    //rankNameLabel3  
            public RectFont rankRecordLabel2;  //rankRecordLabel2
            public RectFont rankNameLabel2;    //rankNameLabel2  
            public RectFont rankRecordLabel1;  //rankRecordLabel1
            public RectFont rankNameLabel1;    //rankNameLabel1  
            public RectFont Rank5IconLabel;    //Rank5IconLabel  
            public RectFont Rank4IconLabel;    //Rank4IconLabel  
            public RectFont Rank3IconLabel;    //Rank3IconLabel  
            public RectFont Rank2IconLabel;    //Rank2IconLabel  
            public RectFont Rank1IconLabel;    //Rank1IconLabel  
            public RectFont waitingGroupBox;   //waitingGroupBox 
            public RectFont waitingListBox;    //waitingListBox  
            public RectFont playerGroupBox;    //playerGroupBox  
            public RectFont playerLabel;       //playerLabel     
            public RectFont robotGroupBox;     //robotGroupBox   
            public RectFont robotLabel;        //robotLabel      
        }
        
        ObjectRectangle origRect;
        bool initorigRect = false;
        private void OriginalSizeSet()
        {
            origRect.Form = SetRectangle(this);

            origRect.titlePanel= SetRectangle(titlePanel);
            origRect.topTimerLabel= SetRectangle(topTimerLabel);
            origRect.StarPictureBox= SetRectangle(StarPictureBox);
            origRect.mazeLogoPictureBox = SetRectangle(mazeLogoPictureBox);
            origRect.titleLabel= SetRectangle(titleLabel);
            origRect.bottomTimerLabel= SetRectangle(bottomTimerLabel);
            origRect.recordGroupBox= SetRectangle(recordGroupBox);
            origRect.recordListBox= SetRectangle(recordListBox);
            origRect.rankGroupBox= SetRectangle(rankGroupBox);
            origRect.rankPanel= SetRectangle(rankPanel);
            origRect.rankRecordLabel5= SetRectangle(rankRecordLabel5);
            origRect.rankNameLabel5= SetRectangle(rankNameLabel5);
            origRect.rankRecordLabel4= SetRectangle(rankRecordLabel4);
            origRect.rankNameLabel4= SetRectangle(rankNameLabel4);
            origRect.rankRecordLabel3= SetRectangle(rankRecordLabel3);
            origRect.rankNameLabel3= SetRectangle(rankNameLabel3);
            origRect.rankRecordLabel2= SetRectangle(rankRecordLabel2);
            origRect.rankNameLabel2= SetRectangle(rankNameLabel2);
            origRect.rankRecordLabel1= SetRectangle(rankRecordLabel1);
            origRect.rankNameLabel1= SetRectangle(rankNameLabel1);
            origRect.Rank5IconLabel= SetRectangle(Rank5IconLabel);
            origRect.Rank4IconLabel= SetRectangle(Rank4IconLabel);
            origRect.Rank3IconLabel= SetRectangle(Rank3IconLabel);
            origRect.Rank2IconLabel= SetRectangle(Rank2IconLabel);
            origRect.Rank1IconLabel= SetRectangle(Rank1IconLabel);
            origRect.waitingGroupBox= SetRectangle(waitingGroupBox);
            origRect.waitingListBox= SetRectangle(waitingListBox);
            origRect.playerGroupBox= SetRectangle(playerGroupBox);
            origRect.playerLabel= SetRectangle(playerLabel);
            origRect.robotGroupBox= SetRectangle(robotGroupBox);
            origRect.robotLabel = SetRectangle(robotLabel);

            initorigRect = true;
        }

        private RectFont SetRectangle(Control c)
        {
            return new RectFont(new Rectangle(c.Location.X, c.Location.Y, c.Size.Width, c.Size.Height), c.Font);
        }

        public void ObjectResize()
        {
            ResizeControl(origRect.topTimerLabel, topTimerLabel);
            ResizeControl(origRect.titlePanel, titlePanel);
            ResizeControl(origRect.mazeLogoPictureBox, mazeLogoPictureBox);
            ResizeControl(origRect.StarPictureBox, StarPictureBox);
            ResizeControl(origRect.titleLabel, titleLabel);
            ResizeControl(origRect.bottomTimerLabel, bottomTimerLabel);
            ResizeControl(origRect.recordGroupBox, recordGroupBox);
            ResizeControl(origRect.recordListBox, recordListBox);
            ResizeControl(origRect.rankGroupBox, rankGroupBox);
            ResizeControl(origRect.rankPanel, rankPanel);
            ResizeControl(origRect.rankRecordLabel5, rankRecordLabel5);
            ResizeControl(origRect.rankNameLabel5, rankNameLabel5);
            ResizeControl(origRect.rankRecordLabel4, rankRecordLabel4);
            ResizeControl(origRect.rankNameLabel4, rankNameLabel4);
            ResizeControl(origRect.rankRecordLabel3, rankRecordLabel3);
            ResizeControl(origRect.rankNameLabel3, rankNameLabel3);
            ResizeControl(origRect.rankRecordLabel2, rankRecordLabel2);
            ResizeControl(origRect.rankNameLabel2, rankNameLabel2);
            ResizeControl(origRect.rankRecordLabel1, rankRecordLabel1);
            ResizeControl(origRect.rankNameLabel1, rankNameLabel1);
            ResizeControl(origRect.Rank5IconLabel, Rank5IconLabel);
            ResizeControl(origRect.Rank4IconLabel, Rank4IconLabel);
            ResizeControl(origRect.Rank3IconLabel, Rank3IconLabel);
            ResizeControl(origRect.Rank2IconLabel, Rank2IconLabel);
            ResizeControl(origRect.Rank1IconLabel, Rank1IconLabel);
            ResizeControl(origRect.waitingGroupBox, waitingGroupBox);
            ResizeControl(origRect.waitingListBox, waitingListBox);
            ResizeControl(origRect.playerGroupBox, playerGroupBox);
            ResizeControl(origRect.playerLabel, playerLabel);
            ResizeControl(origRect.robotGroupBox, robotGroupBox);
            ResizeControl(origRect.robotLabel, robotLabel);
        }

        private void ResizeControl(RectFont r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(origRect.Form.rect.Width);
            float yRatio = (float)(this.Height) / (float)(origRect.Form.rect.Height);

            int newX = (int)(r.rect.X * xRatio);
            int newY = (int)(r.rect.Y * yRatio);

            int newWidth = (int)(r.rect.Width * xRatio);
            int newHeight = (int)(r.rect.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
            c.Font = new Font(c.Font.Name, c.Font.Size * yRatio);
        }

        private void Resize_TimerBoardFrom(object sender, EventArgs e)
        {
            if(initorigRect == true)
                ObjectResize();
        }
    }
}
