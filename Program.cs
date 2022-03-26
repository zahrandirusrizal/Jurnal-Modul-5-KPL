using System;

namespace modul5_1302204080
{
    class program
    {
        static void Main(string[] args)
        {
            SayaTubeUser aku = new SayaTubeUser("Zahrandi Rusrizal");
            SayaTubeVideo filmA = new SayaTubeVideo("A");
            SayaTubeVideo filmB = new SayaTubeVideo("B");
            SayaTubeVideo filmC = new SayaTubeVideo("C");
            SayaTubeVideo filmD = new SayaTubeVideo("D");
            aku.addVideo(filmA);
            aku.addVideo(filmB);
            aku.addVideo(filmC);
            aku.addVideo(filmD);
            aku.PrintAllVideoPlayCount();
            SayaTubeVideo filmException = new SayaTubeVideo("AE");
            filmException.increaseplayCount(250000);
            aku.addVideo(null);

        }
    }
}