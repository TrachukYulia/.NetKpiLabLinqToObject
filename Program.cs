using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Actor> actors = new List<Actor>()
            {
               new Actor(idOfActor: 1, fullName: "Willard Smith Carroll",
                dateOfBirthday: new DateTime(1977, 12, 1), amplua: new List<string>{"Heroe", "Moralist" }),
                new Actor(idOfActor: 2, fullName: "Kunis Mila Markivna",
                dateOfBirthday: new DateTime(1977, 4, 11), amplua: new List<string>{"Loved", "Friend" }),
                new Actor(idOfActor: 3, fullName: "Clarke Emilia Rous",
                dateOfBirthday: new DateTime(1988, 10, 1), amplua: new List<string>{"Loved", "Courtesan", "Villain"}),
                new Actor(idOfActor: 4, fullName: "Chan Kong-sang",
                dateOfBirthday: new DateTime(1954, 4, 5), amplua: new List<string>{"Figth", "Guardian", "Moralist", "Friend"}),
                new Actor(idOfActor: 5, fullName: "Catherine Elise Blanchett",
                dateOfBirthday: new DateTime(1969, 5, 14), amplua: new List<string>{ "Promoting"}),
                new Actor(idOfActor: 6, fullName: "Jolie Angelina Voyt",
                dateOfBirthday: new DateTime(1975, 6, 4), amplua: new List<string>{ "Villain", "Guardian", "Loved"}),
                new Actor(idOfActor: 7, fullName: "Cassel Vincent Crochon",
                dateOfBirthday: new DateTime(1966, 10, 23), amplua: new List<string>{ "Scientist", "Moralist", "Heroe"})
            };

            List<Movie> movies = new List<Movie>()
            {
                new Movie(idOfMovie: 1, name: "Harry Potter", dateOfIssue: new DateTime(2003, 10, 21),
                genreOfMovie:new List<string>{"Fantasy"}, fullNameOfDirector: "Woody Allen"),
                new Movie(idOfMovie: 2, name: "Black Panther", dateOfIssue: new DateTime(2018, 6, 12),
                genreOfMovie:new List<string>{"Action", "Adventure", "Fantasy"},fullNameOfDirector: "Thom Andersen"),
                new Movie(idOfMovie: 3, name: "Game of Thrones", dateOfIssue: new DateTime(2019, 12, 6),
                genreOfMovie:new List<string>{"Drama", "Adventure", "Fantasy"}, fullNameOfDirector: "Ryan Coogler"),
                new Movie(idOfMovie: 4, name: "Malificenta", dateOfIssue: new DateTime(2019, 5, 24),
                genreOfMovie:new List<string>{"Drama", "Fantasy"}, fullNameOfDirector:"John Mallory Asher"),
                new Movie(idOfMovie: 5, name: "Jackie Chan", dateOfIssue: new DateTime(2005, 8, 13),
                genreOfMovie:new List<string>{"Action", "Adventure", "Figth"}, fullNameOfDirector: "Broncho Billy Anderson"),
                  new Movie(idOfMovie: 6, name: "Cinnderela", dateOfIssue: new DateTime(2014, 3, 30),
                genreOfMovie:new List<string>{"Drama", "Adventure"}, fullNameOfDirector:"Jolie Angelina Voyt"),
                    new Movie(idOfMovie: 7, name: "Beauty and the Beast", dateOfIssue: new DateTime(2014, 5, 20),
                genreOfMovie:new List<string>{ "Fantasy", "Romance"}, fullNameOfDirector: "Cassel Vincent Crochon"),
                    new Movie(idOfMovie: 8, name: "Pirates of the Carybbean", dateOfIssue: new DateTime(2010, 10, 5),
                genreOfMovie:new List<string>{ "Fantasy", "Adventure"}, fullNameOfDirector: "Woody Allen")


            };
            List<DataLinkActorsAndMovie> dataLinkActorsAndMovies = new List<DataLinkActorsAndMovie>()
            {
                new DataLinkActorsAndMovie(idOfActorOnMovie:1, idOfActor:5, idOfMovies: 1),
                new DataLinkActorsAndMovie(idOfActorOnMovie:2, idOfActor:2, idOfMovies: 1),
                new DataLinkActorsAndMovie(idOfActorOnMovie:3, idOfActor:1, idOfMovies: 2),
                new DataLinkActorsAndMovie(idOfActorOnMovie:4, idOfActor:3, idOfMovies: 3),
                new DataLinkActorsAndMovie(idOfActorOnMovie:5, idOfActor:1, idOfMovies: 3),
                new DataLinkActorsAndMovie(idOfActorOnMovie:6, idOfActor:6, idOfMovies: 4),
                new DataLinkActorsAndMovie(idOfActorOnMovie:7, idOfActor:5, idOfMovies: 4),
                new DataLinkActorsAndMovie(idOfActorOnMovie:8, idOfActor:4, idOfMovies: 5),
                new DataLinkActorsAndMovie(idOfActorOnMovie:9, idOfActor:5, idOfMovies: 6),
                new DataLinkActorsAndMovie(idOfActorOnMovie:10, idOfActor:2, idOfMovies: 6),
                new DataLinkActorsAndMovie(idOfActorOnMovie:11, idOfActor:7, idOfMovies: 6),
                new DataLinkActorsAndMovie(idOfActorOnMovie:11, idOfActor:7, idOfMovies: 7),
                new DataLinkActorsAndMovie(idOfActorOnMovie:11, idOfActor:6, idOfMovies: 7),
            };
            List<Perfomance> perfomances = new List<Perfomance>()
            {
                new Perfomance(idOfPerfomance:1, name: "Master and Margarita",
                genreOfPerfomance: "Drama"),
                new Perfomance(idOfPerfomance:2, name: "Shoot",
                genreOfPerfomance: "Adventure"),
                new Perfomance(idOfPerfomance:3, name: "Space X",
                genreOfPerfomance: "Scientific"),
                new Perfomance(idOfPerfomance:4, name: "Phoenix",
                genreOfPerfomance: "Drama"),
                 new Perfomance(idOfPerfomance:5, name: "Triumph",
                genreOfPerfomance: "Adventure"),
            };
            List<DataLinkActorsAndPerfomance> dataLinkActorsAndPerfomances = new List<DataLinkActorsAndPerfomance>
            {
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:1, idOfActor:1, idOfPerfomance: 1),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:2, idOfActor:3, idOfPerfomance: 1),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:3, idOfActor:6, idOfPerfomance: 2),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:4, idOfActor:5, idOfPerfomance: 2),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:5, idOfActor:7, idOfPerfomance: 3),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:6, idOfActor:3, idOfPerfomance: 4),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:7, idOfActor:4, idOfPerfomance: 4),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:7, idOfActor:5, idOfPerfomance: 4),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:8, idOfActor:4, idOfPerfomance: 5),
                new DataLinkActorsAndPerfomance(idOfActorOnPerfomance:8, idOfActor:7, idOfPerfomance: 5),

            };
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Виведемо всі вистави ");

            ///   < summary >
            ///    Проста вибірка
            ///   </ summary >
            var task1 = from x in perfomances
                        select x;
            foreach (var x in task1)
                Console.WriteLine(x);

            Console.WriteLine("Виведемо всіх режисерів ");
            ///   < summary >
            ///   Проекція (вибірка окремого поля)
            ///   </ summary >
            var q1 = from x in movies
                     select x.FullNameOfDirector;
            foreach (var x in q1)
                Console.WriteLine("FullName of Director: {0}", x);

            Console.WriteLine("Виведемо всіх акторів, кінофільмів у яких вони грають та жанр");
            ///   < summary >   `
            ///   Умови. Створення об'єкту анонімного типу.
            ///   </ summary >
            var task2 = from x in dataLinkActorsAndMovies
                        from y in movies
                        from z in actors
                        let v1 = (x.IdOfMovie == y.IdOfMovie)
                        let v2 = (x.IdOfActor == z.IdOfActor)
                        where v1 && v2
                        select new { NameOfMovie = y.Name, FullName = z.FullName, ListOfGenre = y.GetListOfGenre() };
            foreach (var item in task2)
                Console.WriteLine("Actor:{0}, Movie:{1}, Genre:{2}", item.FullName, item.NameOfMovie, item.ListOfGenre);

            Console.WriteLine("Сортування акторів по к-ть ролей");
            ///   < summary >
            ///  Сортування. Group Join. Агрегатна операція 
            ///   </ summary >
            var task3 = from x in actors
                        join y in dataLinkActorsAndMovies on x.IdOfActor equals y.IdOfActor into temp
                        orderby temp.Count() descending
                        select new { Name = x.FullName, counter = temp.Count() };
            foreach (var item in task3)
                Console.WriteLine("Actor:{0}, Counter:{1}", item.Name, item.counter);

            Console.WriteLine("Виведемо всіх акторів, які є також режисерами");
            ///   < summary >
            ///   "Inner Join з використанням Where"
            ///   </ summary >
            var task4 = from y in movies
                        from z in actors
                        where y.FullNameOfDirector == z.FullName
                        select new { y, z };
            foreach (var item in task4)
                Console.WriteLine("Actor:{0}, Movie like Director:{1}, Director:{2}", item.z.FullName, item.y.Name, item.y.FullNameOfDirector);

            Console.WriteLine("Виведемо акторів, амплуа яких > 3, відсортуємо за спаданням");
            ///   < summary >
            ///   Сортування із використанням розширюючих методів.
            ///   </ summary >
            var task5 = actors.Where(x => x.Amplua.Count() >= 3).
                OrderByDescending(x => x.Amplua.Count());
            foreach (var item in task5)
                Console.WriteLine("Name:{0}, Amplua:{1}, Counter:{2}", item.FullName, item.GetListOfAmplua(), item.Amplua.Count());

            ///   < summary >
            ///  Фільтрація
            ///   </ summary >
            Console.WriteLine("Виведемо перелік акторів, фамілії яких починаються з літери «C»");
            var task6 = from t in actors
                        where t.FullName.ToUpper().StartsWith("C")
                        select t;
            foreach (var item in task6)
            {
                Console.WriteLine("Full Name: {0}", item.FullName);
            }

            Console.WriteLine("7.Виведемо акторів, які народились після 1980 і мають задане амплуа ");
            ///   < summary >
            ///  Складні фільтри
            ///   </ summary >
            var task7 = from x in actors
                        from amplua in x.Amplua
                        where x.DateOfBirthday.Year > 1980
                        where amplua == "Loved"
                        select x;
            foreach (var item in task7)
            {
                Console.WriteLine("Full Name: {0}, Date Of Birthday: {1}", item.FullName, item.DateOfBirthday);
            }

            Console.WriteLine("Виведемо всіх акторів, котрі грали і в спектаклі, і в фільмі");
            ///   < summary >
            ///  Group Join. Inner Join. Distinct.
            ///   </ summary >
            var task8 = from x in dataLinkActorsAndPerfomances
                        join y in dataLinkActorsAndMovies on x.IdOfActor equals y.IdOfActor into temp
                        from t in temp
                        from z in actors
                        where t.IdOfActor == z.IdOfActor
                        select new { Id = z.IdOfActor, Name = z.FullName };
            foreach (var item in task8.Distinct())
                Console.WriteLine("Id:{0}, Actor:{1}", item.Id, item.Name);

            Console.WriteLine("Виведемо всіх акторів, котрі не грали в спектаклі, але грали у фільмі");
            ///   < summary >
            ///  Group Join. Except.
            ///   </ summary >
            var task9_1 = from x in dataLinkActorsAndPerfomances
                          join y in dataLinkActorsAndMovies on x.IdOfActor equals y.IdOfActor into temp
                          from t in temp
                          select new { id = t.IdOfActor };
            var task9_2 = from z in actors
                          select new { id = z.IdOfActor };
            foreach (var item in task9_2.Except(task9_1))
                Console.WriteLine("Id:{0}", item.id);

            Console.WriteLine("Виведемо всі фільми і спектаклі");
            ///   < summary >
            ///  Concat
            ///   </ summary >
            var task10_1 = from x in movies
                           select new { Name = x.Name };
            var task10_2 = from y in perfomances
                           select new { Name = y.Name };
            foreach (var item in task10_2.Concat(task10_1))
                Console.WriteLine("Name:{0}", item.Name);

            Console.WriteLine("Згрупуємо акторів по роках народження і порахуємо к-ть по роках");
            ///   < summary >
            ///  Групування Any
            ///   </ summary >
            var task11 = from x in actors
                         group x by x.DateOfBirthday.Year into g
                         where g.Any(x => x.Amplua.Count > 1)
                         select new
                         {
                             Key = g.Key,
                             cnt = g.Count(),
                         };
            foreach (var item in task11)
            {
                Console.WriteLine("Date of birthday:{0}, Counter: {1}  ", item.Key, item.cnt);
            }

            Console.WriteLine("Згрупуємо вистави по жанрам та підрахуємо їх кількість");
            ///   < summary >
            ///  Групування з функціями агрегування 
            ///   </ summary >
            var task12 = from x in perfomances
                         group x by x.GenreOfPerfomance into g
                         select new
                         {
                             Key = g.Key,
                             Values = g,
                             cnt = g.Count(),
                         };
            foreach (var item in task12)
            {
                Console.WriteLine("List of Amplua:{0}, Counter:{1}", item.Key, item.cnt);
            }

            Console.WriteLine("Найдемо новий фільм по заданим жанрам");
            ///   < summary >
            ///  Складні фільтри з використанням розширюючих методів 
            ///   </ summary >
            var task13 = movies.SelectMany(u => u.GenreOfMovie, (u, l) =>
            new
            {
                movie = u,
                genre = l
            }).Where(u => (u.genre == "Fantasy" || u.genre == "Adventure")
            && u.movie.DateOfIssue.Year > 2010).Select(u => (u.genre, u.movie.Name));
            foreach (var item in task13)
                Console.WriteLine("Name of film: {0}, Picked genre: {1}", item.Name, item.genre);

            Console.WriteLine("Найдемо актора який має більше всіх ролей");
            ///   < summary >
            ///  Сортування. Group Join. Агрегатна операція. Перший елемент з вибірки
            ///   </ summary >
            var task14 = from x in actors
                         join y in dataLinkActorsAndMovies on x.IdOfActor equals y.IdOfActor into temp
                         orderby temp.Count() descending
                         select new { Name = x.FullName, counter = temp.Count() };
            Console.WriteLine("Actor and counter:{0}", task14.First());

            ///   < summary >
            ///  Сортування. Останній елемент вибірки
            ///   </ summary >
            Console.WriteLine("Найдемо найстаріший фільм");
            var task15 = from x in movies
                         orderby x.DateOfIssue.Year descending
                         select new { Name = x.Name, year = x.DateOfIssue.Year };
            Console.WriteLine("Name and year:{0}", task15.Last());

        }
    }
}
