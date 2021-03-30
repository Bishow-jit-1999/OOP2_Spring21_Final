using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_MusicPlayer_Interface
{
    interface IMusicPlayer
    {
        void Switch(bool on);
        void Play(bool on);
        void Setvolume(int loudness);
        void PlayNext();
        void PlayPrevious();

    }
}
