using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace modul5_1302204080
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos ;
        public String username;


        public int GetTotalVideoPlayCount()
        {
            int hasil = 0;
            foreach (var video in uploadedVideos)
            {
                hasil = hasil + video.getPlayCount();
            }
            return hasil;
        }

        public void addVideo(SayaTubeVideo masukan)
        {
            Debug.Assert(masukan != null && masukan.getPlayCount() <=int.MaxValue , "Video yang dimasukkan tidak boleh null" +
                "dan playcountnya tidak bileh melebihi maxInt");
            this.uploadedVideos.Add(masukan);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User : " + this.username);
            int i = 0;
            foreach (var video in this.uploadedVideos)
            {
                i++;
                Console.WriteLine("Judul Video " + i + ": " +video.getJudul());
            }
        }

        public SayaTubeUser(String user_name)
        {
            Random random = new Random();

            Debug.Assert(user_name != null && user_name.Length <= 100, "Username tidak boleh kosong " +
                "maupun melebihi " +
                "100 karakter");
            this.username = user_name;

            this.id = random.Next();

            uploadedVideos = new List<SayaTubeVideo>();

        }


    }
}
