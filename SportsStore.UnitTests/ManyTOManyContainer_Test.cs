using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.EF_Practice.ManyTOManyRel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.UnitTests
{



    [TestClass]
   public class ManyTOManyContainer_Test
    {
        [TestMethod]
        public void TestManyTOManyContainer()
        {
            using (var context=new ManyTOManyContainer())
            {
                //add an artist with two albums
                var artist = new Artist { FirstName = "Alan", LastName = "Jackson", MiddleName = "MN" };

                var album1 = new Album { AlbumName = "Drive" };
                var album2 = new Album { AlbumName = "Live at Texas Stadium" };

                artist.Albums.Add(album1);
                artist.Albums.Add(album2);

                context.Artists.Add(artist);

                //Add an album for two artist
                var artist1 = new Artist { FirstName = "Tobby", LastName = "Keith", MiddleName = "MN" };
                var artist2 = new Artist { FirstName = "Merle", LastName = "Haggard", MiddleName = "MN" };

                var album = new Album { AlbumName = "Honkytonk University" };

                album.Artists.Add(artist1);
                album.Artists.Add(artist2);
               // artist1.Albums.Add(album);
                //artist2.Albums.Add(album);

                context.Albums.Add(album);

                context.SaveChanges();
            }

        }


        [TestMethod]
        public void TestGetAlbumArtist()
        {
            using (var context = new ManyTOManyContainer())
            {
                Debug.WriteLine("Artists and their albums...");
                var artists = context.Artists;
                foreach (var artist in artists)
                {
                    Debug.WriteLine("{0} {1}", artist.FirstName, artist.LastName);
                    foreach (var album in artist.Albums)
                    {
                        Debug.WriteLine("\t{0}", album.AlbumName);
                    }
                }
                Debug.WriteLine("\nAlbums and their artists...");
                var albums = context.Albums;
                foreach (var album in albums)
                {
                    Debug.WriteLine("{0}", album.AlbumName);
                    foreach (var artist in album.Artists)
                    {
                        Debug.WriteLine("\t{0} {1}", artist.FirstName, artist.LastName);
                    }
                }
            }
        }

    }
}
