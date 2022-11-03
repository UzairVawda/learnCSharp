using System;
namespace Classes
{
    public class Song
    {
        public string title;
        public string artist;
        private int duration;
        public static int songCount = 0;


        public Song(string songTitle, string songArtist, int songDuration)
        {
            Title = songTitle;
            Artist = songArtist;
            duration = songDuration;
            songCount++;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

    }

}

