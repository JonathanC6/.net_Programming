using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clock
{
    internal class AlarmClock
    {
        //定义 Tick 和 Alarm 事件
        public event EventHandler Tick;
        public event EventHandler Alarm;

        private Timer timer;
        private DateTime alarmTime;

        public AlarmClock(DateTime alarmTime)
        {
            this.alarmTime = alarmTime;
            timer = new Timer(1000); //每秒触发一次
            timer.Elapsed += OnTick;
            timer.Start();
        }

        private void OnTick(object sender, ElapsedEventArgs e)
        {
            //每秒触发 Tick 事件
            Tick?.Invoke(this, EventArgs.Empty);

            //当前时间大于或等于设定的闹钟时间时，触发 Alarm 事件
            if (DateTime.Now >= alarmTime)
            {
                Alarm?.Invoke(this, EventArgs.Empty);
                timer.Stop(); //停止定时器
            }
        }
    }
}
