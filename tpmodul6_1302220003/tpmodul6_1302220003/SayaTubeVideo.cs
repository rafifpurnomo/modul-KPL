namespace tpmodul6_1302220003
{
    internal class SayaTubeVideo
    {
        int ID;
        string title;
        int playCount;

        public SayaTubeVideo(string title)
        {
            if (title != null && title.Length < 100)
            {
                this.title = title;
            } else
            {
                throw new ArgumentException("TITLE TIDAK BOLEH KOSONG DAN PANJANG KURANG DARI 100 KATA");
            }
            this.ID = generateRandomID();
            this.playCount = 0; 
        }

        private int generateRandomID()
        {
            Random random = new Random();
            return random.Next(00000, 99999);
        }

        public void IncreasePlayCount(int newPlayCount)
        {
            try
            {
                checked
                {
                    if (newPlayCount >= 0 && newPlayCount <= 10000000)
                    {
                        playCount += newPlayCount;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                Console.WriteLine(ArgumentOutOfRangeException.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.ID);
            Console.WriteLine("Video Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

    }
}
