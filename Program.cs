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
            SayaTubeVideo filmE = new SayaTubeVideo("E");
            SayaTubeVideo filmF = new SayaTubeVideo("F");
            SayaTubeVideo filmG = new SayaTubeVideo("G");
            SayaTubeVideo filmH = new SayaTubeVideo("H");
            aku.addVideo(filmA);
            aku.addVideo(filmB);
            aku.addVideo(filmC);
            aku.addVideo(filmD);
            aku.addVideo(filmE);
            aku.addVideo(filmF);
            aku.addVideo(filmG);
            aku.addVideo(filmH);

            aku.PrintAllVideoPlayCount();
        }
    }
}