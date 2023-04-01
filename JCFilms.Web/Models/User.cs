using JCFilms.Web.Models.Base;

namespace JCFilms.Web.Models
{
  
    public class User : BaseModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
