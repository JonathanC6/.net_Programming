using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp1b
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int correctAnswer;
        private int score = 0;
        private int questionCount = 0;
        private const int totalQuestions = 10;  //总题数
        private const int timeLimit = 10;  //每道题的时间限制（秒）
        private int timeLeft;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;  //计时器每秒触发一次
            timer1.Tick += timer1_Tick;  //绑定事件
            GenerateNewQuestion();
        }
        private void GenerateNewQuestion()
        {
            if (questionCount >= totalQuestions)
            {
                EndQuiz();
                return;
            }

            questionCount++;
            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);
            int operation = random.Next(0, 2);  //0表示加法，1表示减法

            switch (operation)
            {
                case 0:
                    correctAnswer = num1 + num2;
                    questionLabel.Text = $"{num1} + {num2} = ?";
                    break;
                case 1:
                    correctAnswer = num1 - num2;
                    questionLabel.Text = $"{num1} - {num2} = ?";
                    break;
            }

            timeLeft = timeLimit;
            timerLabel.Text = $"剩余时间：{timeLeft} 秒";
            //answerTextBox.BackColor = System.Drawing.Color.White;  //重置背景色
            //resultLabel.Text = "";  //清空反馈信息
            answerTextBox.Text = "";  //清空输入框
            timer1.Start();  //开始计时
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            timer1.Stop();  //停止计时器

            int userAnswer;
            if (int.TryParse(answerTextBox.Text, out userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    score++;
                    resultLabel.Text = "正确!";
                    answerTextBox.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    resultLabel.Text = "错误!";
                    answerTextBox.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                resultLabel.Text = "请输入数字!";
            }

            //生成下一题
            GenerateNewQuestion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timerLabel.Text = $"剩余时间：{timeLeft} 秒";

            if (timeLeft <= 0)
            {
                timer1.Stop();
                resultLabel.Text = "超时!";
                answerTextBox.BackColor = System.Drawing.Color.Orange;
                GenerateNewQuestion();  //超时后直接出下一题
            }
        }

        private void EndQuiz()
        {
            timer1.Stop();
            MessageBox.Show($"测验结束！您的得分是：{score}/{totalQuestions}");
            Application.Exit();
        }


    }
}
