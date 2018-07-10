using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DVDStore.db
{
    public class DVD
    {
        [Key]
        public int ID { get; set; }
        public string  Title { get; set; }
        //public int  Genre { get; set; }
        public string  Price { get; set; }  
        public int YearReleased { get; set; }
        public string RunTime { get; set; }
        public float TotalSalesCount { get; set; }
        public string  Summary { get; set; }
        public string Rating { get; set; }
        //CoverImg
        public byte[] Cover { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
