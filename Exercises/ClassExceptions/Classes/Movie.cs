using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
  public  class Movie
    {
        public string Title { get; set; }
        public Genre GenreE { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; } = 5;

        

        public Movie(string title, Genre genre,int rating ,double ticketPrice)
        {
            Title = title;
            GenreE = genre;
            try { 
            if (rating >= 5 || rating <=1)
            {
                throw new Exception("Rating is incorrect");
            }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something wrong {ex.Message}");
            }

             Rating = rating;
            TicketPrice = ticketPrice * rating;

        }


    }
}
