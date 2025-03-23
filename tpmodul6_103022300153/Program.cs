﻿namespace tpmodul6_103022300153
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 999999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }

    class Program
    {
        static void Main()
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Dina Salsabillla]");
            video.IncreasePlayCount(10);
            video.PrintVideoDetails();
        }
    }
}
