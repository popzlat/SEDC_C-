using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSong
{
   public class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusic { get; set; }

        public List <Song> FavoriteSongs { get; set; }


        public Person( string fName,string lName,int age, Genre favoriteMusic)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            FavoriteMusic = favoriteMusic;

        }

        public void GetFavoriteSong()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("Dont have favorite songs");
            }
            foreach (var item in FavoriteSongs)
            {
                Console.WriteLine($"{item.Title} ");
            }
        }

}
}
