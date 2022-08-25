﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MusicStore.Models;

namespace MusicStore.EntityContext
{
    public class SampleData : DropCreateDatabaseIfModelChanges<MusicStoreEntities>
    {
        protected override void Seed(MusicStoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Rock" },
                new Genre { Name = "Jazz" },
                new Genre { Name = "Metal" },
                new Genre { Name = "Alternative" },
                new Genre { Name = "Disco" },
                new Genre { Name = "Blues" },
                new Genre { Name = "Latin" },
                new Genre { Name = "Reggae" },
                new Genre { Name = "Pop" },
                new Genre { Name = "Classical" }
            };

            var artists = new List<Artist>
            {
                new Artist { Name = "Aphrodité pizza" },
                new Artist { Name = "Bellagio pizza" },
                new Artist { Name = "Bivalymozzarellás pizza érlelt sonkával" },
                new Artist { Name = "Bolognai pizza" },
                new Artist { Name = "Bugaci májas pizza" },
                new Artist { Name = "Chicken carbonara pizza" },
                new Artist { Name = "Csirkés BBQ pizza" },
                new Artist { Name = "Csirkés taco pizza" },
                new Artist { Name = "Duplán jó! Két kolbászos-két sajtos pizza" },
                new Artist { Name = "Fokhagymás, tejfölös csirkés pizza" },
                new Artist { Name = "Fokhagymás, tejfölös pizza" },
                new Artist { Name = "Hawaii pizza" },
                new Artist { Name = "Hús hússal pizza" },
                new Artist { Name = "Jalapeno papa pizza" },
                new Artist { Name = "Juhtúrós-csirkés pizza" },
                new Artist { Name = "Keménylegény pizza" },
                new Artist { Name = "Magyaros pizza" },
                new Artist { Name = "Mérges vagyok! pizza" },
                new Artist { Name = "Mexikói pizza" },
                new Artist { Name = "Mint a moziban pizza" },
                new Artist { Name = "Négysajtos, rukkolás pizza" },
                new Artist { Name = "Parmezán sajtban sült pizza" },
                new Artist { Name = "Pepe margaritája pizza" },
                new Artist { Name = "Pepperoni pizza" },
                new Artist { Name = "Pizza a la gyros" },
                new Artist { Name = "Rangers pizza" },
                new Artist { Name = "SonGoKu pizza" },
                new Artist { Name = "Sonkás pizza" },
                new Artist { Name = "Sonkás, gombás pizza" },
                new Artist { Name = "Tonhalas pizza" },
                new Artist { Name = "Capricciosa pizza normál tésztával" },
                new Artist { Name = "Sajtimádó pizza" }
            };

