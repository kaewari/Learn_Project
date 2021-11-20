using System.Media;
using System.Windows.Forms;

namespace ChuongTrinhHocTapChoBe.Class
{
    class Music
    {
        private string name;
        SoundPlayer play;
        SoundPlayer off;
        public string Name { get => name; set => name = value; }

        public Music() { }
        public void Off_Music()
        {
            off = new SoundPlayer(Application.StartupPath + Name);
            off.Stop();      
        }
        public void On_Music()
        {
            play = new SoundPlayer(Application.StartupPath + Name);
            play.PlayLooping();
        }
             
    }
}
