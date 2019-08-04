﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppSound
{
    /// <summary>
    /// Get to use Audio Files - RECORD & Save
    /// </summary>
    public class Audio
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lp, string lpds, int ur, int hw);
        public static SoundPlayer _player{set;get;}
        public Audio()
        {
            
        }
        public void Record()
        {
            mciSendString("close recsound", "", 0, 0);
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);

        }

        public void CloseRecord(string fileName)
        {
            mciSendString(String.Format(@"save recsound C:\app\testDemo.mp3", fileName), "", 0, 0);
            mciSendString("close recsound", "", 0, 0);
        }
        /// <summary>
        /// Return the current AudioFile Playing
        /// </summary>
        /// <returns></returns>
        public SoundPlayer GetCurrentPlayer()
        {
            return _player;
        }
        /// <summary>
        /// Convert to SOUNDPLAY Stream and play the audioFile
        /// </summary>
        /// <param name="results"></param>
        public void Read(Object results)
        {
            if (results != null && !String.IsNullOrEmpty(results.ToString()))
                using (var s = new MemoryStream((byte[])results))
                {
                    _player = new SoundPlayer(s);
                    _player.Play();
                }
        }



    }
}
