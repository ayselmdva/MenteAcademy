using ConsoleApp.DAL;
using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InsertCity();

            //Console.WriteLine(DeleteCity(1));

        }


        static void InsertCity()
        {
            AppDbContext db = new AppDbContext();
            db.Cities.Add(new City { Name="Baki"});
            db.SaveChanges();
        }


        static bool DeleteCity(int id)
        {
            AppDbContext db= new AppDbContext();
            City ?city = db.Cities.Find(id);
            db.Cities.Remove(city);
            var result= db.SaveChanges()>0;
            return result;
        }

        
       
    }
}
