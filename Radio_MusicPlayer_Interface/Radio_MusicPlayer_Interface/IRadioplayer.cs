using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_MusicPlayer_Interface
{
    interface IRadioplayer
    {
        void RadioSwitch(bool on);
        void RadioRetune(double freq);
        void RadioSetvolume(int loudness);
        void RadioChangeChannel();
    }
}
