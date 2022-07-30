using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Counter.src
{
    public struct PlayerRecord
    {
        public TimeUnit Record;
        public string TimerType;
        public string Date;
        public bool Success;
        public PlayerRecord(TimeUnit Record, string TimerType, string Date, bool Success)
        {
            this.Record = Record;
            this.TimerType = TimerType;
            this.Date = Date;
            this.Success = Success;
        }
    }
    public struct PlayerINFO
    {
        public int Number;
        public string Player;
        public string Unit;
        public List<PlayerRecord> Records;
        public PlayerINFO(List<PlayerRecord> records, int number, string player, string unit)
        {
            this.Records = records;
            this.Number = number;
            this.Player = player;
            this.Unit = unit;
        }
        public void Clear()
        {
            Records = new List<PlayerRecord>();
            Records.Clear();
            this.Number = 0;
            this.Player = null;
            this.Unit = null;
        }
    }
    public struct TimerSettingRule
    {
        public bool CountUp;
        public TimeUnit InitTime;
        public List<string> StartPoint;
        public List<string> EndPoint;
        public List<string> ResetPoint;
        public List<string> RecordUpdate;
    }
    public struct SettingRule
    {
        //Title
        public string Name;
        public TimerSettingRule TopTimer;
        public TimerSettingRule BottomTimer;
        public List<PlayerINFO> Player;
    }
    public struct ContestResultData
    {
        public string Name;
        public string Time;
        public List<Tuple<string, TimeUnit>> PlayerRank;
    }
    public struct PlayerResultData
    {
        public string Name;
        public string Time;
        public PlayerINFO playerINFO;
    }
    public class INIManager
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public INIManager()
        {
        }
        
        public SettingRule SettingRuleRead(string path)
        {
            SettingRule result = new SettingRule();
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString("ContestTitle", "Name", null, temp, 255, path);
            result.Name = temp.ToString();

            GetPrivateProfileString("TopTimer", "CountUp", "True", temp, 255, path);
            result.TopTimer.CountUp = Convert.ToBoolean(temp.ToString());
            GetPrivateProfileString("TopTimer", "InitTime", "00:00:000", temp, 255, path);
            result.TopTimer.InitTime = String2TimeUnit(temp.ToString());
            GetPrivateProfileString("TopTimer", "StartPoint", null, temp, 255, path);
            result.TopTimer.StartPoint = String2ListString(temp.ToString());
            GetPrivateProfileString("TopTimer", "EndPoint", null, temp, 255, path);
            result.TopTimer.EndPoint = String2ListString(temp.ToString());
            GetPrivateProfileString("TopTimer", "ResetPoint", null, temp, 255, path);
            result.TopTimer.ResetPoint = String2ListString(temp.ToString());
            GetPrivateProfileString("TopTimer", "RecordUpdate", null, temp, 255, path);
            result.TopTimer.RecordUpdate = String2ListString(temp.ToString());

            GetPrivateProfileString("BottomTimer", "CountUp", "True", temp, 255, path);
            result.BottomTimer.CountUp = Convert.ToBoolean(temp.ToString());
            GetPrivateProfileString("BottomTimer", "InitTime", "00:00:000", temp, 255, path);
            result.BottomTimer.InitTime = String2TimeUnit(temp.ToString());
            GetPrivateProfileString("BottomTimer", "StartPoint", null, temp, 255, path);
            result.BottomTimer.StartPoint = String2ListString(temp.ToString());
            GetPrivateProfileString("BottomTimer", "EndPoint", null, temp, 255, path);
            result.BottomTimer.EndPoint = String2ListString(temp.ToString());
            GetPrivateProfileString("BottomTimer", "ResetPoint", null, temp, 255, path);
            result.BottomTimer.ResetPoint = String2ListString(temp.ToString());
            GetPrivateProfileString("BottomTimer", "RecordUpdate", null, temp, 255, path);
            result.BottomTimer.RecordUpdate = String2ListString(temp.ToString());

            result.Player = new List<PlayerINFO>();
            for (int i = 0; i<1000 ;i++)
            {
                GetPrivateProfileString("Player", "Player" + (i+1).ToString("D3"), null, temp, 255, path);
                if (temp == null) break;
                string[] val = temp.ToString().Split(',');
                if (val.Length != 2) break;
                PlayerINFO playerINFOBuffer = new PlayerINFO();
                playerINFOBuffer.Number = i;
                playerINFOBuffer.Player = val[0];
                playerINFOBuffer.Unit = val[1];
                result.Player.Add(playerINFOBuffer);
            }

            return result;
        }
        public void SettingRuleWrite(SettingRule settingRule, string path)
        {
            WritePrivateProfileString("ContestTitle", null, null, path);
            WritePrivateProfileString("ContestTitle", "Name", settingRule.Name, path);

            WritePrivateProfileString("TopTimer", null, null, path);
            WritePrivateProfileString("TopTimer", "CountUp", settingRule.TopTimer.CountUp.ToString(), path);
            WritePrivateProfileString("TopTimer", "InitTime", TimeUnit2String(settingRule.TopTimer.InitTime), path);
            WritePrivateProfileString("TopTimer", "StartPoint", ListString2String(settingRule.TopTimer.StartPoint), path);
            WritePrivateProfileString("TopTimer", "EndPoint", ListString2String(settingRule.TopTimer.EndPoint), path);
            WritePrivateProfileString("TopTimer", "ResetPoint", ListString2String(settingRule.TopTimer.ResetPoint), path);
            WritePrivateProfileString("TopTimer", "RecordUpdate", ListString2String(settingRule.TopTimer.RecordUpdate), path);

            WritePrivateProfileString("BottomTimer", null, null, path);
            WritePrivateProfileString("BottomTimer", "CountUp", settingRule.BottomTimer.CountUp.ToString(), path);
            WritePrivateProfileString("BottomTimer", "InitTime", TimeUnit2String(settingRule.BottomTimer.InitTime), path);
            WritePrivateProfileString("BottomTimer", "StartPoint", ListString2String(settingRule.BottomTimer.StartPoint), path);
            WritePrivateProfileString("BottomTimer", "EndPoint", ListString2String(settingRule.BottomTimer.EndPoint), path);
            WritePrivateProfileString("BottomTimer", "ResetPoint", ListString2String(settingRule.TopTimer.ResetPoint), path);
            WritePrivateProfileString("BottomTimer", "RecordUpdate", ListString2String(settingRule.BottomTimer.RecordUpdate), path);

            WritePrivateProfileString("Player", null, null, path);
            foreach(PlayerINFO item in settingRule.Player)
            {
                WritePrivateProfileString("Player", "Player" + item.Number.ToString("D3"), item.Player + "," + item.Unit, path);
            }
        }
        public void ContestResultWrite(ContestResultData contestResult, string path)
        {
            WritePrivateProfileString("Contest", null, null, path);
            WritePrivateProfileString("Contest", "Name", contestResult.Name, path);
            WritePrivateProfileString("Contest", "Time", contestResult.Time, path);
            int rank = 1;
            WritePrivateProfileString("Rank", null, null, path);
            foreach (var item in contestResult.PlayerRank)
            {
                WritePrivateProfileString("Rank", rank.ToString("D3"), item.Item1 + "[" + TimeUnit2String(item.Item2) + "]", path);
                rank++;
            }
        }
        public void PlayerResultDataWrite(PlayerResultData contestResult, string path)
        {
            WritePrivateProfileString("Contest", null, null, path);
            WritePrivateProfileString("Contest", "Name", contestResult.Name, path);
            WritePrivateProfileString("Contest", "Time", contestResult.Time, path);
            WritePrivateProfileString("Player", null, null, path);
            WritePrivateProfileString("Player", "ID", 
                "["+ contestResult.playerINFO.Number.ToString("D3") + "]" + contestResult.playerINFO.Player + "-" + contestResult.playerINFO.Unit, path);
            if(contestResult.playerINFO.Records != null)
            {
                foreach (var item in contestResult.playerINFO.Records)
                {
                    WritePrivateProfileString("Player", item.Date, TimeUnit2String(item.Record) + "-" + item.TimerType + "-" + item.Success.ToString(), path);
                }
            }
        }

        private TimeUnit String2TimeUnit(string time)
        {
            TimeUnit result;
            string[] timeStringArray = time.Split(':');
            if (timeStringArray.Length == 3)
            {
                result.Ticks = (Convert.ToInt64(timeStringArray[2]) + Convert.ToInt64(timeStringArray[1]) * 1000 + Convert.ToInt64(timeStringArray[0]) * 1000 * 60) * 10000L;
                result.Millisecond = result.Ticks / 10000L;
                result.Second = result.Millisecond / 1000;
                result.Minute = result.Second / 60;
            }
            else
            {
                result.Ticks = 0;
                result.Millisecond = 0;
                result.Second = 0;
                result.Minute = 0;
            }
            return result;
        }
        private string TimeUnit2String(TimeUnit timeUnit)
        {
            string result = timeUnit.Minute.ToString("D2") + ":" + (timeUnit.Second % 60).ToString("D2") + ":" + (timeUnit.Millisecond % 1000).ToString("D3");
            return result;
        }
        private List<string> String2ListString(string val)
        {
            List<string> result = new List<string>();
            string[] StringArray = val.Split(',');
            foreach (string str in StringArray)
            {
                result.Add(str);
            }
            return result;
        }
        private string ListString2String(List<string> val)
        {
            string result = null;
            if (val.Count > 0)
            {
                foreach (string item in val)
                {
                    if (result == null)
                    {
                        result = item;
                    }
                    else
                        result = result + "," + item;
                }
            }
            else
                return null;
            return result;
        }
    }
}
