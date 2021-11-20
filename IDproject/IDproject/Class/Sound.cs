using System.Media;
namespace ChuongTrinhHocTapChoBe.Class
{
    class Sound
    {
        #region Hàm tạo âm thanh
        //Dùng để tạo âm thanh khi người chơi chọn sai
        public void wrongSound()
        {
            SoundPlayer sp = new SoundPlayer("Chimes.wav");
            sp.Play();
        }
        //Dùng để tạo âm thanh khi người chơi chọn đúng
        public void correctSound()
        {
            SoundPlayer sp = new SoundPlayer("Huýt gọi chó.wav");
            sp.Play();
        }
        public void Off_Sound_1()
        {
            SoundPlayer sp = new SoundPlayer("Huýt gọi chó.wav");
            sp.Stop();
        }
        public void Off_Sound_2()
        {
            SoundPlayer sp = new SoundPlayer("Chimes.wav");
            sp.Stop();
        }
        #endregion  
    }
}
