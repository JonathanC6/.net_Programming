using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SourceFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);

                //1.统计源文件原始行数和单词数
                int originalLineCount = fileContent.Split(new[] { '\n' }, StringSplitOptions.None).Length;
                int originalWordCount = CountWords(fileContent);

                //2.格式化文件，删除空行和注释
                string formattedContent = RemoveCommentsAndEmptyLines(fileContent);

                //3.统计格式化后的行数和单词数
                int formattedLineCount = formattedContent.Split(new[] { '\n' }, StringSplitOptions.None).Length;
                int formattedWordCount = CountWords(formattedContent);

                //4.统计格式化后每个单词的频率
                var wordFrequency = CountWordFrequency(formattedContent);

                //5.显示统计结果
                txtStatistics.Text = $"原始行数: {originalLineCount}\r\n" +
                                     $"原始单词数: {originalWordCount}\r\n" +
                                     $"格式化后行数: {formattedLineCount}\r\n" +
                                     $"格式化后单词数: {formattedWordCount}";

                //显示每个单词的出现次数
                listWordFrequency.Items.Clear();
                foreach (var word in wordFrequency)
                {
                    listWordFrequency.Items.Add($"{word.Key}: {word.Value}");
                }
            }
        }

        //统计单词数
        private int CountWords(string content)
        {
            string[] words = Regex.Split(content, @"\W+");
            return words.Where(w => !string.IsNullOrEmpty(w)).Count();
        }

        //删除空行和注释
        private string RemoveCommentsAndEmptyLines(string content)
        {
            string[] lines = content.Split(new[] { '\n' }, StringSplitOptions.None);

            var filteredLines = lines
                .Where(line => !string.IsNullOrWhiteSpace(line) && !line.Trim().StartsWith("//"))
                .ToArray();

            return string.Join("\n", filteredLines);
        }

        //统计每个单词的频率
        private Dictionary<string, int> CountWordFrequency(string content)
        {
            string[] words = Regex.Split(content, @"\W+");
            var wordFrequency = new Dictionary<string, int>();

            foreach (var word in words.Where(w => !string.IsNullOrEmpty(w)))
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }
    }
}
