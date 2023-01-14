using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class OnlineRadioDatabase
    {
        #region Fields
        string artistName;
        string songName;
        int minutes;
        int seconds;

        static List<OnlineRadioDatabase> songs = new List<OnlineRadioDatabase>();

        static string totalTime;

        static int songsCount;
        static int notAddedSongsCount;
        #endregion

        #region Constructor
        public OnlineRadioDatabase(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        #endregion

        #region Properties
        public string ArtistName
        {
            get { return artistName; }
            set 
            { 
                if(value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
                artistName = value; 
            }
        }
        public string SongName
        {
            get { return songName; }
            set 
            {
                if(value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }
                songName = value; 
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set 
            { 
                if(value < 0 || value > 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }
                minutes = value; 
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set 
            {
                if(value < 0 || value > 59)
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }
                seconds = value; 
            }
        }

        public string TotalTime
        {
            get { return totalTime; }
        }
        #endregion

        #region Methods
        private static void Add()
        {
            Console.Write("How many songs you want to add: ");
            songsCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string artistName;
            string songName;
            int minutes;
            int seconds;

            int totalMinutes = 0;
            int totalSeconds = 0;
            int totalHours = 0;

            for (int i = 0; i < songsCount; i++)
            {
                try
                {
                    Console.Write("Artist name: ");
                    artistName = Console.ReadLine();

                    Console.Write("Song name: ");
                    songName = Console.ReadLine();

                    Console.Write("Song length ine minutes: ");
                    minutes = int.Parse(Console.ReadLine());

                    Console.Write("Song length in seconds: ");
                    seconds = int.Parse(Console.ReadLine());

                    OnlineRadioDatabase song = new OnlineRadioDatabase(artistName, songName, minutes, seconds);
                    songs.Add(song);

                    totalMinutes += minutes;
                    totalSeconds += seconds;

                    Console.WriteLine();
                    Console.WriteLine("Song added.");
                    Console.WriteLine();
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine();
                    Console.Write("Error: ");
                    Console.WriteLine(ae.Message);
                    Console.WriteLine();
                    notAddedSongsCount++;
                }
            }

            if (totalMinutes > 60 && totalSeconds > 60)
            {
                totalHours = totalMinutes / 60;
                totalMinutes = (totalMinutes % 60) + (totalSeconds / 60);
                totalSeconds %= 60;

                totalTime = totalHours.ToString() + ":" + totalMinutes.ToString() + ":" + totalSeconds.ToString();
            }
            else if(totalMinutes > 60)
            {
                totalHours = totalMinutes / 60;
                totalMinutes = totalMinutes % 60;

                totalTime = totalHours.ToString() + ":" + totalMinutes.ToString() + ":" + totalSeconds.ToString();
            }
            else if(totalSeconds > 60)
            {
                totalMinutes = totalSeconds / 60;
                totalSeconds %= 60;

                totalTime = totalHours.ToString() + ":" + totalMinutes.ToString() + ":" + totalSeconds.ToString();
            }
            else
            {
                totalHours = 0;

                totalTime = totalHours.ToString() + ":" + totalMinutes.ToString() + ":" + totalSeconds.ToString();
            }
        }

        public static void AddSongs()
        {
            Add();

            Console.WriteLine();
            Console.WriteLine("Added songs: " + (songsCount - notAddedSongsCount));
            Console.WriteLine("Total playlist time: " + totalTime);
        }
        #endregion
    }
}
