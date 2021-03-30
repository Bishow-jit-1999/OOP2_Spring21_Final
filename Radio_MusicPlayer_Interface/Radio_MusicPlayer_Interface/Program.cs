using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_MusicPlayer_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipod i = new Ipod();
            Phone p = new Phone();
            MusicFile M1 = new MusicFile("Behula", "Shunno", 2021, 300);
            MusicFile M2 = new MusicFile("In the End", "Linking Parking", 2002, 240);
            MusicFile M3 = new MusicFile("Utshorgo", "Tasnif", 2012, 360);

            M2.ChangeTitle("Castle of glass");

            Console.WriteLine("IPOD");
            i.Addmusicfile(M1, M2);
            i.ShowList();
            i.Switch(true);
            i.Play(true);
            i.Setvolume(6);
            i.PlayNext();
            i.PlayPrevious();
            Console.WriteLine("############################################");



            Console.WriteLine("PHONE");
            p.Addmusicfile(M3,M1);
            p.ShowList();
            p.Switch(false);
            p.Play(false);
            p.RadioSwitch(true);
            p.RadioRetune(88.0);
            p.RadioSetvolume(7);
            p.RadioChangeChannel();



        }
    }
}
