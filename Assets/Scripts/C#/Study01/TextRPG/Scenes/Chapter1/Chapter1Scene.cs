using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class Chapter1Scene
    {
        public void Play()
        {
            TextColor.ForeWhite();

            //new Chapter1Scene_SoulStream().Play();
            new Chapter1Scene_TutorialZone().Play();
        }
    }
}
