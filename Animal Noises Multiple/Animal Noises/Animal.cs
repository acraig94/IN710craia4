using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String soundFileName;
        private String control;

        public Animal(String soundFileName, String control)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.control = control;
        }

        public void speak()
        {
            
            while (true)
            {
                lock (control)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }
            }
        }

    }
}
