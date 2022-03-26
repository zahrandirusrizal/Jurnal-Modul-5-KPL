using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace modul5_1302204080
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public void increaseplayCount(int tambah)
        {
            Debug.Assert(tambah >= 0 && tambah <= 10000000, "Tidak boleh melebihi 10.000.000");
            int test = this.playCount;

            try
            {
                test = test + tambah;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error saat melakukan penambahan : " + ex.Message);
            }
            this.playCount = this.playCount + tambah;
        }

        public void printVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.playCount);
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public String getJudul()
        {
            return this.title;
        }

        public SayaTubeVideo(string judul_masukan)
        {

            Random random = new Random();

            Debug.Assert(judul_masukan.Length < 101 && judul_masukan != null, "Judulnya tidak boleh melebihi 100 karakter");
            this.title = judul_masukan;


            this.id = random.Next(0, 99999);
            this.playCount = 0;
        }
    }
}
