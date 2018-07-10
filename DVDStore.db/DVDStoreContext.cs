using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DVDStore.db
{
    public class DVDStoreContext : DbContext
    {
        public DVDStoreContext() : base("DVDStoreContext")
        {
        }
        public DbSet<DVD> DVDS { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
