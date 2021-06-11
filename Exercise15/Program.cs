using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Novel novel = new Novel();
            Movie movie = new Movie();
            Song song = new Song();


            Console.Write("Enter name of novel: ");
            novel.name = Console.ReadLine();
            Console.Write("Enter name of author: ");
            novel.author = Console.ReadLine();

            Console.Write("Enter name of movie: ");
            movie.name = Console.ReadLine();
            Console.Write("Enter name of screenwriter: ");
            movie.screenwriter = Console.ReadLine();

            Console.Write("Enter name of song: ");
            song.name = Console.ReadLine();
            Console.Write("Enter name of songwriter: ");
            song.songwriter = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("********************************************");
            Console.WriteLine("LIST OF CREATIVE WORKS");
            Console.WriteLine();

            PrintWriter(novel);
            PrintWriter(movie);
            PrintWriter(song);

        }

        static void PrintWriter(IWritable write)
        {
            
            Console.WriteLine($"Name of Work: {write.GetNameOfWork()}");
            Console.WriteLine($"Name of Work: {write.GetWriter()}");
            Console.WriteLine();
        }
    }
}
