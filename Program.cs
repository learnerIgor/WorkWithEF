using DVDRental;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//каскадное удаление
using (ApplicationContext db = new())
{
    Console.WriteLine("Список улиц и городов:");
    var streets = (from i in db.Streets.Include(c => c.City) select i).ToList();
    foreach (Street street in streets)
        Console.WriteLine(street.NameStreet + " - " + street.City!.NameCity);

    Console.WriteLine("Удаляем улицу");

    var removeStreet = (from i in db.Streets where i.NameStreet == "The Mall" select i).FirstOrDefault();
    if (removeStreet != null)
        db.Streets.Remove(removeStreet);
    db.SaveChanges();

    Console.WriteLine("Список улиц и городов после удаления страны:");
    var streetNew = (from i in db.Streets select i).ToList();
    foreach (Street street in streetNew)
        Console.WriteLine(street.NameStreet + " - " + street.City!.NameCity);
    Console.WriteLine();
}

//использование Include
using (ApplicationContext dbn = new())
{
    Console.WriteLine("Информация без использования Include:");
    var films = (from i in dbn.Films select i).ToList();
    foreach (var film in films)
        Console.WriteLine(film.Title + " - " + film.Description + " - " + film.ReleaseYear.ToShortDateString() + " - " + film.Supplier + " - " + film.Language);

    Console.WriteLine("Информация после использования Include:");
    var includeFilms = (from i in dbn.Films.Include(s => s.Supplier).Include(l => l.Language) select i).ToList();
    foreach (var film in includeFilms)
        Console.WriteLine(film.Title + " - " + film.Description + " - " + film.ReleaseYear.ToShortDateString() + " - " + film.Supplier!.Name + " - " + film.Language!.NameLanguage);
    Console.WriteLine();
}

//вызов хранимой процедуры
using (ApplicationContext storedProc = new ApplicationContext())
{
    Console.WriteLine("Хранимая процедура возвращает фильмы с продолжительностью больше 105 минут:");
    SqlParameter lengthParam = new SqlParameter { ParameterName = "@length", Value = 105 };
    var films = storedProc.Films.FromSqlRaw("GetFilmsByLength @length", lengthParam).ToList();
    if (films.Count != 0)
        foreach (var film in films)
            Console.WriteLine(film.Title + " - " + film.Description + " - " + film.ReleaseYear.ToShortDateString() + " " + film.Length);
    Console.WriteLine();
}

//создание представления
using (ApplicationContext viewDb = new ApplicationContext())
{
    var existView = viewDb.Database.SqlQuery<string>($"select name from sys.views where name='View_FilmsBySupplier'").ToList();
    if (!existView.Contains("View_FilmsBySupplier"))
    {
        viewDb.Database.ExecuteSqlRaw(@"CREATE VIEW View_FilmsBySupplier AS 
                                            select s.Name as SupplierName, COUNT(f.Id) as FilmCount, SUM(f.ReplacementCost) as TotalReplacementCost from Suppliers s
                                            inner join Films f on s.Id=f.SupplierId
                                            group by s.Name");
        viewDb.SaveChanges();
    }
}

//вызов представления
using (ApplicationContext useView = new ApplicationContext())
{
    var filmsBySupplier = useView.SupplierFilmReplacementCostGroup.ToList();
    foreach (var film in filmsBySupplier)
        Console.WriteLine("Наименование поставщика: " + film.SupplierName + " Ко-во предоставленных фильмов: " + film.FilmCount + " Общая стоимость замены фильмов: " + film.TotalReplacementCost);
}