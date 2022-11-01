using System;
namespace Classes
{
    public class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string movieTitle, string movieDirector, string movieRating)
        {
            Title = movieTitle;
            Director = movieDirector;
            Rating = movieRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value;  }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }
    }
}

