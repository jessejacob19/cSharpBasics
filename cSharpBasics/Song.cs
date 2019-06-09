using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; // applys to the class not the instance of the class

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
