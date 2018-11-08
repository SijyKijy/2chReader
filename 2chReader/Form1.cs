using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DvachReader
{
    public partial class Form1 : Form
    {
        List<Thread> Threads = new List<Thread>();

        int CurrentThread = 0;

        public Form1()
        {
            InitializeComponent();

            SubjectBox.Text = "";
            TextBox.Text = "";
            Thumbnail.BackColor = Color.FromArgb(238, 238, 238);

            BoardList.SelectedItem = BoardList.Items[0];

            RefreshT();
        }

        async Task<string> BoardDownloader(string board)
        {
            using (HttpClient loader = new HttpClient())
            {
                return await loader.GetAsync($"https://2ch.hk/{board}/catalog.json").Result.Content.ReadAsStringAsync();
            }
        }

        async void ThreadHandler(string board)
        {
            string stringey = await BoardDownloader(board);
            dynamic obj = JObject.Parse(stringey);

            foreach (var item in obj.threads)
            {
                Threads.Add(new Thread() { Subject = item.subject, Comment = item.comment, ThumbnailUrl = item.files[0].thumbnail });
            }

            if(Threads.Count > 0)
            {
                Setter();
            }
            else
            {
                MessageBox.Show("Нету тредов!");
            }
        }

        void Setter(int currentThread = 0)
        {
            Thumbnail.ImageLocation = "https://2ch.hk/" + Threads[currentThread].ThumbnailUrl;
            SubjectBox.Text = Threads[currentThread].Subject;
            TextBox.Text = Regex.Replace(Threads[currentThread].Comment, "<[^>]*>","");
            ThreadCount.Text = (CurrentThread + 1) + "/" + Threads.Count;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentThread<(Threads.Count-1))
            {
                CurrentThread++;
            }
            else
            {
                CurrentThread = 0;
            }
            Setter(CurrentThread);
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            if (CurrentThread > 0)
            {
                CurrentThread--;
            }
            else
            {
                CurrentThread = (Threads.Count-1);
            }
            Setter(CurrentThread);
        }

        void RefreshT()
        {
            string board = BoardList.SelectedItem.ToString();

            Match match = Regex.Match(board, "\\/(.*)\\/ -");

            if (match.Success)
            {
                ThreadHandler(match.Groups[1].Value);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            CurrentThread = 0;
           Threads.Clear();
            RefreshT();
        }
    }
}
