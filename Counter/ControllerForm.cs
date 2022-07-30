using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Counter.src;
using System.IO;
using System.IO.Ports;

namespace Counter
{
    public partial class ControllerForm : Form
    {
        private TimerBoardForm timerBoardForm;
        private TimerBoardData timerBoardData;
        private INIManager iniManager = new INIManager();
        private SettingRule settingRule;

        private string createFileEnableTime;

        private int currentPlayerIndex;
        private PlayerINFO currentPlayer = new PlayerINFO();
        private List<PlayerINFO> playerInfo = new List<PlayerINFO>() { new PlayerINFO() };
        private List<PlayerINFO> waitingPlayer = new List<PlayerINFO>() { new PlayerINFO() };
        private List<PlayerINFO> consumedPlayers = new List<PlayerINFO>() { new PlayerINFO() };
        private List<Tuple<string, TimeUnit>> playerRankData = new List<Tuple<string, TimeUnit>>();

        private Dictionary<string, string> contestSettingDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> contestSettingAddDictionary = new Dictionary<string, string>();

        private bool connectCounter = false;
        private int transmitMode = 0;
        private int sensorDataOrder = 0;

        public ControllerForm()
        {
            InitializeComponent();
        }
        private void Controller_Load(object sender, EventArgs e)
        {
            timerBoardData = new TimerBoardData();
            timerBoardData.topTimer = new TImerManager();
            timerBoardData.bottomTimer = new TImerManager();
            timerBoardData.rank = new List<(string name, TimeUnit time)>();
            settingRule = new SettingRule();
            settingRule.TopTimer.StartPoint = new List<string>();
            settingRule.BottomTimer.StartPoint = new List<string>();
            settingRule.TopTimer.EndPoint = new List<string>();
            settingRule.BottomTimer.EndPoint = new List<string>();
            settingRule.TopTimer.ResetPoint = new List<string>();
            settingRule.BottomTimer.ResetPoint = new List<string>();
            settingRule.TopTimer.RecordUpdate = new List<string>();
            settingRule.BottomTimer.RecordUpdate = new List<string>();
            timerBoardForm = new TimerBoardForm(timerBoardData);
            OpenContestFileDialogInit(Application.StartupPath + @"\ContestSetting");
            ContestComboBoxUpdate(Application.StartupPath + @"\ContestSetting");
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            timerBoardForm.Show();
        }
        private void ControllerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Counter를 종료하겠습니까?";
            const string caption = "종료 경고";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
            else
            {
                if(serialPort.IsOpen)
                {
                    serialPort.Write("R");
                    serialPort.Close();
                }
            }
        }
        private void OpenContestFileDialogInit(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false) di.Create();
            contestFileDialog.InitialDirectory = path;
            contestFileDialog.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*";
            contestFileDialog.RestoreDirectory = true;
        }
        private string OpenContestFileDialog()
        {
            if (contestFileDialog.ShowDialog() == DialogResult.OK)
            {
                return contestFileDialog.FileName;
            }
            return null;
        }
        private void InitBoardData()
        {
            timerBoardData.title = settingRule.Name;
            playerInfo = settingRule.Player;
            currentPlayerIndex = 0;
            currentPlayer.Clear();
            waitingPlayer.Clear();
            consumedPlayers.Clear();
            if (settingRule.Player != null)
            {
                if (settingRule.Player.Count > 0)
                {
                    currentPlayer = settingRule.Player[0];
                    currentPlayer.Records = new List<PlayerRecord>();
                    for (int i = 1; i < settingRule.Player.Count; i++)
                    {
                        waitingPlayer.Add(settingRule.Player[i]);
                    }
                    timerBoardData.player = currentPlayer.Player;
                    timerBoardData.robot = currentPlayer.Unit;
                }
                else
                {
                    timerBoardData.player = null;
                    timerBoardData.robot = null;
                }
            }

            timerBoardData.topTimer = new TImerManager(settingRule.TopTimer.InitTime.Millisecond, settingRule.TopTimer.CountUp);
            timerBoardData.bottomTimer = new TImerManager(settingRule.BottomTimer.InitTime.Millisecond, settingRule.BottomTimer.CountUp);

            timerBoardData.wait = new List<string>();
            timerBoardData.record = new List<TimeUnit>();
            foreach (var item in waitingPlayer)
            {
                timerBoardData.wait.Add(item.Player);
            }
            timerBoardForm.DataUpdate(timerBoardData);
        }
        private void BoardPlayerUpdate()
        {
            timerBoardData.wait.Clear();
            foreach (var item in waitingPlayer)
            {
                timerBoardData.wait.Add(item.Player);
            }
            timerBoardData.player = currentPlayer.Player;
            timerBoardData.robot = currentPlayer.Unit;
            timerBoardForm.DataUpdate(timerBoardData);
        }
        private void BoardRecordUpdate()
        {
            timerBoardData.record.Clear();
            if(currentPlayer.Records != null)
            {
                foreach (var item in currentPlayer.Records)
                {
                    timerBoardData.record.Add(item.Record);
                }
            }
            timerBoardForm.RecordUpdate(timerBoardData.record);
        }

        private void ContestComboBoxUpdate(String path)
        {
            string currentContestText = contestComboBox.Text;
            contestComboBox.Items.Clear();
            contestSettingDictionary.Clear();
            foreach (string f in Directory.GetFiles(path, "*.ini"))
            {
                contestComboBox.Items.Add(Path.GetFileName(f));
                contestSettingDictionary.Add(Path.GetFileName(f), f);
            }
            foreach(var item in contestSettingAddDictionary)
            {
                contestComboBox.Items.Add(item.Key);
                contestSettingDictionary.Add(item.Key, item.Value);
            }
            contestComboBox.Items.Add("..Others");
            if (currentContestText == "..Others")
                currentContestText = "";
            else
                contestComboBox.Text = currentContestText;
        }

        private void PlayerListBoxUpdate()
        {
            playerListBox.Items.Clear();
            foreach(var item in playerInfo)
            {
                playerListBox.Items.Add("[" + (item.Number + 1).ToString("D3") + "]" + item.Player + "," + item.Unit);
            }
        }
        private void RecordsListBoxUpdate()
        {
            recordsListBox.Items.Clear();
            if (currentPlayer.Records != null)
            {
                foreach (var item in currentPlayer.Records)
                {
                    recordsListBox.Items.Add(
                        (item.Record.Minute % 60).ToString("D2") + ":" + (item.Record.Second % 60).ToString("D2") + ":" + (item.Record.Millisecond % 1000).ToString("D3") +
                        "[" + item.Success + "]___" + item.Date);
                }
            }
        }
        private void RankUpdate()
        {
            playerRankData.Clear();
            foreach (var item in playerInfo)
            {
                if(item.Records != null)
                {
                    List<PlayerRecord> playerRecords = new List<PlayerRecord>();
                    playerRecords = item.Records.ToList();
                    playerRecords.Sort((s1, s2) => s1.Record.Ticks.CompareTo(s2.Record.Ticks));
                    foreach(var record in playerRecords)
                    {
                        if(record.Success)
                        {
                            playerRankData.Add(new Tuple<string, TimeUnit>(item.Player, record.Record));
                            break;
                        }
                    }
                    playerRankData.Sort((r1, r2) => r1.Item2.Ticks.CompareTo(r2.Item2.Ticks));
                }
            }
        }
        private void RankBoardUpdate()
        {
            timerBoardData.rank.Clear();
            foreach (var item in playerRankData)
            {
                timerBoardData.rank.Add((item.Item1, item.Item2));
            }
            timerBoardForm.RankUpdate(timerBoardData.rank);
            ResultFileUpdate();
        }
        private void ResultFileUpdate()
        {
            string path = Application.StartupPath + @"\Results\" + createFileEnableTime; ;
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false) di.Create();

            ContestResultData contestResult = new ContestResultData();
            contestResult.Name = settingRule.Name;
            contestResult.Time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            contestResult.PlayerRank = playerRankData;
            iniManager.ContestResultWrite(contestResult, path + @"\" + contestResult.Name + "Result.ini");
            path = Application.StartupPath + @"\Results\PlayerResultData\" + createFileEnableTime;
            di = new DirectoryInfo(path);
            if (di.Exists == false) di.Create();

            PlayerResultData playerResultData = new PlayerResultData();
            playerResultData.Name = contestResult.Name;
            playerResultData.Time = contestResult.Time;
            foreach(var item in playerInfo)
            {
                playerResultData.playerINFO = item;
                iniManager.PlayerResultDataWrite(playerResultData, path + @"\" + item.Number.ToString("D3") + "-" +  contestResult.Name + "-" + item.Player + ".ini");
            }
        }
        private bool CurrentPlayerSelect(int currentPlayerIndex)
        {
            int playerNum = playerInfo.Count;
            if (currentPlayerIndex < playerNum)
            {
                this.currentPlayerIndex = currentPlayerIndex;
                consumedPlayers.Clear();
                waitingPlayer.Clear();
                consumedPlayers.Clear();
                currentPlayer = playerInfo[currentPlayerIndex];
                for (int i = 0; i < currentPlayerIndex; i++)
                {
                    consumedPlayers.Add(playerInfo[i]);
                }
                for (int i = currentPlayerIndex + 1; i < playerNum; i++)
                {
                    waitingPlayer.Add(playerInfo[i]);
                }
                return true;
            }
            else
            {
                MessageBox.Show("마지막 선수입니다.");
                return false;
            }
        }
        private void contestApplyButton_Click(object sender, EventArgs e)
        {
            ContestComboBoxUpdate(Application.StartupPath + @"\ContestSetting");
            if (!string.IsNullOrEmpty(contestComboBox.Text) && (contestComboBox.Text != "..Others"))
            {
                string selectedContest = contestComboBox.SelectedItem.ToString();
                if (MessageBox.Show(contestSettingDictionary[selectedContest] + "\n[" + contestComboBox.Text + "] 선택하시겠습니까?", "대회선택경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    settingRule = iniManager.SettingRuleRead(
                    contestSettingDictionary[selectedContest]);
                    InitBoardData();
                    currentPlayerIndexLabel.Text = (currentPlayerIndex + 1).ToString("D3");
                    playerInfo = settingRule.Player;
                    PlayerListBoxUpdate();
                    RecordsListBoxUpdate();
                    BoardRecordUpdate();
                    createFileEnableTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                }
            }
        }
        private void nextPlayerButton_Click(object sender, EventArgs e)
        {
            if(timerBoardData.topTimer.CheckRunning() || timerBoardData.bottomTimer.CheckRunning())
            {
                if (MessageBox.Show("타이머가 동작중입니다. 정말로 다음 순서로 넘어가겠습니까?", "확인 경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CurrentPlayerSelect(++currentPlayerIndex))
                    {
                        timerBoardData.topTimer.Stop();
                        timerBoardData.topTimer.Reset();
                        timerBoardData.bottomTimer.Stop();
                        timerBoardData.bottomTimer.Reset();
                        BoardPlayerUpdate();
                        currentPlayer.Records = new List<PlayerRecord>();
                        BoardRecordUpdate();
                        RecordsListBoxUpdate();
                        RankUpdate();
                        RankBoardUpdate();
                        currentPlayerIndexLabel.Text = (currentPlayerIndex + 1).ToString("D3");
                    }
                }
            }
            else
            {
                if (CurrentPlayerSelect(++currentPlayerIndex))
                {
                    timerBoardData.topTimer.Reset();
                    timerBoardData.bottomTimer.Reset();
                    BoardPlayerUpdate();
                    currentPlayer.Records = new List<PlayerRecord>();
                    BoardRecordUpdate();
                    RecordsListBoxUpdate();
                    RankUpdate();
                    RankBoardUpdate();
                    currentPlayerIndexLabel.Text = (currentPlayerIndex + 1).ToString("D3");
                }
            }
        }
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived));
        }
        private void SerialReceived(object sender, EventArgs e)
        {
            
            String strRecive = serialPort.ReadExisting();
            if(connectCounter == false)
            {
                if (strRecive == "HI PC!")
                {
                    connectButton.Text = "접속됨";
                    connectCounter = true;
                    transmitMode = 1;
                    serialPort.Write("D");
                }
                else
                {
                    connectButton.Text = "접속 실패 ㅠ";
                }
            }
            else if(transmitMode == 1)
            {
                char[] inputc = { '\0', '\0' };
                foreach (var item in strRecive)
                {
                    if (item == 'D') sensorDataOrder = 0;
                    else if (item == 'Y' || item == 'N')
                    {
                        if(sensorDataOrder == 1)
                        {
                            inputc[0] = item;
                        }
                        else if(sensorDataOrder == 2)
                        {
                            inputc[1] = item;
                        }
                    }
                    else if(item == '\0')
                    {
                        sensorDataOrder = 3;
                    }
                    sensorDataOrder++;
                    sensorDataOrder %= 4;
                }

                if (inputc[0] == 'Y')
                {
                    sensor1StateLabel.Text = "입력";
                    sensor1StateLabel.BackColor = Color.Green;
                }
                else if (inputc[0] == 'N')
                {
                    sensor1StateLabel.Text = "비입력";
                    sensor1StateLabel.BackColor = Color.Red;
                }
                if (inputc[1] == 'Y')
                {
                    sensor2StateLabel.Text = "입력";
                    sensor2StateLabel.BackColor = Color.Green;
                }
                else if (inputc[1] == 'N')
                {
                    sensor2StateLabel.Text = "비입력";
                    sensor2StateLabel.BackColor = Color.Red;
                }
            }
            serialTextBox.AppendText(strRecive);
        }
        private void portComboBox_DropDown(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();
            string[] portLists = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(portLists);
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (portComboBox.Text == "")
            {
                connectButton.Text = "접속(Port선택필요)";
            }
            else
            {
                if (connectCounter)
                {
                    if(MessageBox.Show("Serial 접속을 해제하겠습니까?", "접속 경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        serialPort.Close();
                        connectCounter = false;
                        connectButton.Text = "접속 안됨";
                        sensor1StateLabel.Text = "연결 안됨";
                        sensor1StateLabel.BackColor = Color.Gray;
                        sensor2StateLabel.Text = "연결 안됨";
                        sensor2StateLabel.BackColor = Color.Gray;
                    }
                }
                else
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    serialPort.PortName = portComboBox.Text;
                    connectButton.Text = "접속 실패중";
                    serialPort.Open();
                    if(serialPort.IsOpen)
                    {
                        serialPort.Write("Hello Counter!");
                    }
                    else
                    {
                        connectButton.Text = "접속(IsOpen 실패)";
                        serialPort.Close();
                    }
                }
            }
        }
        private void contestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedContest = contestComboBox.SelectedItem.ToString();
            if (selectedContest == "..Others")
            {
                contestComboBox.Text = "";
                string path = OpenContestFileDialog();
                if (path != null)
                {
                    if (contestSettingDictionary.ContainsKey(Path.GetFileName(path)))
                    {
                        MessageBox.Show("동일이름 불가");
                    }
                    else
                    {
                        string fileName = Path.GetFileName(path);
                        contestSettingDictionary.Add(fileName, path);
                        contestSettingAddDictionary.Add(fileName, path);
                        ContestComboBoxUpdate(Application.StartupPath + @"\ContestSetting");
                        contestComboBox.Text = fileName;
                    }
                }
                else
                {
                    MessageBox.Show("Path Error");
                }
            }
        }

        ///////////////////////////////////////////////////DebugButton
        bool debugEnable = false;
        private void debugEnableButton_Click(object sender, EventArgs e)
        {
            if(debugEnable == true)
            {
                debugEnable = false;
                debugEnableButton.Text = "Debug버튼(비활성화)";
                startButton.Enabled = false;
                stopButton.Enabled = false;
                ResetButton.Enabled = false;
                recordButton.Enabled = false;
                tStartButton.Enabled = false;
                bStartButton.Enabled = false;
                tStopButton.Enabled = false;
                bStopButton.Enabled = false;
                tResetButton.Enabled = false;
                bResetButton.Enabled = false;
                tRecordButton.Enabled = false;
                bRecordButton.Enabled = false;
            }
            else if (MessageBox.Show("Debug버튼을 활성화하겠습니까?", "Debug버튼 활성 경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                debugEnable = true;
                debugEnableButton.Text = "Debug버튼(활성화)";
                startButton.Enabled = true;
                stopButton.Enabled = true;
                ResetButton.Enabled = true;
                recordButton.Enabled = true;
                tStartButton.Enabled = true;
                bStartButton.Enabled = true;
                tStopButton.Enabled = true;
                bStopButton.Enabled = true;
                tResetButton.Enabled = true;
                bResetButton.Enabled = true;
                tRecordButton.Enabled = true;
                bRecordButton.Enabled = true;
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (settingRule.TopTimer.StartPoint.Find(x => x == "Start") != null)
            {
                timerBoardData.topTimer.Start();
            }
            if (settingRule.BottomTimer.StartPoint.Find(x => x == "Start") != null)
            {
                timerBoardData.bottomTimer.Start();
            } 
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (settingRule.TopTimer.EndPoint.Find(x => x == "Stop") != null)
            {
                timerBoardData.topTimer.Stop();
            }
            if (settingRule.BottomTimer.EndPoint.Find(x => x == "Stop") != null)
            {
                timerBoardData.bottomTimer.Stop();
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            timerBoardData.topTimer.Reset();
            timerBoardData.bottomTimer.Reset();
        }
        private void recordButton_Click(object sender, EventArgs e)
        {
            if (settingRule.TopTimer.RecordUpdate.Find(x => x == "Record") != null)
            {
                currentPlayer.Records.Add(new PlayerRecord(timerBoardData.topTimer.GetTimeUnit(), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), "TopTimer", true));
                playerInfo[currentPlayerIndex] = currentPlayer;
                RankUpdate();
                RankBoardUpdate();
            }
            if (settingRule.TopTimer.EndPoint.Find(x => x == "Record") != null)
            {
                timerBoardData.topTimer.Stop();
            }
            if (settingRule.TopTimer.ResetPoint.Find(x => x == "Record") != null)
            {
                timerBoardData.topTimer.Reset();
            }
            if (settingRule.BottomTimer.RecordUpdate.Find(x => x == "Record") != null)
            {
                currentPlayer.Records.Add(new PlayerRecord(timerBoardData.bottomTimer.GetTimeUnit(), "BottomTimer", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), true));
                playerInfo[currentPlayerIndex] = currentPlayer;
                RankUpdate();
                RankBoardUpdate();
            }
            if (settingRule.BottomTimer.EndPoint.Find(x => x == "Record") != null)
            {
                timerBoardData.bottomTimer.Stop();
            }
            if (settingRule.BottomTimer.ResetPoint.Find(x => x == "Record") != null)
            {
                timerBoardData.bottomTimer.Reset();
            }
            BoardRecordUpdate();
            RecordsListBoxUpdate();
        }

        private void tStartButton_Click(object sender, EventArgs e)
        {
            timerBoardData.topTimer.Start();
        }

        private void bStartButton_Click(object sender, EventArgs e)
        {
            timerBoardData.bottomTimer.Start();
        }

        private void tStopButton_Click(object sender, EventArgs e)
        {
            timerBoardData.topTimer.Stop();
        }

        private void bStopButton_Click(object sender, EventArgs e)
        {
            timerBoardData.bottomTimer.Stop();
        }

        private void tResetButton_Click(object sender, EventArgs e)
        {
            timerBoardData.topTimer.Reset();
        }

        private void bResetButton_Click(object sender, EventArgs e)
        {
            timerBoardData.bottomTimer.Reset();
        }

        private void tRecordButton_Click(object sender, EventArgs e)
        {
            currentPlayer.Records.Add(new PlayerRecord(timerBoardData.topTimer.GetTimeUnit(), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), "TopTimer", true));
            playerInfo[currentPlayerIndex] = currentPlayer;
            RankUpdate();
            RankBoardUpdate();
        }

        private void bRecordButton_Click(object sender, EventArgs e)
        {
            currentPlayer.Records.Add(new PlayerRecord(timerBoardData.bottomTimer.GetTimeUnit(), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), "BottomTimer", true));
            playerInfo[currentPlayerIndex] = currentPlayer;
            RankUpdate();
            RankBoardUpdate();
        }
    }
}