            new List<Album>
            {
                new Album { Title = "tejföl, roston csirkehús, feta sajt, mozzarella, koktélparadicsom, olívabogyó, bazsalikom", Genre = genres.Single(g => g.Name == "Rock"), Price = 2190M, Artist = artists.Single(a => a.Name == "Aphrodité pizza"), AlbumArtUrl = "/Content/Images/PizzaURL3.jpg" },
                new Album { Title = "pizzaszósz, mozzarella, erős pepperóni paprika, tojás, paradicsom, roston csirke, rukkola, mediterrán sonka, mascarpone", Genre = genres.Single(g => g.Name == "Classical"), Price = 2990M, Artist = artists.Single(a => a.Name == "Bellagio pizza"), AlbumArtUrl = "/Content/Images/PizzaURL1.jpg" },
                new Album { Title = "pizzaparadicsom, bivalymozzarella sajt, mediterrán sonka, olívabogyó, paradicsom, bazsalikomlevél", Genre = genres.Single(g => g.Name == "Jazz"), Price = 2990M, Artist = artists.Single(a => a.Name == "Bivalymozzarellás pizza érlelt sonkával"), AlbumArtUrl = "/Content/Images/PizzaURL1.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, zöldséges, darált húsos ragu", Genre = genres.Single(g => g.Name == "Rock"), Price = 2990M, Artist = artists.Single(a => a.Name == "Bolognai pizza"), AlbumArtUrl = "/Content/Images/PizzaURL4.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, csirkemájas ragu, hegyes erős paprika, csípős", Genre = genres.Single(g => g.Name == "Rock"), Price = 1890M, Artist = artists.Single(a => a.Name == "Bugaci májas pizza"), AlbumArtUrl = "/Content/Images/PizzaURL4.jpg" },
                new Album { Title = "fokhagymás besamel, sonka, bacon, roston csirke, parmezán, mozzarella, lila hagyma, újhagyma", Genre = genres.Single(g => g.Name == "Rock"), Price = 2790M, Artist = artists.Single(a => a.Name == "Chicken carbonara pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "barbecue szósz, roston csirkehús, bacon, kaliforniai paprika, füstölt mozzarella", Genre = genres.Single(g => g.Name == "Rock"), Price = 2390M, Artist = artists.Single(a => a.Name == "Csirkés BBQ pizza"), AlbumArtUrl = "/Content/Images/PizzaURL2.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, roston csirkehús, vöröshagyma, tejföl, paradicsomkarika, tacofűszer, csípős", Genre = genres.Single(g => g.Name == "Classical"), Price = 2090M, Artist = artists.Single(a => a.Name == "Csirkés taco pizza"), AlbumArtUrl = "/Content/Images/PizzaURL4.jpg" },
                new Album { Title = "pizzaparadicsom, füstölt mozzarella, natúr mozzarella, chorizó, kolbász, csípős", Genre = genres.Single(g => g.Name == "Rock"), Price = 2290M, Artist = artists.Single(a => a.Name == "Duplán jó! Két kolbászos-két sajtos pizza"), AlbumArtUrl = "/Content/Images/PizzaURL7.jpg" },
                new Album { Title = "fokhagyma, tejföl, mozzarella, roston csirkehús", Genre = genres.Single(g => g.Name == "Jazz"), Price = 2090M, Artist = artists.Single(a => a.Name == "Fokhagymás, tejfölös csirkés pizza"), AlbumArtUrl = "/Content/Images/PizzaURL7.jpg" },
                new Album { Title = "fokhagyma, tejföl, mozzarella, paprikás vastagkolbász, sonka, hagyma, paradicsomkarika", Genre = genres.Single(g => g.Name == "Rock"), Price = 2090M, Artist = artists.Single(a => a.Name == "Fokhagymás, tejfölös pizza"), AlbumArtUrl = "/Content/Images/PizzaURL7.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, kukorica, sonka, ananász", Genre = genres.Single(g => g.Name == "Rock"), Price = 2190M, Artist = artists.Single(a => a.Name == "Hawaii pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, tarja, paprikás vastagkolbász, roston csirkehús, bacon, mediterrán sonka", Genre = genres.Single(g => g.Name == "Pop"), Price = 2390M, Artist = artists.Single(a => a.Name == "Hús hússal pizza"), AlbumArtUrl = "/Content/Images/PizzaURL4.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, roston csirkehús, bacon, jalapeno, csípős", Genre = genres.Single(g => g.Name == "Disco"), Price = 2190M, Artist = artists.Single(a => a.Name == "Jalapeno papa pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "pizzaparadicsom, roston csirkehús, vöröshagyma, paradicsom, kaliforniai paprika, juhtúró, mozzarella", Genre = genres.Single(g => g.Name == "Latin"), Price = 2190M, Artist = artists.Single(a => a.Name == "Juhtúrós-csirkés pizza"), AlbumArtUrl = "/Content/Images/PizzaURL3.jpg" },
                new Album { Title = "tejföl, mustár, fokhagyma, mozzarella, főtt-füstölt tarja, főtt-füstölt császárszalonna, hegyes erős paprika, csípős", Genre = genres.Single(g => g.Name == "Jazz"), Price = 2090M, Artist = artists.Single(a => a.Name == "Keménylegény pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, gomba, szalámi, hagyma, hegyes erős paprika, csípős", Genre = genres.Single(g => g.Name == "Metal"), Price = 2090M, Artist = artists.Single(a => a.Name == "Magyaros pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "fokhagymás besamel, bacon, főtt-füstölt tarja, paprikás vastagkolbász, jalapeno, hegyes erős paprika, mozzarella", Genre = genres.Single(g => g.Name == "Alternative"), Price = 2690M, Artist = artists.Single(a => a.Name == "Mérges vagyok! pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, kukorica, császárszalonna, bab, chili, csípős", Genre = genres.Single(g => g.Name == "Rock"), Price = 2090M, Artist = artists.Single(a => a.Name == "Mexikói pizza"), AlbumArtUrl = "/Content/Images/PizzaURL6.jpg" },
                new Album { Title = "darált marhahús, tarja, cheddar sajtkrém, mozzarella, nachos, jalapeno, lila hagyma", Genre = genres.Single(g => g.Name == "Classical"), Price = 2790M, Artist = artists.Single(a => a.Name == "Mint a moziban pizza"), AlbumArtUrl = "/Content/Images/PizzaURL3.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, füstölt mozzarella sajt, trappista sajt, márványsajt, rukkola", Genre = genres.Single(g => g.Name == "Classical"), Price = 2090M, Artist = artists.Single(a => a.Name == "Négysajtos, rukkolás pizza"), AlbumArtUrl = "/Content/Images/PizzaURL1.jpg" },
                new Album { Title = "alul parmezán, felül sajtkrém, sajt, camembert sajt, mozzarella sajt, magok", Genre = genres.Single(g => g.Name == "Classical"), Price = 2790M, Artist = artists.Single(a => a.Name == "Parmezán sajtban sült pizza"), AlbumArtUrl = "/Content/Images/PizzaURL7.jpg" },
                new Album { Title = "pizzaparadicsom, dupla mozzarella sajt, bazsalikom", Genre = genres.Single(g => g.Name == "Jazz"), Price = 1890M, Artist = artists.Single(a => a.Name == "Pepe margaritája pizza"), AlbumArtUrl = "/Content/Images/PizzaURL1.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, paprikás vastagkolbász", Genre = genres.Single(g => g.Name == "Metal"), Price = 2190M, Artist = artists.Single(a => a.Name == "Pepperoni pizza"), AlbumArtUrl = "/Content/Images/PizzaURL5.jpg" },
                new Album { Title = "fokhagyma, tejföl, mozzarella, kígyóuborka, lila hagyma, roston csirkehús, gyrosfűszer", Genre = genres.Single(g => g.Name == "Metal"), Price = 2090M, Artist = artists.Single(a => a.Name == "Pizza a la gyros"), AlbumArtUrl = "/Content/Images/PizzaURL2.jpg" },
                new Album { Title = "BBQ, sajtkrém, roston csirkehús, császárszalonna, paradicsomkarika, mozzarella", Genre = genres.Single(g => g.Name == "Metal"), Price = 2190M, Artist = artists.Single(a => a.Name == "Rangers pizza"), AlbumArtUrl = "/Content/Images/PizzaURL4.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, sonka, gomba, kukorica", Genre = genres.Single(g => g.Name == "Metal"), Price = 2190M, Artist = artists.Single(a => a.Name == "SonGoKu pizza"), AlbumArtUrl = "/Content/Images/PizzaURL2.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, sonka", Genre = genres.Single(g => g.Name == "Classical"), Price = 2090M, Artist = artists.Single(a => a.Name == "Sonkás pizza"), AlbumArtUrl = "/Content/Images/PizzaURL2.jpg" },
                new Album { Title = "pizzaparadicsom, mozzarella, sonka, gomba", Genre = genres.Single(g => g.Name == "Classical"), Price = 2090M, Artist = artists.Single(a => a.Name == "Sonkás, gombás pizza"), AlbumArtUrl = "/Content/Images/PizzaURL2.jpg" },
                new Album { Title = "fokhagymás tejföl, tonhal, olívabogyó, kapribogyó, citrom, mozzarella", Genre = genres.Single(g => g.Name == "Metal"), Price = 2290M, Artist = artists.Single(a => a.Name == "Tonhalas pizza"), AlbumArtUrl = "/Content/Images/PizzaURL7.jpg" },
                new Album { Title = "pizzaszósz, fokhagyma, gomba, olívabogyó, articsóka, aszalt paradicsom, koktélparadicsom, csípős pfefferoni paprika, érlelt sonka, chorizo, mozzarella sajt, bazsalikom", Genre = genres.Single(g => g.Name == "Latin"), Price = 2490M, Artist = artists.Single(a => a.Name == "Capricciosa pizza normál tésztával"), AlbumArtUrl = "/Content/Images/PizzaURL6.jpg" },
                new Album { Title = "cheddar sajtszósz, parmezán sajt, natúr mozzarella sajt, trappista sajt, márványsajt, feta sajt, camembert sajt", Genre = genres.Single(g => g.Name == "Latin"), Price = 2890M, Artist = artists.Single(a => a.Name == "Sajtimádó pizza"), AlbumArtUrl = "/Content/Images/PizzaURL2.jpg" },
            }.ForEach(a => context.Albums.Add(a));
        }
    }
}