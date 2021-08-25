using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Interview_C_Sharp.ExampleClasses
{

    public class MediaPlayer
    {
        public MediaPlayer()
        {

        }

        public void PlayCD(CD cd)
        {
            foreach(var track in cd.Tracks)
            {
                cd.PlayContent(track);
            }            
        }

        public void PlayDVD(CD cd)
        {
            foreach (var track in cd.Tracks)
            {
                cd.PlayContent(track);
            }
        }

        public void PlayDigitalContent(CD cd)
        {
            foreach (var track in cd.Tracks)
            {
                cd.PlayContent(track);
            }
        }
    }

    public class CD
    {
        public byte[] Track
        {
            get
            {
                return new byte[100];
            }
            set
            {
                this.Track = value;
            }
        }

        public byte[] HiddenTrack { get; set; }

        public List<byte[]> Tracks { get; set; }

        public void PlayContent(byte[] track)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(track, 0, track.Length);
            }
        }
    }

    public class DVD
    {
        public byte[] Track
        {
            get
            {
                return new byte[100];
            }
            set
            {
                this.Track = value;
            }
        }

        public byte[] SpecialContent { get; set; }

        public byte[] Menu { get; set; }

        public List<byte[]> Tracks { get; set; }

        public void PlayContent(byte[] track)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(track, 0, track.Length);
            }
        }
    }

    public class DigitalPlaylist
    {
        public byte[] Track
        {
            get
            {
                return new byte[100];
            }
            set
            {
                this.Track = value;
            }
        }

        public List<byte[]> Tracks { get; set; }

        public void PlayContent(byte[] track)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(track, 0, track.Length);
            }
        }
    }
}
