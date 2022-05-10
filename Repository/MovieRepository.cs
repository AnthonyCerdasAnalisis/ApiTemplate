using apiTemplate.Context;
using apiTemplate.Models;

namespace apiTemplate.Repository
{
    public class MovieRepository : IGenericRepository<Movie>
    {
        private readonly DataBaseContext _db;

        public MovieRepository(DataBaseContext db)
        {
            _db = db;
        }

        /* public bool MovieExists(string title)
         {
             bool value = _db.Movies.Any(y => y.Title.ToLower().Trim() == title.ToLower().Trim());
             return value;
         }*/

        public IEnumerable<Movie> GetAll()
        {
            return _db.Movies.AsEnumerable();
        }

        public Movie GetById(object id)
        {
            return _db.Movies.FirstOrDefault(x => x.IdMovie == (int)id);
        }

        public Movie Insert(Movie obj)
        {
            _db.Movies.Add(obj);

            return Save(obj);
        }

        public Movie Update(Movie obj)
        {
            _db.Movies.Update(obj);
            return Save(obj);
        }

        public Movie Delete(Movie obj)
        {
            _db.Movies.Remove(obj);
            return Save(obj);
        }

        public Movie? Save(Movie obj)
        {
            return _db.SaveChanges() >= 0 ? obj : null;
        }
    }
}
