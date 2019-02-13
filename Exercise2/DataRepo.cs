using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public static class DataRepo
    {
        public static Band[] GetBands()
        {
            ////Create bands
            //Rock
            RockBand r1 = new RockBand() { Name = "The Foo Fighters", BandImage = "/images/foo.jpg", Formed = 1994, Members = "Dave Grohl, Nate Mendel, Pat Smear, Taylor Hawkins, Chris Shifflett, Rami Jafee" };
            RockBand r2 = new RockBand() { Name = "The Rolling Stones", BandImage = "/images/rollingstones.jpg", Formed = 1962, Members = "Mick Jagger, Ian Stewart, Dick Taylor, Bill Wyman, Mick Taylor" };

            //Pop
            PopBand p1 = new PopBand() { Name = "The Beatles", BandImage = "/images/beatles.jpg", Formed = 1960, Members = "John Lennon, Paul McCartney, George Harrison, Ringo Starr" };
            PopBand p2 = new PopBand() { Name = "Green Day", BandImage = "/images/greenday.jpg", Formed = 1986, Members = "Billie Joe Armstrong, Mike Dirnt, Tre Cool" };

            //Indie
            IndieBand i1 = new IndieBand() { Name = "Arctic Monkeys", BandImage = "/images/artic monkeys.jpg", Formed = 2002, Members = "Alex Turner, Matt Heldens, Jamie Cook, Nick O'Malley" };
            IndieBand i2 = new IndieBand() { Name = "The Strokes", BandImage = "/images/strokes.jpg", Formed = 1998, Members = "Julian Casablancas, Nick Valensi, Albert Hammond Jr, Nikolai Fraiture, Fabrizio Moretti" };

            #region albums

            ////Create and assign albums to appropriate artists
            //Random Declaration
            Random random = new Random();

            //Foo fighters albums
            Album a1 = new Album() { Name = "Greatest Hits", Released = GetRandomDate(r1, random), Sales = random.Next(1000000, 10000000) };
            Album a2 = new Album() { Name = "One by One", Released = GetRandomDate(r1, random), Sales = random.Next(1000000, 10000000) };
            r1.Albums[0] = a1;
            r1.Albums[1] = a2;

            //Rolling stones albums
            Album a3 = new Album() { Name = "Beggars Banquet", Released = GetRandomDate(r2, random), Sales = random.Next(1000000, 10000000) };
            Album a4 = new Album() { Name = "Blue & Lonesome", Released = GetRandomDate(r2, random), Sales = random.Next(1000000, 10000000) };
            r2.Albums[0] = a3;
            r2.Albums[1] = a4;

            //The Beatles albums
            Album a5 = new Album() { Name = "Let It Be", Released = GetRandomDate(p1, random), Sales = random.Next(1000000, 10000000) };
            Album a6 = new Album() { Name = "Sgt. Pepper's Lonely Heart Club Band", Released = GetRandomDate(p1, random), Sales = random.Next(1000000, 10000000) };
            p1.Albums[0] = a5;
            p1.Albums[1] = a6;

            //Green Day albums
            Album a7 = new Album() { Name = "Dookie", Released = GetRandomDate(p2, random), Sales = random.Next(1000000, 10000000) };
            Album a8 = new Album() { Name = "American Idiot", Released = GetRandomDate(p2, random), Sales = random.Next(1000000, 10000000) };
            p2.Albums[0] = a7;
            p2.Albums[1] = a8;

            //Arctic Monkeys albums
            Album a9 = new Album() { Name = "Whatever People Say I am, That's what I'm not", Released = GetRandomDate(i1, random), Sales = random.Next(1000000, 10000000) };
            Album a10 = new Album() { Name = "Favourite Worst Nightmare", Released = GetRandomDate(i1, random), Sales = random.Next(1000000, 10000000) };
            i1.Albums[0] = a9;
            i1.Albums[1] = a10;

            //The Strokes albums
            Album a11 = new Album() { Name = "Room on Fire", Released = GetRandomDate(i2, random), Sales = random.Next(1000000, 10000000) };
            Album a12 = new Album() { Name = "The Modern Age", Released = GetRandomDate(i2, random), Sales = random.Next(1000000, 10000000) };
            i2.Albums[0] = a11;
            i2.Albums[1] = a12;

            #endregion albums

            Band[] bandsCreated = { r1, r2, p1, p2, i1, i2 };
            return bandsCreated;
        }

        //Generate random date within range
        private static DateTime GetRandomDate(Band band, Random randomFactory)
        {

            //Calculates a time range given two integers
            DateTime startDate = new DateTime(band.Formed, 01, 01);
            DateTime endDate = new DateTime(2018, 09, 01);
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, randomFactory.Next(0, (int)timeSpan.TotalMinutes), 0);
            DateTime newDate = startDate + newSpan;

            return newDate;

        }
    }
}
