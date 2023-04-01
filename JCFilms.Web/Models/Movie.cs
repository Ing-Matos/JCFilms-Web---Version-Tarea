using JCFilms.Web.Models.Base;

namespace JCFilms.Web.Models
{
    public class Movie : BaseModels
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int Category { get; set; } 
        public int Characters { get; set; }
    }
}
