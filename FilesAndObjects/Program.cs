using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesAndObjects
{
    class Program
    {
        private static object fileName;

         public class Movie
        {
            public string title;
            public string rating;
            public string year;
       

            public Movie(string v1, string v2, string v3)
            {
                title = v1;
                rating = v2;
                year = v3;
            }

            


        }
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\opilane\samples";
            string fileName = @"movietv.txt";

            List<string> movieList = File.ReadAllLines(Path.Combine(FilePath, fileName)).ToList();
            List<Movie> listOfMovies = new List<Movie>();
            foreach(string movieItem in movieList)
            {
                string[] tempArray = movieItem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2] );

                listOfMovies.Add(newMovie);
            }

            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"title: {movie.title}; Rating: {movie.rating}; year: {movie.year};");
            }
           
            Console.WriteLine("What is your favorite movie? enter te title:");
            string favmovietitle = Console.ReadLine();
        Console.WriteLine("enter your favorite movie rating");
            string favMovieRating = Console.ReadLine();
        Console.WriteLine("enter the release year:");
            string favMovieYear = Console.ReadLine();

        Movie favMovie = new Movie(favmovietitle, favMovieRating, favMovieYear);
            string favMovieLine = $"{favMovie.title};{favMovie.rating};{favMovie.year};";

            movieList.Add(favMovieLine);
            File.WriteAllLines(Path.Combine(FilePath, fileName), movieList);
        }
        
    }
}
