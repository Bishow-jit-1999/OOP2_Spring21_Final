using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_MusicPlayer_Interface
{
    class Ipod:IMusicPlayer
    {
        public MusicFile[] musicfiles;
        public int MusicCount { get; set; }

        public Ipod()
        {
            musicfiles = new MusicFile[500];
        }

        public void Addmusicfile(params MusicFile[] musicFiles)
        {
            foreach (var M in musicFiles)
            {
                this.musicfiles[MusicCount++] = M;
            }
        }

        public void ShowList()
        {
            for (int i = 0; i < MusicCount; i++)
            {
                musicfiles[i].Show();
            }
        }

        public void Switch(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Music Player is on");
            }
            else
            {
                Console.WriteLine("Music Player is Off");
            }
        }

        public void Play(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Music is playing");
            }
            else
            {
                Console.WriteLine("Music is stopped");
            }

        }

        public void Setvolume(int loudness)
        {
            if (loudness >= 7 && loudness<=10)
            {
                Console.WriteLine("Warmning!!!!!Loud sound can damage your ears");
            }
            else if(loudness>=1 && loudness < 7)
            {
                Console.WriteLine("Normal sound");

            }
            else if(loudness==0)
            {
                Console.WriteLine("Muted");
            }
            else
            {

                Console.WriteLine("Volume range is 0 to 10");
            }
        }

        public void PlayNext()
        {
            Console.WriteLine("Playing next music of the list");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Playing previous  music of the list");
        }
    }
}
