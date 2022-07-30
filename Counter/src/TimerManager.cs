using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.src
{
    public struct TimeUnit
    {
        public long Ticks;
        public long Millisecond;
        public long Second;
        public long Minute;
        public TimeUnit(long tick, long millisecond, long second, long minute)
        {
            this.Ticks = tick;
            this.Millisecond = millisecond;
            this.Second = second;
            this.Minute = minute;
        }
        public TimeUnit(long millisecond)
        {
            this.Millisecond = millisecond;
            this.Ticks = millisecond * 10000L;
            this.Second = millisecond / 1000;
            this.Minute = millisecond / (60 * 1000);
        }
    }
    public class TImerManager
    {
        const long tick2Milli = 10000L;
        private long initTime = 0;  // millisecond
        private long timeBuffTick = 0;  // 100 nanosecond
        private bool runing = false;
        private bool updateTrigger = false;
        private bool upCount = true;

        private TimeUnit currentTime;
        private long dataErrorTimeTicks;

        public TImerManager()
        {
            initTime = 0;
            timeBuffTick = 0;
            upCount = true;
            Reset();
        }
        public TImerManager(long initTime, bool upCount)
        {
            this.initTime = initTime;
            timeBuffTick = initTime;
            this.upCount = upCount;
            Reset();
        }
        public void Start() //실행
        {
            if(runing == false)
            {
                UpdateDataErrorTime();
                runing = true;
            }
        }
        public void Update()    //갱신
        {
            if(runing == true)
            {
                if(upCount == true)
                {
                    long tm = DateTime.UtcNow.Ticks + timeBuffTick - dataErrorTimeTicks;
                    if (tm < 0)
                    {
                        UpdateTimeUnit(out currentTime, 0);
                        UpdateDataErrorTime();
                    }
                    else
                        UpdateTimeUnit(out currentTime, tm);
                }
                else
                {
                    long tm = dataErrorTimeTicks - DateTime.UtcNow.Ticks + timeBuffTick;
                    if (tm <= 0)
                    {
                        UpdateTimeUnit(out currentTime, 0);
                        Stop();
                    }
                    else
                        UpdateTimeUnit(out currentTime, tm);
                }
            }
        }
        public void Stop()  //정지
        {
            timeBuffTick = currentTime.Ticks;
            runing = false;
        }
        public bool CheckRunning()
        {
            return runing;
        }
        public void Reset() //리셋
        {
            SetTime(initTime);
        }
        public void SetInitTime(long initTime)  //초기 시간 설정 millisecond
        {
            this.initTime = initTime;
        }
        public void SetTime(long _mili) //시간 설정 millisecond
        {
            UpdateDataErrorTime();
            timeBuffTick = _mili * 10000L;
            UpdateTimeUnit(out currentTime, _mili * tick2Milli);
            updateTrigger = true;
        }
        public void AddTime(long _mili) //시간 설정 millisecond
        {
            if(upCount == true)
            {
                dataErrorTimeTicks -= _mili * tick2Milli;
            }
            else
            {
                dataErrorTimeTicks += _mili * tick2Milli;
            }
        }
        public TimeUnit GetTimeUnit()   //Get TimeUnit
        {
            return currentTime;
        }
        public long GetTicks()  //Get 100 nanosecond
        {
            return currentTime.Ticks;
        }
        public int GetMillisecond()  //Get millisecond
        {
            return (int)(currentTime.Millisecond);
        }
        public int GetTenMillisecond()  //Get 10 millisecond
        {
            return (int)(currentTime.Millisecond / 10);
        }
        public int GetSecond()  //Get second
        {
            return (int)(currentTime.Second);
        }
        public int GetMinute()  //Get minute
        {
            return (int)(currentTime.Minute);
        }
        public bool UpdateState()   //업데이트 필요성
        {
            bool state = runing | updateTrigger;
            updateTrigger = false;
            return state;
        }
        private void UpdateDataErrorTime()
        {
            dataErrorTimeTicks = DateTime.UtcNow.Ticks;
        }
        private void UpdateTimeUnit(out TimeUnit timeUnit, long ticks)
        {
            timeUnit.Ticks = ticks;
            timeUnit.Millisecond = timeUnit.Ticks / 10000L;
            timeUnit.Second = timeUnit.Millisecond / 1000L;
            timeUnit.Minute = timeUnit.Second / 60L;
        }
    }
}
