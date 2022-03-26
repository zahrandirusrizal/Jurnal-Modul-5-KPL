using System;

namespace modul5_1302204080
{
    class program
    {
        static void Main(string[] args)
        {
            SayaTubeUser aku = new SayaTubeUser("Zahrandi Rusrizal");
            SayaTubeVideo filmA = new SayaTubeVideo("A");
            aku.addVideo(filmA);
            aku.PrintAllVideoPlayCount();
        }
    }
}