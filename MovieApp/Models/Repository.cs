using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public  static class Repository
    {
        private static List<Movie> _movies = null;
        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id=1, Name="Captain America",Description="Kaptan Amerika",ImageUrl="3.jpg"},
                new Movie(){Id=2, Name="Hulk",Description="Hulk",ImageUrl="2.jpg"},
                new Movie(){Id=3, Name="Iron Man",Description="Demir Adam",ImageUrl="3.jpg"},
                new Movie(){Id=4, Name="Hawkeye",Description="Ok",ImageUrl="4.jpg"},
                new Movie(){Id=5, Name="Black Widow",Description="Kılıç",ImageUrl="5.jpg"}

            };
        }
        public static List<Movie> Movies
        {
            get { return _movies; }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
