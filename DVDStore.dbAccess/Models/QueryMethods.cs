 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDStore.db;


namespace DVDStore.web.Models
{
    public class MovieDataAccess
    {
        // get all DVDs
        //public IQueryable GetAllDVDS
        public IEnumerable<DVD> GetAllDVDS()
        
        {
            var context = new DVDStoreContext();
            {
                var result = from d in context.DVDS
                             select d;
                return result.ToList();
            }
        }

        public IEnumerable<DVD> GetDVDById(int id)

        {
            var context = new DVDStoreContext();
            {
                var result = from d in context.DVDS
                             where d.ID == id
                             select d;
                return result.ToList();
            }
        }

        // get all DVDs by genre
        public IEnumerable<DVD> GetAllDVDByGenre(Genre genre)
        {
            var context = new DVDStoreContext();
            {
                var result = from d in context.DVDS
                             where d.Genre == genre
                             select d;

                return result.ToList();

            }
        }

        // get all DVDs by rating
        public IEnumerable<DVD> GetAllDVDByRating(string rating)
        {
            var context = new DVDStoreContext();
            {
                var result = from d in context.DVDS
                             where d.Rating == rating
                             select d;

                return result.ToList();
            }
        }

        // get all DVDs by title
        public IEnumerable<DVD> GetAllDVDByTitle(string title)
        {
            var context = new DVDStoreContext();
            {
                var result = from d in context.DVDS
                             where d.Title == title
                             select d;

                return result.ToList();
            }
        }

        // get all Actors
        public IEnumerable<DVD> GetAllActors()
        {
            var context = new DVDStoreContext();
            {
                var result = from a in context.Actors
                             select a;

                //May not work. Had to cast it as list
                return result as List<DVD>;

              
            }
        }
    }
}