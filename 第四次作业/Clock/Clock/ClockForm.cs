using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();

            //设置闹钟时间为当前时间后 5 秒
            DateTime alarmTime = DateTime.Now.AddSeconds(5);

            AlarmClock alarmClock = new AlarmClock(alarmTime);

            //订阅 Tick 和 Alarm 事件
            alarmClock.Tick += AlarmClock_Tick;
            alarmClock.Alarm += AlarmClock_Alarm;
        }

        private void AlarmClock_Tick(object sender, EventArgs e)
        {
            // Invoke 方法确保在主线程上更新 UI
            if (txtDisplay.InvokeRequired)
            {
                txtDisplay.Invoke(new Action(() =>
                {
                    txtDisplay.AppendText("Tick: " + DateTime.Now.ToString() + Environment.NewLine);
                }));
            }
            else
            {
                txtDisplay.AppendText("Tick: " + DateTime.Now.ToString() + Environment.NewLine);
            }
        }

        private void AlarmClock_Alarm(object sender, EventArgs e)
        {
            // Invoke 方法确保在主线程上更新 UI
            if (txtDisplay.InvokeRequired)
            {
                txtDisplay.Invoke(new Action(() =>
                {
                    txtDisplay.AppendText("Alarm: " + DateTime.Now.ToString() + Environment.NewLine);
                }));
            }
            else
            {
                txtDisplay.AppendText("Alarm: " + DateTime.Now.ToString() + Environment.NewLine);
            }
        }

    }
}
